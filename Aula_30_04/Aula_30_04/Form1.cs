using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_30_04
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

        private void marcarHorárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form2>().Count() == 0)
            {
                Form2 f2 = new Form2();
                f2.MdiParent = this;
                f2.Show();

            }
            else

                MessageBox.Show("Agenda já está aberta", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
