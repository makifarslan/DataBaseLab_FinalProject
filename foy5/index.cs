using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foy5
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void buton1_Click(object sender, EventArgs e)
        {
            ekran1 ekran = new ekran1();
            ekran.Show();
        }

        private void buton2_Click(object sender, EventArgs e)
        {
            ekran2 ekran = new ekran2();
            ekran.Show();
        }

        private void buton3_Click(object sender, EventArgs e)
        {
            ekran3 ekran = new ekran3();
            ekran.Show();
        }

        private void buton4_Click(object sender, EventArgs e)
        {
            ekran4 ekran = new ekran4();
            ekran.Show();
        }

        private void buton5_Click(object sender, EventArgs e)
        {
            ekran5 ekran = new ekran5();
            ekran.Show();
        }

        private void buton6_Click(object sender, EventArgs e)
        {
            ekran6 ekran = new ekran6();
            ekran.Show();
        }
    }
}
