namespace prjProgramasCursoTecnico
{
    partial class ExercAgenda13Vetor
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
            this.btnCriarNovaLista = new System.Windows.Forms.Button();
            this.btnLimpaLstNumeros = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnShowNumbers = new System.Windows.Forms.Button();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblListNumerosAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCriarNovaLista
            // 
            this.btnCriarNovaLista.Location = new System.Drawing.Point(65, 107);
            this.btnCriarNovaLista.Name = "btnCriarNovaLista";
            this.btnCriarNovaLista.Size = new System.Drawing.Size(168, 39);
            this.btnCriarNovaLista.TabIndex = 15;
            this.btnCriarNovaLista.Text = "Criar nova lista de números ?";
            this.btnCriarNovaLista.UseVisualStyleBackColor = true;
            this.btnCriarNovaLista.Visible = false;
            this.btnCriarNovaLista.Click += new System.EventHandler(this.btnCriarNovaLista_Click);
            // 
            // btnLimpaLstNumeros
            // 
            this.btnLimpaLstNumeros.Location = new System.Drawing.Point(330, 289);
            this.btnLimpaLstNumeros.Name = "btnLimpaLstNumeros";
            this.btnLimpaLstNumeros.Size = new System.Drawing.Size(239, 39);
            this.btnLimpaLstNumeros.TabIndex = 13;
            this.btnLimpaLstNumeros.Text = "Limpar lista de números";
            this.btnLimpaLstNumeros.UseVisualStyleBackColor = true;
            this.btnLimpaLstNumeros.Click += new System.EventHandler(this.btnLimpaLstNumeros_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(280, 68);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(70, 20);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnShowNumbers
            // 
            this.btnShowNumbers.Location = new System.Drawing.Point(36, 219);
            this.btnShowNumbers.Name = "btnShowNumbers";
            this.btnShowNumbers.Size = new System.Drawing.Size(264, 39);
            this.btnShowNumbers.TabIndex = 11;
            this.btnShowNumbers.Text = "Exibir os números";
            this.btnShowNumbers.UseVisualStyleBackColor = true;
            this.btnShowNumbers.Click += new System.EventHandler(this.btnShowNumbers_Click);
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(330, 107);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(239, 173);
            this.lstNumeros.TabIndex = 10;
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(65, 69);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(168, 20);
            this.txtNumeros.TabIndex = 9;
            this.txtNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Digite doze número inteiros divisíveis por 2 ou 3:";
            // 
            // lblListNumerosAdd
            // 
            this.lblListNumerosAdd.AutoSize = true;
            this.lblListNumerosAdd.Location = new System.Drawing.Point(379, 68);
            this.lblListNumerosAdd.Name = "lblListNumerosAdd";
            this.lblListNumerosAdd.Size = new System.Drawing.Size(0, 13);
            this.lblListNumerosAdd.TabIndex = 16;
            // 
            // ExercAgenda13Vetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 368);
            this.Controls.Add(this.lblListNumerosAdd);
            this.Controls.Add(this.btnCriarNovaLista);
            this.Controls.Add(this.btnLimpaLstNumeros);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnShowNumbers);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.label1);
            this.Name = "ExercAgenda13Vetor";
            this.Text = "ExercAgenda13Vetor";
            this.Load += new System.EventHandler(this.ExercAgenda13Vetor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarNovaLista;
        private System.Windows.Forms.Button btnLimpaLstNumeros;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnShowNumbers;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblListNumerosAdd;
    }
}