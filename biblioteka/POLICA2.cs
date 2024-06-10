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
    public partial class POLICA2 : Form
    {
        public POLICA2()
        {
            InitializeComponent();
        }

        private void Sacuvaj_Click(object sender, EventArgs e)
        {
            Polica p = new Polica(Lorem.Text, Ipsum.Text, Dolor.Text);
            Data.DodajPolicu(p);
            Data.SP();
        }
    }
}
