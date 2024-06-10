using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class FormaCitaoc : Form
    {
        public FormaCitaoc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaDodavanjaCitaoca forma=new FormaDodavanjaCitaoca();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                FormaDodavanjaCitaoca forma = new FormaDodavanjaCitaoca();
                forma.ShowDialog();
            }
        }
    }
}
