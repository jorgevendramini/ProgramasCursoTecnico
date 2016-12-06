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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }
        
        private void btnCalcSalFunc_Click(object sender, EventArgs e)
        {
            new CalcSalFunc().Show();
        }

        private void btnCalcMediaAluno_Click(object sender, EventArgs e)
        {
            new CalcularMediaAluno().Show();
        }

        private void btnAulaAgenda12_Click(object sender, EventArgs e)
        {
            new AulaAgenda12().Show();
        }

        private void btnPartyHard_Click(object sender, EventArgs e)
        {
            new partyhard().Show();
        }

        private void LoopListBox_Click(object sender, EventArgs e)
        {
            new loopListBox().Show();
        }

        private void btnLoops_Click(object sender, EventArgs e)
        {
            new Loops().Show();
        }

        private void btnIfElseSwitch_Click(object sender, EventArgs e)
        {
            new IfElseSwitch().Show();
        }

        private void btnAg13ForumExerc_Click(object sender, EventArgs e)
        {
            new ExercAgenda13Forum().Show();
        }

        private void btnAg13Exerc1Vetor_Click(object sender, EventArgs e)
        {
            new ExercAgenda13Vetor().Show();
        }

        private void btnAg13Exerc2Matriz_Click(object sender, EventArgs e)
        {
            new ExercAgenda13Matriz().Show();
        }

        private void btnAg14_Click(object sender, EventArgs e)
        {
            new FolhaPagamentoForm().Show();
        }
    }
}
