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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calcularCombustívelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form2>().Count() == 0)
            {
                Form2 filho2 = new Form2();
                filho2.MdiParent = this;
                filho2.Show();


            }
            else
            {

                MessageBox.Show("Janela já está aberta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calcularÓleoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form3>().Count() == 0)
            {
                Form3 filho3 = new Form3();
                filho3.MdiParent = this;
                filho3.Show();


            }
            else
            {

                MessageBox.Show("Janela já está aberta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AboutBox1>().Count() == 0)
            {
                AboutBox1 ajuda = new AboutBox1();
                ajuda.MdiParent = this;
                ajuda.Show();


            }
            else
            {

                MessageBox.Show("Janela já está aberta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
