namespace prjProgramasCursoTecnico
{
    partial class AulaAgenda12
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
            this.chkTV = new System.Windows.Forms.CheckBox();
            this.chkDVD = new System.Windows.Forms.CheckBox();
            this.chkTVC = new System.Windows.Forms.CheckBox();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione os objetos que você possui:";
            // 
            // chkTV
            // 
            this.chkTV.AutoSize = true;
            this.chkTV.Location = new System.Drawing.Point(61, 60);
            this.chkTV.Name = "chkTV";
            this.chkTV.Size = new System.Drawing.Size(40, 17);
            this.chkTV.TabIndex = 1;
            this.chkTV.Text = "TV";
            this.chkTV.UseVisualStyleBackColor = true;
            // 
            // chkDVD
            // 
            this.chkDVD.AutoSize = true;
            this.chkDVD.Location = new System.Drawing.Point(61, 84);
            this.chkDVD.Name = "chkDVD";
            this.chkDVD.Size = new System.Drawing.Size(49, 17);
            this.chkDVD.TabIndex = 2;
            this.chkDVD.Text = "DVD";
            this.chkDVD.UseVisualStyleBackColor = true;
            // 
            // chkTVC
            // 
            this.chkTVC.AutoSize = true;
            this.chkTVC.Location = new System.Drawing.Point(61, 108);
            this.chkTVC.Name = "chkTVC";
            this.chkTVC.Size = new System.Drawing.Size(76, 17);
            this.chkTVC.TabIndex = 3;
            this.chkTVC.Text = "TV a cabo";
            this.chkTVC.UseVisualStyleBackColor = true;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessar.Location = new System.Drawing.Point(190, 84);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(75, 23);
            this.btnProcessar.TabIndex = 4;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(319, 60);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(120, 65);
            this.lblResult.TabIndex = 5;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 146);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.chkTVC);
            this.Controls.Add(this.chkDVD);
            this.Controls.Add(this.chkTV);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Aprendendo Checkbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTV;
        private System.Windows.Forms.CheckBox chkDVD;
        private System.Windows.Forms.CheckBox chkTVC;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Label lblResult;
    }
}