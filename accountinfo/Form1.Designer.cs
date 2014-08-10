namespace accountinfo
{
    partial class AccountInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.computerNameLabel = new System.Windows.Forms.Label();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.adobeAccountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // computerNameLabel
            // 
            this.computerNameLabel.AutoSize = true;
            this.computerNameLabel.Location = new System.Drawing.Point(37, 149);
            this.computerNameLabel.Name = "computerNameLabel";
            this.computerNameLabel.Size = new System.Drawing.Size(80, 13);
            this.computerNameLabel.TabIndex = 1;
            this.computerNameLabel.Text = "computer name";
            // 
            // serialTextBox
            // 
            this.serialTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.serialTextBox.Location = new System.Drawing.Point(40, 63);
            this.serialTextBox.Multiline = true;
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(180, 49);
            this.serialTextBox.TabIndex = 2;
            // 
            // adobeAccountTextBox
            // 
            this.adobeAccountTextBox.Location = new System.Drawing.Point(40, 205);
            this.adobeAccountTextBox.Name = "adobeAccountTextBox";
            this.adobeAccountTextBox.Size = new System.Drawing.Size(180, 20);
            this.adobeAccountTextBox.TabIndex = 3;
            // 
            // AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.adobeAccountTextBox);
            this.Controls.Add(this.serialTextBox);
            this.Controls.Add(this.computerNameLabel);
            this.Name = "AccountInfo";
            this.Text = "Account Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label computerNameLabel;
        private System.Windows.Forms.TextBox serialTextBox;
        private System.Windows.Forms.TextBox adobeAccountTextBox;

    }
}

