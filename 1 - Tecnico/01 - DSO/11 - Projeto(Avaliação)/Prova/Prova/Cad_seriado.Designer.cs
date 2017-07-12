namespace Prova
{
    partial class Cad_seriado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cad_seriado));
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tema = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_temporada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_seriado = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.cadastrarTemporadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.consultarSeriadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTemporadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(114, 145);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 13;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tema";
            // 
            // txt_tema
            // 
            this.txt_tema.Location = new System.Drawing.Point(82, 88);
            this.txt_tema.Name = "txt_tema";
            this.txt_tema.Size = new System.Drawing.Size(148, 20);
            this.txt_tema.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Temporada";
            // 
            // txt_temporada
            // 
            this.txt_temporada.Location = new System.Drawing.Point(94, 62);
            this.txt_temporada.Name = "txt_temporada";
            this.txt_temporada.Size = new System.Drawing.Size(136, 20);
            this.txt_temporada.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seriado";
            // 
            // txt_seriado
            // 
            this.txt_seriado.Location = new System.Drawing.Point(82, 36);
            this.txt_seriado.Name = "txt_seriado";
            this.txt_seriado.Size = new System.Drawing.Size(148, 20);
            this.txt_seriado.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarTemporadaToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
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
            // Cad_seriado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 203);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_temporada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_seriado);
            this.Name = "Cad_seriado";
            this.Text = "Cadastrar seriado";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_temporada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_seriado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarTemporadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem consultarSeriadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTemporadaToolStripMenuItem;
    }
}