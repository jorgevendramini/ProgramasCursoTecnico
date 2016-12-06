using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjProgramasCursoTecnico
{
    public partial class ExercAgenda13Forum : Form
    {
        public ExercAgenda13Forum()
        {
            InitializeComponent();
        }

        string[] nomes;
        int casavetor;

        private void ExercAgenda13Forum_Load(object sender, EventArgs e)
        {
            nomes = new string[10]; //instancia o vetor ao iniciar o form
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            nomes[casavetor] = txtNome.Text;
            lblListaConvAdd.Text = "Convidado " + (casavetor+1) + " adicionado: " + txtNome.Text;
            txtNome.Text = String.Empty;
            txtNome.Focus();
            casavetor++;

            if (casavetor == 10)
            {
                btnOk.Enabled = false;
                txtNome.Enabled = false;
                btnCriarNovaLista.Visible = true;
            }
        }

        private void btnShowGuests_Click(object sender, EventArgs e)
        {
            for (int cont = 0; cont < casavetor; cont++)
                lstConv.Items.Add(nomes[cont]);
                //add ao listbox o texto da casa selecionada ao vetor
            btnShowGuests.Enabled = false;
            lblListaConvAdd.Text = string.Empty;
            
        }

        private void btnLimpaLstConv_Click(object sender, EventArgs e)
        {
            lstConv.Items.Clear();
            btnShowGuests.Enabled = true;
        }

        private void btnCriarNovaLista_Click(object sender, EventArgs e)
        {
            btnOk.Enabled = true;
            txtNome.Enabled = true;
            btnCriarNovaLista.Visible = false;
            casavetor = 0;
        }
    }
}
