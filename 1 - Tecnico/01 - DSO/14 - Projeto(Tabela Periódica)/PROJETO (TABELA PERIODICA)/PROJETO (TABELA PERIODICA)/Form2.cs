//using PROJETO__TABELA_PERIODICA_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO__TABELA_PERIODICA_
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();        
        }

        
        public void elementoEscolhido(string simbolo, string nome, string massaAtomica, string familia, string imagem, string nroAtomico)
        {
            lbl_simbolo.Text = simbolo;


            lbl_nome.Text = nome;


            lbl_massa_atomica.Text = massaAtomica;


            lbl_familia.Text = familia;

            pb_imagem.Image = (Image)Properties.Resources.ResourceManager.GetObject(imagem.Substring(0,imagem.Length-4));
            
            lbl_nroAtomico.Text = nroAtomico;

            this.Text = nome;
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
 
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            
            
        }
        int proximoNroAtomico = 1;
        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            if (e.KeyData.Equals(Keys.Right))
            {
                proximoNroAtomico = Int32.Parse(lbl_nroAtomico.Text) + 1;
                Elemento novoElemento = new Elemento("", proximoNroAtomico);
                this.elementoEscolhido(novoElemento.Simbolo,
                novoElemento.Nome,
                novoElemento.MassaAtomica,
                novoElemento.Familia,
                novoElemento.Imagem,
                ""+proximoNroAtomico);
            }
            else if (e.KeyData.Equals(Keys.Left))
            {
                proximoNroAtomico = Int32.Parse(lbl_nroAtomico.Text) - 1;
                Elemento novoElemento = new Elemento("", proximoNroAtomico);
                this.elementoEscolhido(novoElemento.Simbolo,
                novoElemento.Nome,
                novoElemento.MassaAtomica,
                novoElemento.Familia,
                novoElemento.Imagem,
                ""+proximoNroAtomico);
            }
 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            proximoNroAtomico = Int32.Parse(lbl_nroAtomico.Text) + 1;
            Elemento novoElemento = new Elemento("", proximoNroAtomico);
            this.elementoEscolhido(novoElemento.Simbolo,
            novoElemento.Nome,
            novoElemento.MassaAtomica,
            novoElemento.Familia,
            novoElemento.Imagem,
            "" + proximoNroAtomico);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            proximoNroAtomico = Int32.Parse(lbl_nroAtomico.Text) - 1;
            Elemento novoElemento = new Elemento("", proximoNroAtomico);
            this.elementoEscolhido(novoElemento.Simbolo,
            novoElemento.Nome,
            novoElemento.MassaAtomica,
            novoElemento.Familia,
            novoElemento.Imagem,
            "" + proximoNroAtomico);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
