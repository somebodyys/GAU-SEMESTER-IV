
namespace BuyToys
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cuddlyRadio = new System.Windows.Forms.RadioButton();
            this.itemCount = new System.Windows.Forms.Label();
            this.toyRadio = new System.Windows.Forms.RadioButton();
            this.AddButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.toyPrice = new System.Windows.Forms.NumericUpDown();
            this.nameLabel = new System.Windows.Forms.Label();
            this.toyName = new System.Windows.Forms.TextBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toyPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cuddlyRadio);
            this.groupBox1.Controls.Add(this.itemCount);
            this.groupBox1.Controls.Add(this.toyRadio);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.toyPrice);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.toyName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toy Info";
            // 
            // cuddlyRadio
            // 
            this.cuddlyRadio.AutoSize = true;
            this.cuddlyRadio.Location = new System.Drawing.Point(21, 102);
            this.cuddlyRadio.Name = "cuddlyRadio";
            this.cuddlyRadio.Size = new System.Drawing.Size(78, 17);
            this.cuddlyRadio.TabIndex = 3;
            this.cuddlyRadio.TabStop = true;
            this.cuddlyRadio.Text = "Cuddly Toy";
            this.cuddlyRadio.UseVisualStyleBackColor = true;
            // 
            // itemCount
            // 
            this.itemCount.AutoSize = true;
            this.itemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCount.Location = new System.Drawing.Point(218, 90);
            this.itemCount.Name = "itemCount";
            this.itemCount.Size = new System.Drawing.Size(0, 39);
            this.itemCount.TabIndex = 5;
            // 
            // toyRadio
            // 
            this.toyRadio.AutoSize = true;
            this.toyRadio.Checked = true;
            this.toyRadio.Location = new System.Drawing.Point(21, 83);
            this.toyRadio.Name = "toyRadio";
            this.toyRadio.Size = new System.Drawing.Size(43, 17);
            this.toyRadio.TabIndex = 2;
            this.toyRadio.TabStop = true;
            this.toyRadio.Text = "Toy";
            this.toyRadio.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(105, 96);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(107, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add To Chart";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(18, 59);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(52, 13);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Toy Price";
            // 
            // toyPrice
            // 
            this.toyPrice.DecimalPlaces = 2;
            this.toyPrice.Location = new System.Drawing.Point(77, 57);
            this.toyPrice.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.toyPrice.Name = "toyPrice";
            this.toyPrice.Size = new System.Drawing.Size(186, 20);
            this.toyPrice.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(18, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(56, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Toy Name";
            // 
            // toyName
            // 
            this.toyName.Location = new System.Drawing.Point(77, 30);
            this.toyName.Name = "toyName";
            this.toyName.Size = new System.Drawing.Size(186, 20);
            this.toyName.TabIndex = 0;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(89, 158);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(130, 31);
            this.buyButton.TabIndex = 1;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 201);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(310, 240);
            this.MinimumSize = new System.Drawing.Size(310, 240);
            this.Name = "Form1";
            this.Text = "Toy Shop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toyPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label itemCount;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.NumericUpDown toyPrice;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox toyName;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.RadioButton toyRadio;
        private System.Windows.Forms.RadioButton cuddlyRadio;
    }
}

