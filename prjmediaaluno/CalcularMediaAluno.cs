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

    public partial class CalcularMediaAluno : Form
    {
        //O usuário só pode digitar números, virgula e backspace em notas
        public void nolettersallowed(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8
                && e.KeyChar != 44)
            {
                e.Handled = true;
            }

        }

        public CalcularMediaAluno()
        {
            InitializeComponent();
        }

        private void btnmedia_Click(object sender, EventArgs e)
        {
            //input validation
            try
            {
                lblnome.Text = txtnome.Text;
                double nota1 = double.Parse(txtn1.Text);
                double nota2 = double.Parse(txtn2.Text);
                double nota3 = double.Parse(txtn3.Text);

                //calculo media
                lblmedia.Text = ((nota1 + nota2 + nota3) / 3).ToString("0.0");
            }
            catch
            {
                if (txtn1.Text == "")
                {
                    MessageBox.Show("Digite a nota 1!");
                }
                else if (txtn2.Text == "")
                {
                    MessageBox.Show("Digite a nota 2!");
                }
                else if (txtn3.Text == "")
                {
                    MessageBox.Show("Digite a nota 3!");
                }
            }


            //easter egg
            if (txtn1.Text == "6" && txtn2.Text =="6" && txtn3.Text == "6") {
                MessageBox.Show("NON EXCISTE !!!");
            }
            else if (txtn1.Text == "4" && txtn2.Text == "2" && txtn3.Text == "0") {
                MessageBox.Show("Snoop dogg mode ACTIVATED!");
            }
        }

        private void btnangry_Click(object sender, EventArgs e)
        {
            //abre novo form
            (new partyhard()).Show();
        }

        private void txtn1_KeyPress(object sender, KeyPressEventArgs e)
        {
            nolettersallowed(e);
        }
   
    }
}
