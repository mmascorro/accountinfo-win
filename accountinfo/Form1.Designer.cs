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
            this.localComputerNameLabel = new System.Windows.Forms.Label();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.adobeAccountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.remoteComputerNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // localComputerNameLabel
            // 
            this.localComputerNameLabel.AutoSize = true;
            this.localComputerNameLabel.Location = new System.Drawing.Point(138, 77);
            this.localComputerNameLabel.Name = "localComputerNameLabel";
            this.localComputerNameLabel.Size = new System.Drawing.Size(80, 13);
            this.localComputerNameLabel.TabIndex = 1;
            this.localComputerNameLabel.Text = "computer name";
            // 
            // serialTextBox
            // 
            this.serialTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.serialTextBox.Location = new System.Drawing.Point(40, 36);
            this.serialTextBox.Multiline = true;
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(201, 27);
            this.serialTextBox.TabIndex = 2;
            // 
            // adobeAccountTextBox
            // 
            this.adobeAccountTextBox.Location = new System.Drawing.Point(40, 185);
            this.adobeAccountTextBox.Name = "adobeAccountTextBox";
            this.adobeAccountTextBox.Size = new System.Drawing.Size(201, 20);
            this.adobeAccountTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Remote Info:";
            // 
            // remoteComputerNameLabel
            // 
            this.remoteComputerNameLabel.AutoSize = true;
            this.remoteComputerNameLabel.Location = new System.Drawing.Point(138, 131);
            this.remoteComputerNameLabel.Name = "remoteComputerNameLabel";
            this.remoteComputerNameLabel.Size = new System.Drawing.Size(80, 13);
            this.remoteComputerNameLabel.TabIndex = 5;
            this.remoteComputerNameLabel.Text = "computer name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Serial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Registered Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adobe Account:";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(40, 219);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(201, 23);
            this.registerBtn.TabIndex = 10;
            this.registerBtn.Text = "Register with Server";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.remoteComputerNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adobeAccountTextBox);
            this.Controls.Add(this.serialTextBox);
            this.Controls.Add(this.localComputerNameLabel);
            this.Name = "AccountInfo";
            this.Text = "Account Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label localComputerNameLabel;
        private System.Windows.Forms.TextBox serialTextBox;
        private System.Windows.Forms.TextBox adobeAccountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label remoteComputerNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button registerBtn;

    }
}

