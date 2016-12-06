namespace prjProgramasCursoTecnico
{
    partial class ExercAgenda13Forum
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lstConv = new System.Windows.Forms.ListBox();
            this.btnShowGuests = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnLimpaLstConv = new System.Windows.Forms.Button();
            this.lblListaConvAdd = new System.Windows.Forms.Label();
            this.btnCriarNovaLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o convidado";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(88, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(168, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lstConv
            // 
            this.lstConv.FormattingEnabled = true;
            this.lstConv.Location = new System.Drawing.Point(375, 104);
            this.lstConv.Name = "lstConv";
            this.lstConv.Size = new System.Drawing.Size(239, 173);
            this.lstConv.TabIndex = 2;
            // 
            // btnShowGuests
            // 
            this.btnShowGuests.Location = new System.Drawing.Point(88, 182);
            this.btnShowGuests.Name = "btnShowGuests";
            this.btnShowGuests.Size = new System.Drawing.Size(264, 39);
            this.btnShowGuests.TabIndex = 3;
            this.btnShowGuests.Text = "Exibir os convidados";
            this.btnShowGuests.UseVisualStyleBackColor = true;
            this.btnShowGuests.Click += new System.EventHandler(this.btnShowGuests_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(282, 56);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(70, 20);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnLimpaLstConv
            // 
            this.btnLimpaLstConv.Location = new System.Drawing.Point(375, 299);
            this.btnLimpaLstConv.Name = "btnLimpaLstConv";
            this.btnLimpaLstConv.Size = new System.Drawing.Size(239, 39);
            this.btnLimpaLstConv.TabIndex = 5;
            this.btnLimpaLstConv.Text = "Limpar lista de convidados";
            this.btnLimpaLstConv.UseVisualStyleBackColor = true;
            this.btnLimpaLstConv.Click += new System.EventHandler(this.btnLimpaLstConv_Click);
            // 
            // lblListaConvAdd
            // 
            this.lblListaConvAdd.AutoSize = true;
            this.lblListaConvAdd.Location = new System.Drawing.Point(372, 56);
            this.lblListaConvAdd.Name = "lblListaConvAdd";
            this.lblListaConvAdd.Size = new System.Drawing.Size(0, 13);
            this.lblListaConvAdd.TabIndex = 6;
            // 
            // btnCriarNovaLista
            // 
            this.btnCriarNovaLista.Location = new System.Drawing.Point(88, 95);
            this.btnCriarNovaLista.Name = "btnCriarNovaLista";
            this.btnCriarNovaLista.Size = new System.Drawing.Size(168, 39);
            this.btnCriarNovaLista.TabIndex = 7;
            this.btnCriarNovaLista.Text = "Criar nova lista de convidados ?";
            this.btnCriarNovaLista.UseVisualStyleBackColor = true;
            this.btnCriarNovaLista.Visible = false;
            this.btnCriarNovaLista.Click += new System.EventHandler(this.btnCriarNovaLista_Click);
            // 
            // ExercAgenda13Forum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 350);
            this.Controls.Add(this.btnCriarNovaLista);
            this.Controls.Add(this.lblListaConvAdd);
            this.Controls.Add(this.btnLimpaLstConv);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnShowGuests);
            this.Controls.Add(this.lstConv);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "ExercAgenda13Forum";
            this.Text = "ExercAgenda13Forum";
            this.Load += new System.EventHandler(this.ExercAgenda13Forum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ListBox lstConv;
        private System.Windows.Forms.Button btnShowGuests;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnLimpaLstConv;
        private System.Windows.Forms.Label lblListaConvAdd;
        private System.Windows.Forms.Button btnCriarNovaLista;
    }
}