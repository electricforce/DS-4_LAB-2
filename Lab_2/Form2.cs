using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string Label2Text
        {
            get { return labelSalarioNetoMes.Text; }
            set { labelSalarioNetoMes.Text = value; }

        }
        public string Label3Text
        {
            get { return labelSeguroSocial.Text; }
            set { labelSeguroSocial.Text = value; }

        }

        public string Label4Text
        {
            get { return labeIsrMes.Text; }
            set { labeIsrMes.Text = value; }

        }
        public string Label5Text
        {
            get { return labelSeguroEducativo.Text; }
            set { labelSeguroEducativo.Text = value; }

        }

    }
}
