namespace prjProgramasCursoTecnico
{
    partial class ExercAgenda13Matriz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMyNumber = new System.Windows.Forms.Label();
            this.lblMynumberDiagTimesTwo = new System.Windows.Forms.Label();
            this.btnRandNum = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMyNumber
            // 
            this.lblMyNumber.AutoSize = true;
            this.lblMyNumber.Location = new System.Drawing.Point(146, 91);
            this.lblMyNumber.Name = "lblMyNumber";
            this.lblMyNumber.Size = new System.Drawing.Size(74, 13);
            this.lblMyNumber.TabIndex = 18;
            this.lblMyNumber.Text = "Seus números";
            // 
            // lblMynumberDiagTimesTwo
            // 
            this.lblMynumberDiagTimesTwo.AutoSize = true;
            this.lblMynumberDiagTimesTwo.Location = new System.Drawing.Point(576, 91);
            this.lblMynumberDiagTimesTwo.Name = "lblMynumberDiagTimesTwo";
            this.lblMynumberDiagTimesTwo.Size = new System.Drawing.Size(189, 13);
            this.lblMynumberDiagTimesTwo.TabIndex = 19;
            this.lblMynumberDiagTimesTwo.Text = "Seus números com a diagonal vezes 2";
            // 
            // btnRandNum
            // 
            this.btnRandNum.Location = new System.Drawing.Point(355, 303);
            this.btnRandNum.Name = "btnRandNum";
            this.btnRandNum.Size = new System.Drawing.Size(167, 35);
            this.btnRandNum.TabIndex = 22;
            this.btnRandNum.Text = "Dê-me novos números !!";
            this.btnRandNum.UseVisualStyleBackColor = true;
            this.btnRandNum.Click += new System.EventHandler(this.btnRandNum_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(327, 121);
            this.dataGridView1.TabIndex = 23;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(513, 127);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(316, 121);
            this.dataGridView2.TabIndex = 24;
            // 
            // ExercAgenda13Matriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 396);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRandNum);
            this.Controls.Add(this.lblMynumberDiagTimesTwo);
            this.Controls.Add(this.lblMyNumber);
            this.Name = "ExercAgenda13Matriz";
            this.Text = "Matriz";
            this.Load += new System.EventHandler(this.ExercAgenda13Matriz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMyNumber;
        private System.Windows.Forms.Label lblMynumberDiagTimesTwo;
        private System.Windows.Forms.Button btnRandNum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}