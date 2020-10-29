using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            if (rdbCelsius.Checked == true)
            {
                txtResultado.Text= LibreriaConvertidor.Class1.Celsius(Convert.ToInt32(textBox1.Text)).ToString();
            }
            else
            {
                
                txtResultado.Text = LibreriaConvertidor.Class1.fahrenheit(Convert.ToInt32(textBox1.Text)).ToString(); ;
            }
        }

        private void rdbCelsius_CheckedChanged(object sender, EventArgs e)
        {
            lblGrado1.Text = "fahrenheit";
        }

        private void rdbFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            lblGrado1.Text = "Celsius";
        }
    }
}
