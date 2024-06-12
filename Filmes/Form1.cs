using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Filmes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
         if(cmbFilmes.SelectedIndex == -1) { MessageBox.Show("Selecione um filme "); }
            
            else
            { pnValidar.Visible = true; }
        }

        private void btnAsistirAgora_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDataNascimento.Text)) { MessageBox.Show("Informe Data nascimento"); }

            if (string.IsNullOrWhiteSpace(txtNome.Text)) { MessageBox.Show("Informe Seu nome"); }

            if (cmbFilmes.SelectedItem != null) {  string valorSelecionado = cmbFilmes.SelectedItem.ToString(); }


        }
    }
}
