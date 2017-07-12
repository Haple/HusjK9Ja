namespace Projeto_Heranca_
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
            this.txt_nome_fisico = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.btn_pessoa_fisica = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_nome_juridico = new System.Windows.Forms.TextBox();
            this.txt_cnpj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_areadetexto = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nome_fisico
            // 
            this.txt_nome_fisico.Location = new System.Drawing.Point(47, 45);
            this.txt_nome_fisico.Name = "txt_nome_fisico";
            this.txt_nome_fisico.Size = new System.Drawing.Size(149, 20);
            this.txt_nome_fisico.TabIndex = 0;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(47, 88);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(100, 20);
            this.txt_cpf.TabIndex = 1;
            // 
            // btn_pessoa_fisica
            // 
            this.btn_pessoa_fisica.Location = new System.Drawing.Point(233, 65);
            this.btn_pessoa_fisica.Name = "btn_pessoa_fisica";
            this.btn_pessoa_fisica.Size = new System.Drawing.Size(143, 23);
            this.btn_pessoa_fisica.TabIndex = 2;
            this.btn_pessoa_fisica.Text = "Incluir Pessoa Física";
            this.btn_pessoa_fisica.UseVisualStyleBackColor = true;
            this.btn_pessoa_fisica.Click += new System.EventHandler(this.btn_pessoa_fisica_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_pessoa_fisica);
            this.groupBox1.Controls.Add(this.txt_nome_fisico);
            this.groupBox1.Controls.Add(this.txt_cpf);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 128);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PESSOA FÍSICA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txt_nome_juridico);
            this.groupBox2.Controls.Add(this.txt_cnpj);
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 126);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PESSOA JURÍDICA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Incluir Pessoa Jurídica";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_nome_juridico
            // 
            this.txt_nome_juridico.Location = new System.Drawing.Point(47, 45);
            this.txt_nome_juridico.Name = "txt_nome_juridico";
            this.txt_nome_juridico.Size = new System.Drawing.Size(149, 20);
            this.txt_nome_juridico.TabIndex = 0;
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.Location = new System.Drawing.Point(47, 88);
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(100, 20);
            this.txt_cnpj.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CNPJ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome";
            // 
            // txt_areadetexto
            // 
            this.txt_areadetexto.Location = new System.Drawing.Point(-3, 305);
            this.txt_areadetexto.Name = "txt_areadetexto";
            this.txt_areadetexto.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txt_areadetexto.Size = new System.Drawing.Size(427, 123);
            this.txt_areadetexto.TabIndex = 5;
            this.txt_areadetexto.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 427);
            this.Controls.Add(this.txt_areadetexto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Projeto (Herança)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome_fisico;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Button btn_pessoa_fisica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_nome_juridico;
        private System.Windows.Forms.TextBox txt_cnpj;
        private System.Windows.Forms.RichTextBox txt_areadetexto;
    }
}

