using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_04_Priscila_Atividade_Avaliativa
{
    public partial class Form2 : Form
    {
        float result = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Falta alguma nota!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float n1 = float.Parse(textBox1.Text);
                float n2 = float.Parse(textBox2.Text);
                float n3 = float.Parse(textBox3.Text);

                if (n1 < 0 || n1 > 10)
                {
                    MessageBox.Show("Nota 1 inválida!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (n2 < 0 || n2 > 10)
                {
                    MessageBox.Show("Nota 2 inválida!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (n3 < 0 || n3 > 10)
                {
                    MessageBox.Show("Nota 3 inválida!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (radioButton1.Checked)
                    {
                        result = (n1 + n2 + n3) / 3;
                        if (checkBox1.Checked)
                        {
                            label5.Text =
                                 "Nota 1 = " + n1.ToString("0.00") + "\n" +
                                 "Nota 2 = " + n2.ToString("0.00") + "\n" +
                                 "Nota 3 = " + n3.ToString("0.00") + "\n" +
                                 "Média = " + result.ToString("0.00");
                        }
                        else
                        {
                            label5.Text = "Média = " + result.ToString("0.00");
                        }
                    }
                    else if (radioButton2.Checked)
                    {
                        result = ((n1 * 3) + (n2 * 3) + (n3 * 4)) / 10;
                        if (checkBox1.Checked)
                        {
                            label5.Text =
                                 "Nota 1 = " + n1.ToString("0.00") + "\n" +
                                 "Nota 2 = " + n2.ToString("0.00") + "\n" +
                                 "Nota 3 = " + n3.ToString("0.00") + "\n" +
                                 "Média = " + result.ToString("0.00");
                        }
                        else
                        {
                            label5.Text = "Média = " + result.ToString("0.00");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum tipo de média foi selecionado!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            label5.Text = "0";
            checkBox1.Checked = false;
        }
    }
}
