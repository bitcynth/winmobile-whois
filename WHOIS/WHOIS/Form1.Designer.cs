namespace WHOIS
{
    partial class WhoisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.submitButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(165, 4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(72, 20);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(4, 3);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(155, 21);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(4, 31);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultTextBox.Size = new System.Drawing.Size(233, 234);
            this.resultTextBox.TabIndex = 2;
            this.resultTextBox.WordWrap = false;
            // 
            // WhoisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.submitButton);
            this.Menu = this.mainMenu1;
            this.Name = "WhoisForm";
            this.Text = "WHOIS (Cynthia.re)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

