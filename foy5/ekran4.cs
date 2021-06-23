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
    public partial class ekran4 : Form
    {
        public ekran4()
        {
            InitializeComponent();
        }

        Model1 db = new Model1();

        private void button1_Click(object sender, EventArgs e)
        {
            tOgrenciDers t = new tOgrenciDers();
            t.odID = int.Parse(textBox1.Text);
            t.ogrenciID = int.Parse(textBox2.Text);
            t.dersID = int.Parse(textBox3.Text);
            t.yil = textBox4.Text;
            t.yariyil = textBox5.Text;
            db.tOgrenciDers.Add(t);
            db.SaveChanges();

            var degerler = db.tOgrenciDers;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var degerler = db.tOgrenciDers;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int guncel_id = int.Parse(textBox1.Text);
            tOgrenciDers t = db.tOgrenciDers.SingleOrDefault(ogrenciDers => ogrenciDers.odID == guncel_id);
            t.ogrenciID = int.Parse(textBox2.Text);
            t.dersID = int.Parse(textBox3.Text);
            t.yil = textBox4.Text;
            t.yariyil = textBox5.Text;
            db.SaveChanges();

            var degerler = db.tOgrenciDers;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sil_id = int.Parse(textBox1.Text);
            tOgrenciDers t = db.tOgrenciDers.SingleOrDefault(ogrenciDers => ogrenciDers.odID == sil_id);
            db.tOgrenciDers.Remove(t);
            db.SaveChanges();

            var degerler = db.tOgrenciDers;
            dataGridView1.DataSource = degerler.ToList();
        }
    }
}
