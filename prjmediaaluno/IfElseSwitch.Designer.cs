namespace prjProgramasCursoTecnico
{
    partial class IfElseSwitch
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
            this.btnProcessar = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtSalAtual = new System.Windows.Forms.TextBox();
            this.lblSalAtual = new System.Windows.Forms.Label();
            this.lblIdExamples = new System.Windows.Forms.Label();
            this.cmbId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(192, 123);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(75, 23);
            this.btnProcessar.TabIndex = 1;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 20);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // lblResult
            // 
            this.lblResult.AutoEllipsis = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(82, 160);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(307, 89);
            this.lblResult.TabIndex = 5;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSalAtual
            // 
            this.txtSalAtual.Location = new System.Drawing.Point(266, 97);
            this.txtSalAtual.MaxLength = 8;
            this.txtSalAtual.Name = "txtSalAtual";
            this.txtSalAtual.Size = new System.Drawing.Size(83, 20);
            this.txtSalAtual.TabIndex = 6;
            this.txtSalAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalAtual_KeyPress);
            // 
            // lblSalAtual
            // 
            this.lblSalAtual.AutoSize = true;
            this.lblSalAtual.Location = new System.Drawing.Point(177, 100);
            this.lblSalAtual.Name = "lblSalAtual";
            this.lblSalAtual.Size = new System.Drawing.Size(83, 13);
            this.lblSalAtual.TabIndex = 7;
            this.lblSalAtual.Text = "Salario Atual R$";
            // 
            // lblIdExamples
            // 
            this.lblIdExamples.AutoEllipsis = true;
            this.lblIdExamples.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdExamples.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblIdExamples.Location = new System.Drawing.Point(355, 43);
            this.lblIdExamples.Name = "lblIdExamples";
            this.lblIdExamples.Size = new System.Drawing.Size(139, 142);
            this.lblIdExamples.TabIndex = 8;
            this.lblIdExamples.Text = "ID dos cargos:\r\n\r\n55 - aux de escritório\r\n56 - gerente\r\n57 - secretária\r\n60 - sen" +
    "ador";
            this.lblIdExamples.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbId
            // 
            this.cmbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbId.FormattingEnabled = true;
            this.cmbId.Items.AddRange(new object[] {
            "55",
            "56",
            "57",
            "60"});
            this.cmbId.Location = new System.Drawing.Point(120, 97);
            this.cmbId.Name = "cmbId";
            this.cmbId.Size = new System.Drawing.Size(51, 21);
            this.cmbId.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Calcular Novo Salário";
            // 
            // IfElseSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 280);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbId);
            this.Controls.Add(this.lblIdExamples);
            this.Controls.Add(this.lblSalAtual);
            this.Controls.Add(this.txtSalAtual);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.label1);
            this.Name = "IfElseSwitch";
            this.Text = "IfElseSwitch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtSalAtual;
        private System.Windows.Forms.Label lblSalAtual;
        private System.Windows.Forms.Label lblIdExamples;
        private System.Windows.Forms.ComboBox cmbId;
        private System.Windows.Forms.Label label3;
    }
}