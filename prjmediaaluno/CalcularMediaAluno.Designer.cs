namespace prjProgramasCursoTecnico
{
    partial class CalcularMediaAluno
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
            this.btnmedia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblmedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnmedia
            // 
            this.btnmedia.Location = new System.Drawing.Point(41, 104);
            this.btnmedia.Name = "btnmedia";
            this.btnmedia.Size = new System.Drawing.Size(200, 23);
            this.btnmedia.TabIndex = 4;
            this.btnmedia.Text = "Calcular Média";
            this.btnmedia.UseVisualStyleBackColor = true;
            this.btnmedia.Click += new System.EventHandler(this.btnmedia_Click);
            //this.btnmedia.Validating += new System.ComponentModel.CancelEventHandler(this.btnmedia_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nota 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nome do aluno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Média do aluno";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(42, 24);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(187, 20);
            this.txtnome.TabIndex = 0;
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(42, 69);
            this.txtn1.MaxLength = 4;
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(33, 20);
            this.txtn1.TabIndex = 1;
            this.txtn1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtn1_KeyPress);
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(117, 69);
            this.txtn2.MaxLength = 4;
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(33, 20);
            this.txtn2.TabIndex = 2;
            this.txtn2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtn1_KeyPress);
            // 
            // txtn3
            // 
            this.txtn3.Location = new System.Drawing.Point(196, 69);
            this.txtn3.MaxLength = 4;
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(33, 20);
            this.txtn3.TabIndex = 3;
            this.txtn3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtn1_KeyPress);
            // 
            // lblnome
            // 
            this.lblnome.BackColor = System.Drawing.Color.Red;
            this.lblnome.Location = new System.Drawing.Point(115, 154);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(74, 13);
            this.lblnome.TabIndex = 11;
            // 
            // lblmedia
            // 
            this.lblmedia.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblmedia.Location = new System.Drawing.Point(115, 182);
            this.lblmedia.Name = "lblmedia";
            this.lblmedia.Size = new System.Drawing.Size(74, 13);
            this.lblmedia.TabIndex = 12;
            // 
            // CalcularMediaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 223);
            this.Controls.Add(this.lblmedia);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtn3);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmedia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CalcularMediaAluno";
            this.Text = "Calcular média do aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtn3;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblmedia;
    }
}

