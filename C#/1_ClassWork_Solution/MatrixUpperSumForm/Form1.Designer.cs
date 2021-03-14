
namespace MatrixUpperSumForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rowCount = new System.Windows.Forms.NumericUpDown();
            this.colCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generateMatrix = new System.Windows.Forms.Button();
            this.calculateSum = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.GroupBox();
            this.resultBox = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colCount)).BeginInit();
            this.result.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resetButton);
            this.groupBox1.Controls.Add(this.calculateSum);
            this.groupBox1.Controls.Add(this.generateMatrix);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.colCount);
            this.groupBox1.Controls.Add(this.rowCount);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // rowCount
            // 
            this.rowCount.Location = new System.Drawing.Point(66, 19);
            this.rowCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rowCount.Name = "rowCount";
            this.rowCount.Size = new System.Drawing.Size(90, 20);
            this.rowCount.TabIndex = 0;
            this.rowCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // colCount
            // 
            this.colCount.Location = new System.Drawing.Point(66, 45);
            this.colCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colCount.Name = "colCount";
            this.colCount.Size = new System.Drawing.Size(90, 20);
            this.colCount.TabIndex = 1;
            this.colCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Columns";
            // 
            // generateMatrix
            // 
            this.generateMatrix.Location = new System.Drawing.Point(16, 71);
            this.generateMatrix.Name = "generateMatrix";
            this.generateMatrix.Size = new System.Drawing.Size(140, 23);
            this.generateMatrix.TabIndex = 4;
            this.generateMatrix.Text = "Generate";
            this.generateMatrix.UseVisualStyleBackColor = true;
            this.generateMatrix.Click += new System.EventHandler(this.generateMatrix_Click);
            // 
            // calculateSum
            // 
            this.calculateSum.Enabled = false;
            this.calculateSum.Location = new System.Drawing.Point(16, 122);
            this.calculateSum.Name = "calculateSum";
            this.calculateSum.Size = new System.Drawing.Size(140, 23);
            this.calculateSum.TabIndex = 1;
            this.calculateSum.Text = "Calculate";
            this.calculateSum.UseVisualStyleBackColor = true;
            this.calculateSum.Click += new System.EventHandler(this.calculateSum_Click);
            // 
            // result
            // 
            this.result.Controls.Add(this.resultBox);
            this.result.Location = new System.Drawing.Point(12, 172);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(178, 89);
            this.result.TabIndex = 1;
            this.result.TabStop = false;
            this.result.Text = "Result";
            // 
            // resultBox
            // 
            this.resultBox.AutoSize = true;
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(39, 16);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(0, 63);
            this.resultBox.TabIndex = 2;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(16, 96);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(140, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.generateMatrix;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 284);
            this.Controls.Add(this.result);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(724, 323);
            this.MinimumSize = new System.Drawing.Size(724, 323);
            this.Name = "Form1";
            this.Text = "Matrix";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colCount)).EndInit();
            this.result.ResumeLayout(false);
            this.result.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button generateMatrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown colCount;
        private System.Windows.Forms.NumericUpDown rowCount;
        private System.Windows.Forms.Button calculateSum;
        private System.Windows.Forms.GroupBox result;
        private System.Windows.Forms.Label resultBox;
        private System.Windows.Forms.Button resetButton;
    }
}

