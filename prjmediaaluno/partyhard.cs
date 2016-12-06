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
    public partial class partyhard : Form
    {

        public partyhard()
        {
            InitializeComponent();
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //comando para alterar as cores usando timer
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            Color randomColor = Color.FromKnownColor(randomColorName);
            lbl3.BackColor = randomColor;
            lbl4.BackColor = randomColor;
            lbl5.BackColor = randomColor;
            lbl6.BackColor = randomColor;
            lbl7.BackColor = randomColor;
            lbl8.BackColor = randomColor;
            lbl9.BackColor = randomColor;
            lbl10.BackColor = randomColor;
            lbl11.BackColor = randomColor;
            lbl12.BackColor = randomColor;
            lbl13.BackColor = randomColor;
            lbl14.BackColor = randomColor;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
