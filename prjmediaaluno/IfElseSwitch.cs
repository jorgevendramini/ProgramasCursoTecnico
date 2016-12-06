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
    public partial class IfElseSwitch : Form
    {
        public IfElseSwitch()
        {
            InitializeComponent();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal novoSal = decimal.Parse(txtSalAtual.Text);
                if (cmbId.SelectedItem.Equals("60"))
                {
                    novoSal = novoSal + (novoSal * 0.60m);  //Bem vindo ao brasil-sil-sil
                }
                else if (cmbId.SelectedItem.Equals("57") || cmbId.SelectedItem.Equals("56"))
                {
                    novoSal = novoSal + (novoSal * 0.12m);
                }
                else if (cmbId.SelectedItem.Equals("55"))
                {
                    novoSal = novoSal + 12.00m; //Brasil brasileiro
                }
                else if (novoSal < 0.00m)
                {
                    MessageBox.Show("Valor Inválido");
                }

                lblResult.Text = "Nome do Funcionário: " + txtName.Text + "\n" + "Id do Funcionário: " + cmbId.Text
                + "\n" + "Salário Atual: R$" + txtSalAtual.Text + "\n\n" + "Novo Salário: R$" + novoSal.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Digite todos os dados necessários");
            }

            
        }

        private void txtSalAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            CalcularMediaAluno onlyNumbers = new CalcularMediaAluno();
            onlyNumbers.nolettersallowed(e);
        }
    }
}
