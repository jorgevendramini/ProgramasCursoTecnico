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
    public partial class AulaAgenda12 : Form
    {
        public AulaAgenda12()
        {
            InitializeComponent();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            string resultado = "";

            if (chkTV.Checked)
               resultado += " TV ";
            if (chkDVD.Checked) 
               resultado += " DVD ";
            if (chkTVC.Checked)
               resultado += " TV A CABO ";

            lblResult.Text = resultado;
            
        }
    }
}
