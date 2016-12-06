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
    public partial class ExercAgenda13Vetor : Form
    {
        public ExercAgenda13Vetor()
        {
            InitializeComponent();
        }

        string[] numeros;
        int casavetor;

        private void btnLimpaLstNumeros_Click(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();
            btnShowNumbers.Enabled = true;
        }

        private void btnShowNumbers_Click(object sender, EventArgs e)
        {
            for (int cont = 0; cont < casavetor; cont++)
                lstNumeros.Items.Add(numeros[cont]);
            //add ao listbox o texto da casa selecionada ao vetor
            btnShowNumbers.Enabled = false;
            lblListNumerosAdd.Text = string.Empty;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtNumeros.Text);
            if (number % 2 == 0 || number % 3 == 0)
            {
                numeros[casavetor] = txtNumeros.Text;
                lblListNumerosAdd.Text = "Numero " + (casavetor + 1) + " adicionado: " + txtNumeros.Text;
                txtNumeros.Text = String.Empty;
                txtNumeros.Focus();
                casavetor++;
            }
            else
            {
                lblListNumerosAdd.Text = "Número inválido: " + txtNumeros.Text;
                txtNumeros.Text = String.Empty;
                txtNumeros.Focus();
            }
            //ficou melhor usando um if/else que um try/catch/finally 

            if (casavetor == 12)
            {
                btnOk.Enabled = false;
                txtNumeros.Enabled = false;
                btnCriarNovaLista.Visible = true;
            }
        }

        private void btnCriarNovaLista_Click(object sender, EventArgs e)
        {
            btnOk.Enabled = true;
            txtNumeros.Enabled = true;
            btnCriarNovaLista.Visible = false;
            casavetor = 0;
        }

        private void ExercAgenda13Vetor_Load(object sender, EventArgs e)
        {
            numeros = new string[12];
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }
    }
}
