using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Karaoke_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] legenda;

        //Iniciar o vídeo
        private void carregarClipe()
        {
            playerClipe.URL = @"E:\1 - Tecnico\01 - DSO\17 - Projeto(Karaoke)\Projeto(Karaoke)\Projeto(Karaoke)\File\TardeVazia.mp4";
            
            playerClipe.Ctlcontrols.play();

            playerClipe.settings.mute = true;
        }
        //Iniciar o áudio
        private void carregarAudio()
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = @"E:\1 - Tecnico\01 - DSO\17 - Projeto(Karaoke)\Projeto(Karaoke)\Projeto(Karaoke)\File\TardeVazia.mp3";
            
            wplayer.controls.play();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            carregarLegenda();

            carregarClipe();

            carregarAudio();
        }

        private void carregarLegenda()
        {
            legenda = File.ReadAllLines(@"E:\1 - Tecnico\01 - DSO\17 - Projeto(Karaoke)\Projeto(Karaoke)\Projeto(Karaoke)\File\TardeVazia.txt", Encoding.Default);

            timer.Enabled = true;
        }

        private void buscarLegendaDoTempo(string tempoAtual)
        {
            foreach (var linha in legenda)
            {
                string fraseAtual = linha.ToString();

                string fraseTempo;
                fraseTempo = fraseAtual.Substring(0, 5);

                if (fraseTempo == tempoAtual)
                {
                    string fraseMusica = fraseAtual.Substring(5, fraseAtual.Length - 5);

                    lbl_letra.Text = fraseMusica;
                    break;
                }
            }
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            string tempoDecorrido = playerClipe.Ctlcontrols.currentPositionString;

            //lbl_tempoDecorrido.Visible = true;

            lbl_tempoDecorrido.Text = tempoDecorrido;

            buscarLegendaDoTempo(tempoDecorrido);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            carregarLegenda();

            carregarClipe();

            carregarAudio();
        }
    }
}
