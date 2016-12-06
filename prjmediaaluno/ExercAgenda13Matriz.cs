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
    public partial class ExercAgenda13Matriz : Form
    {
        public ExercAgenda13Matriz()
        {
            InitializeComponent();
        }


        private void ExercAgenda13Matriz_Load(object sender, EventArgs e)
        {

        }

        private void btnRandNum_Click(object sender, EventArgs e)
        {
            //limpa os datagrids
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();

            //da um numero random para a matriz
            Random rnd = new Random();
            int[,] myNumbers = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    myNumbers[i, j] = rnd.Next(101);
                }
            }


            var rowCount = myNumbers.GetLength(0);
            var rowLength = myNumbers.GetLength(1);

            //cria as celulas no datagrid e add os valores da matriz
            for (int rowIndex = 0; rowIndex < rowCount; ++rowIndex)
            {
                var row = new DataGridViewRow();

                for (int columnIndex = 0; columnIndex < rowLength; ++columnIndex)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell()
                    {
                        Value = myNumbers[rowIndex, columnIndex]
                    });
                }
                dataGridView1.ColumnCount = 3;
                dataGridView1.Rows.Add(row);
            }


            //multiplica os valores que o enunciado pede por 2
            myNumbers[0, 0] *= 2;
            myNumbers[1, 1] *= 2;
            myNumbers[2, 2] *= 2;

            //joga no outro datagrid com os valores novos
            for (int rowIndex = 0; rowIndex < rowCount; ++rowIndex)
            {
                var row = new DataGridViewRow();

                for (int columnIndex = 0; columnIndex < rowLength; ++columnIndex)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell()
                    {
                        Value = myNumbers[rowIndex, columnIndex]
                    });
                }
                dataGridView2.ColumnCount = 3;
                dataGridView2.Rows.Add(row);

            }

        }
    }
}




