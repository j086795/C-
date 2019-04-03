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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculadoraDeNotasToolStripMenuItem_Click(object sender, EventArgs e) { 
            if (Application.OpenForms.OfType<Form2>().Count() == 0)
            {
                Form2 form = new Form2();
                form.Show();
            }
            else
            {
                MessageBox.Show("A aplicação já está em execução!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
