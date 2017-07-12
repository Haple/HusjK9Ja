using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Heranca___Veiculo_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carro c = new Carro(textBox1.Text, textBox2.Text);
            richTextBox1.AppendText("X: " + c.X + "Motor: " + c.Motor + "\n");
        }
    }
}
