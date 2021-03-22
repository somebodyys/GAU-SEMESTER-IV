
namespace MusicForm
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
            this.Controls = new System.Windows.Forms.GroupBox();
            this.choice = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // Controls
            // 
            this.Controls.Controls.Add(this.button1);
            this.Controls.Controls.Add(this.choice);
            this.Controls.Location = new System.Drawing.Point(12, 12);
            this.Controls.Name = "Controls";
            this.Controls.Size = new System.Drawing.Size(233, 138);
            this.Controls.TabIndex = 0;
            this.Controls.TabStop = false;
            this.Controls.Text = "Control Panel";
            // 
            // choice
            // 
            this.choice.FormattingEnabled = true;
            this.choice.Items.AddRange(new object[] {
            "Music",
            "String",
            "Guitar"});
            this.choice.Location = new System.Drawing.Point(6, 33);
            this.choice.Name = "choice";
            this.choice.Size = new System.Drawing.Size(121, 21);
            this.choice.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Controls);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Controls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Controls;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox choice;
    }
}

