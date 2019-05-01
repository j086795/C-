using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_30_04
{
    public partial class Form2 : Form
    {
        int op = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionRange.Start.ToLongDateString();
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            op = 6;
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            op = 7;
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            op = 8;
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            op = 9;
        }

        private void lbl10_Click(object sender, EventArgs e)
        {
            op = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (op == 6)
            {
                lbl6.Text = textBox2.Text;

            }
            else if (op == 7)
            {
                lbl7.Text = textBox2.Text;

            }
            else if (op == 8)
            {
                lbl8.Text = textBox2.Text;

            }
            else if (op == 9)
            {
                lbl9.Text = textBox2.Text;

            }
            else if (op == 10)
            {
                lbl10.Text = textBox2.Text;

            }
            else 
                MessageBox.Show("Escolha o horário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome_arq = monthCalendar1.SelectionRange.Start.ToLongDateString();
            StreamWriter arquivo;

            if (File.Exists("C:\\Users\\aluno\\Desktop\\" + nome_arq + ".txt"))
                File.Delete("C:\\Users\\aluno\\Desktop\\" + nome_arq + ".txt");

            arquivo = new StreamWriter("C:\\Users\\aluno\\Desktop\\" + nome_arq + ".txt");

            foreach (Label controle in tableLayoutPanel1.Controls)
            {

                arquivo.WriteLine(controle.Text);
            }

            arquivo.Close();

            MessageBox.Show("Arquivo gravado com sucesso!", "FInalização", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
