namespace prjProgramasCursoTecnico
{
    partial class FolhaPagamentoForm
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
            this.btnSalLiq = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalBase = new System.Windows.Forms.TextBox();
            this.txtGratProd = new System.Windows.Forms.TextBox();
            this.lblSalLiq = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe seu ID";
            // 
            // btnSalLiq
            // 
            this.btnSalLiq.Location = new System.Drawing.Point(232, 123);
            this.btnSalLiq.Name = "btnSalLiq";
            this.btnSalLiq.Size = new System.Drawing.Size(105, 36);
            this.btnSalLiq.TabIndex = 1;
            this.btnSalLiq.Text = "Calcular meu salário líquido";
            this.btnSalLiq.UseVisualStyleBackColor = true;
            this.btnSalLiq.Click += new System.EventHandler(this.btnSalLiq_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(60, 69);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informe seu Salário Base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Informe sua Gratif de Produtividade";
            // 
            // txtSalBase
            // 
            this.txtSalBase.Location = new System.Drawing.Point(60, 133);
            this.txtSalBase.Name = "txtSalBase";
            this.txtSalBase.Size = new System.Drawing.Size(100, 20);
            this.txtSalBase.TabIndex = 5;
            // 
            // txtGratProd
            // 
            this.txtGratProd.Location = new System.Drawing.Point(60, 207);
            this.txtGratProd.Name = "txtGratProd";
            this.txtGratProd.Size = new System.Drawing.Size(100, 20);
            this.txtGratProd.TabIndex = 6;
            // 
            // lblSalLiq
            // 
            this.lblSalLiq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalLiq.Location = new System.Drawing.Point(353, 96);
            this.lblSalLiq.Name = "lblSalLiq";
            this.lblSalLiq.Size = new System.Drawing.Size(256, 63);
            this.lblSalLiq.TabIndex = 7;
            this.lblSalLiq.Text = "ID:\r\nSalário bruto:\r\nSalário líquido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Calcular meu salário líquido";
            // 
            // FolhaPagamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 243);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSalLiq);
            this.Controls.Add(this.txtGratProd);
            this.Controls.Add(this.txtSalBase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnSalLiq);
            this.Controls.Add(this.label1);
            this.Name = "FolhaPagamentoForm";
            this.Text = "FolhaPagamentoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalLiq;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalBase;
        private System.Windows.Forms.TextBox txtGratProd;
        private System.Windows.Forms.Label lblSalLiq;
        private System.Windows.Forms.Label label4;
    }
}