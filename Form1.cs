using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ConexaoBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro(txbNome.Text, txbTel.Text, txbEmail.Text);
            MessageBox.Show(cad.mensagem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
