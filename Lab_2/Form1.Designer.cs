namespace Lab_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.tbsalario = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.lCedula = new System.Windows.Forms.Label();
            this.lSalario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.White;
            this.tbNombre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(128, 172);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 22);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.Tag = "tbNombre";
            this.toolTip1.SetToolTip(this.tbNombre, "Ingrese su nombre");
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Black;
            // 
            // tbCedula
            // 
            this.tbCedula.BackColor = System.Drawing.Color.White;
            this.tbCedula.Location = new System.Drawing.Point(128, 230);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(100, 20);
            this.tbCedula.TabIndex = 5;
            this.tbCedula.Tag = "tbCedula";
            this.toolTip1.SetToolTip(this.tbCedula, "Ingrese su cédula");
            this.tbCedula.TextChanged += new System.EventHandler(this.tbCedula_TextChanged);
            // 
            // tbsalario
            // 
            this.tbsalario.BackColor = System.Drawing.Color.White;
            this.tbsalario.Location = new System.Drawing.Point(128, 283);
            this.tbsalario.Name = "tbsalario";
            this.tbsalario.Size = new System.Drawing.Size(100, 20);
            this.tbsalario.TabIndex = 7;
            this.tbsalario.Tag = "tbCedula";
            this.toolTip1.SetToolTip(this.tbsalario, "Ingrese su cédula");
            this.tbsalario.TextChanged += new System.EventHandler(this.tbsalario_TextChanged);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.BackColor = System.Drawing.Color.SkyBlue;
            this.lNombre.ForeColor = System.Drawing.Color.Black;
            this.lNombre.Location = new System.Drawing.Point(128, 156);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 3;
            this.lNombre.Tag = "lNombre";
            this.lNombre.Text = "Nombre";
            this.lNombre.Click += new System.EventHandler(this.lnombre_Click);
            // 
            // lCedula
            // 
            this.lCedula.AutoSize = true;
            this.lCedula.BackColor = System.Drawing.Color.SkyBlue;
            this.lCedula.Location = new System.Drawing.Point(128, 214);
            this.lCedula.Name = "lCedula";
            this.lCedula.Size = new System.Drawing.Size(40, 13);
            this.lCedula.TabIndex = 4;
            this.lCedula.Tag = "lCedula";
            this.lCedula.Text = "Cédula";
            this.lCedula.Click += new System.EventHandler(this.lCedula_Click_1);
            // 
            // lSalario
            // 
            this.lSalario.AutoSize = true;
            this.lSalario.BackColor = System.Drawing.Color.SkyBlue;
            this.lSalario.Location = new System.Drawing.Point(128, 267);
            this.lSalario.Name = "lSalario";
            this.lSalario.Size = new System.Drawing.Size(108, 13);
            this.lSalario.TabIndex = 6;
            this.lSalario.Tag = "lSalario";
            this.lSalario.Text = "Salario bruto mensual";
            this.lSalario.Click += new System.EventHandler(this.lSalario_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Lab_2.Properties.Resources.fondo;
            this.pictureBox2.Location = new System.Drawing.Point(89, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 192);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Lab_2.Properties.Resources._5580988;
            this.pictureBox1.Location = new System.Drawing.Point(110, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(144, 349);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 9;
            this.btCalcular.Tag = "btCalcular";
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(338, 395);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbsalario);
            this.Controls.Add(this.lSalario);
            this.Controls.Add(this.tbCedula);
            this.Controls.Add(this.lCedula);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Inicio de sesion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

=======
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Taylor";
>>>>>>> 239cb0aa6e909b6ae7ebe5ea69308b84c456c69d
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lCedula;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.Label lSalario;
        private System.Windows.Forms.TextBox tbsalario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btCalcular;
    }
}

