using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_para_prova
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        double somaPreco = 0;
        int somaItem = 0;

        private void button1_Click(object sender, EventArgs e)
        {
           
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
            {

                MessageBox.Show("Informar todos os dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            
            else
            {
                int qtd = int.Parse(textBox2.Text);
                float preco = float.Parse(textBox3.Text);


                if (qtd <= 0)
                {

                    MessageBox.Show("Quantidade inválida", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (preco <= 0)
                {

                    MessageBox.Show("Preço inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {

       
                    listBox1.Items.Add(textBox1.Text);
                    listBox1.Items.Add(textBox2.Text);
                    listBox1.Items.Add(preco.ToString("0.00"));

                    label5.Text = "Preço do item: "+preco.ToString("0.00")+"\n"+
                                  "Preço total: "+(preco*qtd).ToString("0.00");

                    somaPreco += (preco*qtd);
                    somaItem += qtd;

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox1.Focus();

                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "Preço total em produtos: " + somaPreco.ToString("0.00")+"\n"+
                          "Quantidade total de itens: "+somaItem;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label5.Text = "0";
            listBox1.Items.Clear();
            somaItem = 0;
            somaPreco = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            listBox1.BackColor = colorDialog1.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
