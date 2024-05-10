using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__002
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

        private void button1_Click(object sender, EventArgs e)
        {
            int idadePedro = 18;
            int idadeMarcela = 16;
            int idadeLuciana = 49;
            int media = (idadePedro + idadeMarcela + idadeLuciana) / 3;
            string texto = media.ToString();
            MessageBox.Show("A media das idade é: " + texto);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
