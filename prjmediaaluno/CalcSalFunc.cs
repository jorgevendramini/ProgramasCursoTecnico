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
    public partial class CalcSalFunc : Form
    {
        public CalcSalFunc()
        {
            InitializeComponent();
        }

        private void txtdireitos_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbcargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Adiciona texto ao textbox de acordo com o combobox
            if (cmbcargo.SelectedItem.Equals("Diretoria"))
            {
                txtdireitos.Text = "1 Previdência Privada, Auxílio Educação, Vale Alimentação e Seguro Saúde.";
            }
            else if (cmbcargo.SelectedItem.Equals("Gerencia"))
            {
                txtdireitos.Text = "2 Auxílio Educação, Vale Alimentação e Seguro Saúde.";
            }
            else if (cmbcargo.SelectedItem.Equals("Servicos Gerais"))
            {
                txtdireitos.Text = "3 Vale Alimentação e Seguro Saúde.";
            }
        }

        private void btnCalcSalario_Click(object sender, EventArgs e)
        {
            
            //calculo salario liquido
            try
            {
                decimal salbruto = decimal.Parse(txtSalBruto.Text);
                if (salbruto > 2500.00m)
                {
                    salbruto = salbruto - (salbruto * 0.12m);
                }
                else if (salbruto > 1200.00m && salbruto < 2500.01m)
                {
                    salbruto = salbruto - (salbruto * 0.08m);
                }
                else if (salbruto < 0.00m)
                {
                    MessageBox.Show("Valor Inválido");
                }

                txtSalLiquido.Text = salbruto.ToString("0.00");

                if (salbruto < 1200.01m && salbruto > 0.00m) {
                    txtSalLiquido.Text = salbruto.ToString("0.00") + " - ISENTO DE IS";
                }

            }
            catch {
                MessageBox.Show("Digite um valor para salário bruto");    
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSalBruto.Text = String.Empty;
            txtSalLiquido.Text = String.Empty;
            cmbcargo.Text = String.Empty;
            txtdireitos.Text = String.Empty;
            txtNomeFunc.Text = String.Empty;
            txtNomeFunc.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja sair ?", "Fechar aplicativo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("Programa fechado com sucesso!","Fechando programa");
                this.Close();
            }
            else {
                MessageBox.Show("Seu programa não será fechado!","Lembre-se de salvar seu programa");
            }
        }

        private void txtSalBruto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSalBruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            CalcularMediaAluno onlynumbers = new CalcularMediaAluno();
            onlynumbers.nolettersallowed(e);
        }
    }
}
