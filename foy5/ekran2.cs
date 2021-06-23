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
    public partial class ekran2 : Form
    {
        public ekran2()
        {
            InitializeComponent();
        }

        Model1 db = new Model1();

        private void button1_Click(object sender, EventArgs e)
        {
            tDers t = new tDers();
            t.dersID = int.Parse(textBox1.Text);
            t.dersAd = textBox2.Text;
            t.bolumID = int.Parse(textBox3.Text);
            db.tDers.Add(t);
            db.SaveChanges();

            var degerler = db.tDers;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var degerler = db.tDers;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int guncel_id = int.Parse(textBox1.Text);
            tDers t = db.tDers.SingleOrDefault(ders => ders.dersID == guncel_id);
            t.dersAd = textBox2.Text;
            t.bolumID = int.Parse(textBox3.Text);
            db.SaveChanges();

            var degerler = db.tDers;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sil_id = int.Parse(textBox1.Text);
            tDers t = db.tDers.SingleOrDefault(ders => ders.dersID == sil_id);
            db.tDers.Remove(t);
            db.SaveChanges();

            var degerler = db.tDers;
            dataGridView1.DataSource = degerler.ToList();
        }
    }
}
