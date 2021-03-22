
namespace MyMusic
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.musicalInstrumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringInstrumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem,
            this.musicalInstrumentToolStripMenuItem,
            this.stringInstrumentToolStripMenuItem,
            this.guitarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // musicalInstrumentToolStripMenuItem
            // 
            this.musicalInstrumentToolStripMenuItem.Name = "musicalInstrumentToolStripMenuItem";
            this.musicalInstrumentToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.musicalInstrumentToolStripMenuItem.Text = "Musical Instrument";
            // 
            // stringInstrumentToolStripMenuItem
            // 
            this.stringInstrumentToolStripMenuItem.Name = "stringInstrumentToolStripMenuItem";
            this.stringInstrumentToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.stringInstrumentToolStripMenuItem.Text = "String Instrument";
            // 
            // guitarToolStripMenuItem
            // 
            this.guitarToolStripMenuItem.Name = "guitarToolStripMenuItem";
            this.guitarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.guitarToolStripMenuItem.Text = "Guitar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicalInstrumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringInstrumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guitarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

