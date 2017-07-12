using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Piano_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void Tocar_Nota(string nota) {

 
            SoundPlayer snd = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("_"+nota));
            snd.Play();
            
            panel1.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("i" + nota);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Q: Tocar_Nota("1"); break;
                case Keys.W: Tocar_Nota("2"); break;
                case Keys.E: Tocar_Nota("3"); break;
                case Keys.R: Tocar_Nota("4"); break;
                case Keys.T: Tocar_Nota("5"); break;
                case Keys.Y: Tocar_Nota("6"); break;
                case Keys.U: Tocar_Nota("7"); break;
                case Keys.I: Tocar_Nota("8"); break;
                case Keys.O: Tocar_Nota("9"); break;
                case Keys.P: Tocar_Nota("10"); break;
                case Keys.H: Tocar_Nota("11"); break;
                case Keys.J: Tocar_Nota("12"); break;
                case Keys.K: Tocar_Nota("13"); break;
                case Keys.L: Tocar_Nota("14"); break;

                default:
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            panel1.BackgroundImage = Properties.Resources.Piano_Principal;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
