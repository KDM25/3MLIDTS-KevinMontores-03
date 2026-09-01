using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3MLIDTS_KevinMontores_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {

           if (tbxCelsius.Text != "" || tbxFahrenheit.Text != "" || tbxKelvin.Text != "")
           {

              if (!string.IsNullOrEmpty(tbxCelsius.Text)) {
                 if (rbCelsius.Checked) {
                    tbxFahrenheit.Enabled = false;
                    tbxKelvin.Enabled = false;
                 }

                float Ce = float.Parse(tbxCelsius.Text);
                float fa = (Ce * 9f / 5f) + 32;
                float ke = Ce + 273;
                tbxFahrenheit.Text = fa.ToString();
                tbxKelvin.Text = ke.ToString();

           } else if (!string.IsNullOrEmpty(tbxFahrenheit.Text)) {
                if (rbFahrenheit.Checked)
                {
                    tbxCelsius.Enabled = false;
                    tbxKelvin.Enabled = false;
                }
                float fa = float.Parse(tbxFahrenheit.Text);
                float ce = (fa - 32) * 5.0f / 9.0f;
                float ke = ce + 273;
                tbxCelsius.Text = ce.ToString();
                tbxKelvin.Text = ke.ToString();
             } else if (!string.IsNullOrEmpty(tbxKelvin.Text)) {

                if (rbKelvin.Checked)
                {
                    tbxFahrenheit.Enabled = false;
                    tbxCelsius.Enabled = false;
                }
                float ke = float.Parse(tbxKelvin.Text);
                float ce = ke - 273;
                float fa = (ce * 9f / 5f) + 32;
                tbxFahrenheit.Text = fa.ToString();
                tbxCelsius.Text = ce.ToString();
             }
           }  
            else  {
                MessageBox.Show("Ingrese valores numericos para el calculo de temperatura", "Error de valores",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxKelvin.Clear();
            tbxFahrenheit.Clear();
            tbxCelsius.Clear();
            tbxKelvin.Enabled = true;
            tbxFahrenheit.Enabled = true;
            tbxCelsius.Enabled = true;
            rbCelsius.Checked = false;
            rbKelvin.Checked = false;
            rbFahrenheit.Checked = false;
        }
    }
}
;