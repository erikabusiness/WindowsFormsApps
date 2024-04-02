using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClickAction(object sender, EventArgs e)
        {
            string Frase = string.Format("Olá {0}", txtNome.Text); //pego o nome do usuario e coloco dentro do nome
            MessageBox.Show(Frase, "Bem vindo!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); //tem 21 sobrecargas, ou seja, 21 formas de usar-lo
        }
    }
}
