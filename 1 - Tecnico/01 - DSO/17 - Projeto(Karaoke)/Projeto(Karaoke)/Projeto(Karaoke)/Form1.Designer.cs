namespace Projeto_Karaoke_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerClipe = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbl_letra = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lbl_tempoDecorrido = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.playerClipe)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerClipe
            // 
            this.playerClipe.Enabled = true;
            this.playerClipe.Location = new System.Drawing.Point(0, 28);
            this.playerClipe.Name = "playerClipe";
            this.playerClipe.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("playerClipe.OcxState")));
            this.playerClipe.Size = new System.Drawing.Size(636, 323);
            this.playerClipe.TabIndex = 0;
            // 
            // lbl_letra
            // 
            this.lbl_letra.BackColor = System.Drawing.Color.Black;
            this.lbl_letra.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_letra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_letra.Location = new System.Drawing.Point(12, 317);
            this.lbl_letra.Name = "lbl_letra";
            this.lbl_letra.Size = new System.Drawing.Size(611, 24);
            this.lbl_letra.TabIndex = 2;
            this.lbl_letra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.lbl_tempoDecorrido});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(635, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_tempoDecorrido
            // 
            this.lbl_tempoDecorrido.ActiveLinkColor = System.Drawing.Color.Black;
            this.lbl_tempoDecorrido.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbl_tempoDecorrido.Enabled = false;
            this.lbl_tempoDecorrido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_tempoDecorrido.Name = "lbl_tempoDecorrido";
            this.lbl_tempoDecorrido.Size = new System.Drawing.Size(44, 22);
            this.lbl_tempoDecorrido.Text = "00:00";
            this.lbl_tempoDecorrido.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(635, 351);
            this.Controls.Add(this.lbl_letra);
            this.Controls.Add(this.playerClipe);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karaokê";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerClipe)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer playerClipe;
        private System.Windows.Forms.Label lbl_letra;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lbl_tempoDecorrido;
    }
}

