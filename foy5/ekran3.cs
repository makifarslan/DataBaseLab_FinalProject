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
    public partial class ekran3 : Form
    {
        public ekran3()
        {
            InitializeComponent();
        }

        Model1 db = new Model1();

        private void button1_Click_1(object sender, EventArgs e)
        {
            tBolum t = new tBolum();
            t.bolumID = int.Parse(textBox1.Text);
            t.bolumAd = textBox2.Text;
            t.fakulteID = int.Parse(textBox3.Text);
            db.tBolum.Add(t);
            db.SaveChanges();

            var degerler = db.tBolum;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var degerler = db.tBolum;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int guncel_id = int.Parse(textBox1.Text);
            tBolum t = db.tBolum.SingleOrDefault(bolum => bolum.bolumID == guncel_id);
            t.bolumAd = textBox2.Text;
            t.fakulteID = int.Parse(textBox3.Text);
            db.SaveChanges();

            var degerler = db.tBolum;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int sil_id = int.Parse(textBox1.Text);
            tBolum t = db.tBolum.SingleOrDefault(bolum => bolum.bolumID == sil_id);
            db.tBolum.Remove(t);
            db.SaveChanges();

            var degerler = db.tBolum;
            dataGridView1.DataSource = degerler.ToList();
        }
    }
}
