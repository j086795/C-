using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula23_04
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float calc;

            try
            {
                if (comboBox1.Text == "Frasco de 500ml")
                {
                    calc = (float.Parse(textBox1.Text) * 10);
                    lblResultado.Text = calc.ToString("0.00");

                }
                else if (comboBox1.Text == "Frasco de 1l")
                {
                    calc = (float.Parse(textBox1.Text) * 20);
                    lblResultado.Text = calc.ToString("0.00");

                }
                else
                    MessageBox.Show("Selecione um combustível", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            catch (FormatException)
            {

                MessageBox.Show("Não deixe campos vazios");
            }
            finally
            {
                MessageBox.Show("Calculo finalizado!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.Text = "";
            lblResultado.Text = "0";
        }
    }
}
