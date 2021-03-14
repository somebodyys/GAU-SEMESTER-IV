
namespace TriangleCheckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sideOne = new System.Windows.Forms.NumericUpDown();
            this.sideThree = new System.Windows.Forms.NumericUpDown();
            this.sideTwo = new System.Windows.Forms.NumericUpDown();
            this.checkButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sideOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // sideOne
            // 
            this.sideOne.Location = new System.Drawing.Point(32, 21);
            this.sideOne.Name = "sideOne";
            this.sideOne.Size = new System.Drawing.Size(48, 20);
            this.sideOne.TabIndex = 0;
            this.sideOne.Tag = "";
            // 
            // sideThree
            // 
            this.sideThree.Location = new System.Drawing.Point(140, 21);
            this.sideThree.Name = "sideThree";
            this.sideThree.Size = new System.Drawing.Size(48, 20);
            this.sideThree.TabIndex = 1;
            // 
            // sideTwo
            // 
            this.sideTwo.Location = new System.Drawing.Point(86, 21);
            this.sideTwo.Name = "sideTwo";
            this.sideTwo.Size = new System.Drawing.Size(48, 20);
            this.sideTwo.TabIndex = 2;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(197, 14);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 33);
            this.checkButton.TabIndex = 3;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(88, 51);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(46, 13);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Result : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // resultBox
            // 
            this.resultBox.AutoSize = true;
            this.resultBox.Location = new System.Drawing.Point(141, 51);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(0, 13);
            this.resultBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "c";
            // 
            // Form1
            // 
            this.AcceptButton = this.checkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 73);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.sideTwo);
            this.Controls.Add(this.sideThree);
            this.Controls.Add(this.sideOne);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 112);
            this.MinimumSize = new System.Drawing.Size(300, 112);
            this.Name = "Form1";
            this.Text = "Triangle Check";
            ((System.ComponentModel.ISupportInitialize)(this.sideOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown sideOne;
        private System.Windows.Forms.NumericUpDown sideThree;
        private System.Windows.Forms.NumericUpDown sideTwo;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

