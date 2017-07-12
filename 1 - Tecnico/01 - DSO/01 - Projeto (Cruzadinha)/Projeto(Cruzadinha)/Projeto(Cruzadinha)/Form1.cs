using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Cruzadinha_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void palavra1() {

        }

        private void verificar(object sender, KeyEventArgs e)
        {
            //palavra1
            string palavraCerta1 = "TUCANO";
            string palavraUsuario1 = p1_l1.Text + cruzP1P3.Text + p1_l3.Text + p1_l4.Text + p1_l5.Text + cruzP1P4.Text;
            if (palavraCerta1 == palavraUsuario1)
            {
                p1_l1.BackColor = Color.Yellow;
                cruzP1P3.BackColor = Color.Yellow;
                p1_l3.BackColor = Color.Yellow;
                p1_l4.BackColor = Color.Yellow;
                p1_l5.BackColor = Color.Yellow;
                cruzP1P4.BackColor = Color.Yellow;
            }
            else
            {
                p1_l1.BackColor = Color.White;
                cruzP1P3.BackColor = Color.White;
                p1_l3.BackColor = Color.White;
                p1_l4.BackColor = Color.White;
                p1_l5.BackColor = Color.White;
                cruzP1P4.BackColor = Color.White;
            }

            //palavra2
            string palavraCerta2 = "VASO";
            string palavraUsuario2 = "";
            if (palavraCerta2 == palavraUsuario2)
            {
                p1_l1.BackColor = Color.Yellow;
                cruzP1P3.BackColor = Color.Yellow;
                p1_l3.BackColor = Color.Yellow;
                p1_l4.BackColor = Color.Yellow;
                p1_l5.BackColor = Color.Yellow;
                cruzP1P4.BackColor = Color.Yellow;
            }
            else
            {
                p1_l1.BackColor = Color.White;
                cruzP1P3.BackColor = Color.White;
                p1_l3.BackColor = Color.White;
                p1_l4.BackColor = Color.White;
                p1_l5.BackColor = Color.White;
                cruzP1P4.BackColor = Color.White;
            }
        }
    }
}
