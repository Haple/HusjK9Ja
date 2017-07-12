namespace Prova
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.cadastrarSeriadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarTemporadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.consultarSeriadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTemporadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(544, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarSeriadoToolStripMenuItem,
            this.cadastrarTemporadaToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // cadastrarSeriadoToolStripMenuItem
            // 
            this.cadastrarSeriadoToolStripMenuItem.Name = "cadastrarSeriadoToolStripMenuItem";
            this.cadastrarSeriadoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastrarSeriadoToolStripMenuItem.Text = "Cadastrar Seriado";
            this.cadastrarSeriadoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarSeriadoToolStripMenuItem_Click);
            // 
            // cadastrarTemporadaToolStripMenuItem
            // 
            this.cadastrarTemporadaToolStripMenuItem.Name = "cadastrarTemporadaToolStripMenuItem";
            this.cadastrarTemporadaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastrarTemporadaToolStripMenuItem.Text = "Cadastrar Temporada";
            this.cadastrarTemporadaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarTemporadaToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarSeriadoToolStripMenuItem,
            this.consultarTemporadaToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Click += new System.EventHandler(this.toolStripDropDownButton2_Click);
            // 
            // consultarSeriadoToolStripMenuItem
            // 
            this.consultarSeriadoToolStripMenuItem.Name = "consultarSeriadoToolStripMenuItem";
            this.consultarSeriadoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.consultarSeriadoToolStripMenuItem.Text = "Consultar seriado";
            this.consultarSeriadoToolStripMenuItem.Click += new System.EventHandler(this.consultarSeriadoToolStripMenuItem_Click);
            // 
            // consultarTemporadaToolStripMenuItem
            // 
            this.consultarTemporadaToolStripMenuItem.Name = "consultarTemporadaToolStripMenuItem";
            this.consultarTemporadaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.consultarTemporadaToolStripMenuItem.Text = "Consultar temporada";
            this.consultarTemporadaToolStripMenuItem.Click += new System.EventHandler(this.consultarTemporadaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 335);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarSeriadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarTemporadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem consultarSeriadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTemporadaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

