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

        string[] mapa;
        int pontos = 0;
        SoundPlayer snd;


        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Preparado?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                carregarMapa();
                tocarMusica();

            }else
            {
                Application.Exit();
            }

        }

        private void carregarMapa()
        {
           // MessageBox.Show("E o caminho é:" + Properties.Resources.mapa1);
           mapa = File.ReadAllLines("D:\\1 - Tecnico\\01 - DSO\\19 - Projeto(Music Game)\\Projeto(Piano)\\Projeto(Piano)\\maps\\mapa1.txt", Encoding.Default);
           // mapa = Properties.Resources.mapa1.Split(new [] { Environment.NewLine}, StringSplitOptions.None);

        }




        private void tocarMusica() {


            //SoundPlayer snd = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("dearGod"));
            //snd = new SoundPlayer((Stream)Properties.Resources.dearGod);
            //snd.Play();


            playerMusica.URL = @"D:\1 - Tecnico\01 - DSO\19 - Projeto(Music Game)\Projeto(Piano)\Projeto(Piano)\sounds\dearGod.mp3";
            //playerMusica.URL = System.AppDomain.CurrentDomain.BaseDirectory + "\\sounds\\dearGod.wav";

            playerMusica.Ctlcontrols.play();

            timer1.Enabled = true;

        }


        private void buscarMapaDoTempo(string tempoAtual)
        {

            Control control = this.Controls["panel1"];

            foreach (var linha in mapa)
            {
                string linhaAtual = linha.ToString();

                string tempoMapa = linhaAtual.Substring(0, 5);

                string nomePainel = linhaAtual.Substring(5, linhaAtual.Length - 5).Trim();

                control = this.Controls[nomePainel];

                if (tempoMapa == tempoAtual && nomePainel == control.Name.ToString())
                {

                    control.Enabled = true;
                    control.BackColor = Color.LightSalmon;
                    break;

                }
                else
                {
                    control.Enabled = false;
                    control.BackColor = Color.Transparent;
                    
                }
                
            }
        }




        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            string tempoDecorrido = playerMusica.Ctlcontrols.currentPositionString;
            //string tempoDecorrido = snd.LoadTimeout.ToString();

            buscarMapaDoTempo(tempoDecorrido);

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void panel33_MouseHover(object sender, EventArgs e)
        {
        }

        private void panel33_Click(object sender, EventArgs e)
        {
            if (((Panel)sender).Enabled == true)
            {

                ((Panel)sender).Enabled = false;
                ((Panel)sender).BackColor = Color.Red;

                pontos++;
                txtPontos.Text = "♪♫ " + pontos;

            }
            else if (((Panel)sender).Enabled == false)
            {
                ((Panel)sender).BackColor = Color.Transparent;
            }
        }

        private void panel33_MouseDown(object sender, MouseEventArgs e)
        {
 


        }

        private void panel33_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void panel33_MouseLeave(object sender, EventArgs e)
        {
           
        }
    }
}
