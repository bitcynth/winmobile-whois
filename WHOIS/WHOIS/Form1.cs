using System;
using System.Net.Sockets;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WHOIS
{
    public partial class WhoisForm : Form
    {
        private Regex ianaExtractWhoisRegex = new Regex("^whois:\\s+([a-zA-Z0-9\\.\\-]+)$");

        public WhoisForm()
        {
            InitializeComponent();
        }

        // Implements the extremely basic whois protocol
        private string QueryWhoisServer(string host, int port, string query)
        {
            TcpClient client = new TcpClient(host, port);
            byte[] queryBytes = System.Text.Encoding.UTF8.GetBytes(query + "\r\n");

            NetworkStream stream = client.GetStream();

            stream.Write(queryBytes, 0, queryBytes.Length);

            String resp = "";
            byte[] respBuf = new byte[1024];
            try
            {
                while (true)
                {
                    Int32 byteCount = stream.Read(respBuf, 0, respBuf.Length);
                    resp += System.Text.Encoding.UTF8.GetString(respBuf, 0, byteCount);

                    if (byteCount <= 0)
                    {
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            stream.Close();
            client.Close();

            return resp;
        }

        private string QueryWhoisRecursive(string query)
        {
            string rootResult = QueryWhoisServer("whois.iana.org", 43, query);
            char[] sep = { '\n' };
            string[] lines = rootResult.Split(sep);
            string nextWhoisServer = null;
            foreach (string line in lines)
            {
                Match match = ianaExtractWhoisRegex.Match(line);
                if (match.Success)
                {
                    nextWhoisServer = match.Groups[1].Value;
                    break;
                }
            }
            if (nextWhoisServer == null)
            {
                return rootResult;
            }

            return QueryWhoisServer(nextWhoisServer, 43, query);
        }

        private void DoTheThing()
        {
            string whoisResult = QueryWhoisRecursive(inputTextBox.Text);

            resultTextBox.Text = whoisResult.Replace("\n", System.Environment.NewLine);
        }

        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DoTheThing();
                e.Handled = true;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DoTheThing();
        }
    }
}