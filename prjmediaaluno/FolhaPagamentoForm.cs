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
    public partial class FolhaPagamentoForm : Form
    {
        FolhaPagamento payday = new FolhaPagamento();

        public FolhaPagamentoForm()
        {
            InitializeComponent();
        }

        private void btnSalLiq_Click(object sender, EventArgs e)
        {
            payday.setMatricula(txtId.Text);
            payday.setGratificacaoPod(double.Parse(txtGratProd.Text));
            payday.setSalarioBase(double.Parse(txtSalBase.Text));
            
            lblSalLiq.Text = "ID: " + payday.getMatricula() +  "\nSalário bruto: " + payday.fornecaSalarioBruto().ToString("0.00") + 
                "\nSalário líquido: " + payday.fornecaSalarioLiquido().ToString("0.00");
        }
    }
}
