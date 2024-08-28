using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        double salarioNeto;

        public Form1()
        {
            InitializeComponent();

        }
        void guardarValores()
        {
            salarioNeto = Convert.ToDouble(tbsalario.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lnombre_Click(object sender, EventArgs e)
        {

        }


        private void lSalario_Click(object sender, EventArgs e)
        {

        }
        

        private void lCedula_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        } 

        private void tbsalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            guardarValores();
            string nombreEmpleado = tbNombre.Text;
            string cedulaEmpleado = tbCedula.Text;
            string salarioNetoMensual = tbsalario.Text;

            resultadosInfo resultado = new resultadosInfo();
            resultado.pSeguroSocial = (salarioNeto * 0.0975);
            resultado.pSeguroEducativo = (salarioNeto * 0.0125);
            resultado.NombreEmpleado = nombreEmpleado;
            resultado.CedulaEmpleado = cedulaEmpleado;
            resultado.SalarioNetoMensual = salarioNetoMensual;

            Resultados result = new Resultados(resultado);
            result.Show();
        }
    }
}
