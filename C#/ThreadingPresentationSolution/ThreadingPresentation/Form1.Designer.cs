
namespace ThreadingPresentation
{
    partial class Form1
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
            this.userFileButton = new System.Windows.Forms.Button();
            this.regBox = new System.Windows.Forms.GroupBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.lnameInput = new System.Windows.Forms.TextBox();
            this.fnameInput = new System.Windows.Forms.TextBox();
            this.logScreen = new System.Windows.Forms.RichTextBox();
            this.regBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userFileButton
            // 
            this.userFileButton.Location = new System.Drawing.Point(273, 101);
            this.userFileButton.Name = "userFileButton";
            this.userFileButton.Size = new System.Drawing.Size(75, 23);
            this.userFileButton.TabIndex = 1;
            this.userFileButton.Text = "LoadUsers";
            this.userFileButton.UseVisualStyleBackColor = true;
            this.userFileButton.Click += new System.EventHandler(this.userFileButton_Click);
            // 
            // regBox
            // 
            this.regBox.Controls.Add(this.downloadButton);
            this.regBox.Controls.Add(this.registerButton);
            this.regBox.Controls.Add(this.userFileButton);
            this.regBox.Controls.Add(this.label3);
            this.regBox.Controls.Add(this.label2);
            this.regBox.Controls.Add(this.label1);
            this.regBox.Controls.Add(this.emailInput);
            this.regBox.Controls.Add(this.lnameInput);
            this.regBox.Controls.Add(this.fnameInput);
            this.regBox.Location = new System.Drawing.Point(13, 13);
            this.regBox.Name = "regBox";
            this.regBox.Size = new System.Drawing.Size(399, 143);
            this.regBox.TabIndex = 2;
            this.regBox.TabStop = false;
            this.regBox.Text = "Registration";
            // 
            // downloadButton
            // 
            this.downloadButton.Enabled = false;
            this.downloadButton.Location = new System.Drawing.Point(146, 101);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(121, 23);
            this.downloadButton.TabIndex = 7;
            this.downloadButton.Text = "Download Content";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(65, 101);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(82, 58);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(279, 20);
            this.emailInput.TabIndex = 2;
            // 
            // lnameInput
            // 
            this.lnameInput.Location = new System.Drawing.Point(261, 32);
            this.lnameInput.Name = "lnameInput";
            this.lnameInput.Size = new System.Drawing.Size(100, 20);
            this.lnameInput.TabIndex = 1;
            // 
            // fnameInput
            // 
            this.fnameInput.Location = new System.Drawing.Point(82, 32);
            this.fnameInput.Name = "fnameInput";
            this.fnameInput.Size = new System.Drawing.Size(100, 20);
            this.fnameInput.TabIndex = 0;
            // 
            // logScreen
            // 
            this.logScreen.Location = new System.Drawing.Point(12, 162);
            this.logScreen.Name = "logScreen";
            this.logScreen.Size = new System.Drawing.Size(400, 274);
            this.logScreen.TabIndex = 3;
            this.logScreen.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 448);
            this.Controls.Add(this.logScreen);
            this.Controls.Add(this.regBox);
            this.MaximumSize = new System.Drawing.Size(445, 487);
            this.MinimumSize = new System.Drawing.Size(445, 487);
            this.Name = "Form1";
            this.Text = "Threading Registration";
            this.regBox.ResumeLayout(false);
            this.regBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button userFileButton;
        private System.Windows.Forms.GroupBox regBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox lnameInput;
        private System.Windows.Forms.TextBox fnameInput;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.RichTextBox logScreen;
    }
}

