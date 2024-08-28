namespace Lab_2
{
    partial class Form2
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
            this.labelSalarioNetoMes = new System.Windows.Forms.Label();
            this.labelSeguroSocial = new System.Windows.Forms.Label();
            this.labeIsrMes = new System.Windows.Forms.Label();
            this.labelSeguroEducativo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSalarioNetoMes
            // 
            this.labelSalarioNetoMes.AutoSize = true;
            this.labelSalarioNetoMes.Location = new System.Drawing.Point(86, 92);
            this.labelSalarioNetoMes.Name = "labelSalarioNetoMes";
            this.labelSalarioNetoMes.Size = new System.Drawing.Size(105, 13);
            this.labelSalarioNetoMes.TabIndex = 1;
            this.labelSalarioNetoMes.Text = "Salario neto mensual";
            
            // 
            // labelSeguroSocial
            // 
            this.labelSeguroSocial.AutoSize = true;
            this.labelSeguroSocial.Location = new System.Drawing.Point(86, 123);
            this.labelSeguroSocial.Name = "labelSeguroSocial";
            this.labelSeguroSocial.Size = new System.Drawing.Size(73, 13);
            this.labelSeguroSocial.TabIndex = 2;
            this.labelSeguroSocial.Text = "Seguro Social";
            // 
            // labeIsrMes
            // 
            this.labeIsrMes.AutoSize = true;
            this.labeIsrMes.Location = new System.Drawing.Point(86, 179);
            this.labeIsrMes.Name = "labeIsrMes";
            this.labeIsrMes.Size = new System.Drawing.Size(68, 13);
            this.labeIsrMes.TabIndex = 4;
            this.labeIsrMes.Text = "ISR Mensual";
            // 
            // labelSeguroEducativo
            // 
            this.labelSeguroEducativo.AutoSize = true;
            this.labelSeguroEducativo.Location = new System.Drawing.Point(86, 149);
            this.labelSeguroEducativo.Name = "labelSeguroEducativo";
            this.labelSeguroEducativo.Size = new System.Drawing.Size(91, 13);
            this.labelSeguroEducativo.TabIndex = 3;
            this.labelSeguroEducativo.Text = "Seguro educativo";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 451);
            this.Controls.Add(this.labeIsrMes);
            this.Controls.Add(this.labelSeguroEducativo);
            this.Controls.Add(this.labelSeguroSocial);
            this.Controls.Add(this.labelSalarioNetoMes);
            this.Name = "Ta";
            this.Text = "Impuesto sobre la renta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSalarioNetoMes;
        private System.Windows.Forms.Label labelSeguroSocial;
        private System.Windows.Forms.Label labeIsrMes;
        private System.Windows.Forms.Label labelSeguroEducativo;
    }
}