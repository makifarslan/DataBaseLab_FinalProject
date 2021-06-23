using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace foy5
{
    public partial class ekran1 : Form
    {

        public ekran1()
        {
            InitializeComponent();
        }

        Model1 db = new Model1();


        private void button1_Click(object sender, EventArgs e)
        {
            tOgrenci t = new tOgrenci();
            t.ogrenciID = int.Parse(textBox1.Text);
            t.ad = textBox2.Text;
            t.soyad = textBox3.Text;
            t.bolumID = int.Parse(textBox4.Text);
            db.tOgrenci.Add(t);
            db.SaveChanges();

            var degerler = db.tOgrenci;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var degerler = db.tOgrenci;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int guncel_id = int.Parse(textBox1.Text);
            tOgrenci t = db.tOgrenci.SingleOrDefault(ogrenci => ogrenci.ogrenciID == guncel_id);
            t.ad = textBox2.Text;
            t.soyad = textBox3.Text;
            t.bolumID = int.Parse(textBox4.Text);
            db.SaveChanges();

            var degerler = db.tOgrenci;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sil_id = int.Parse(textBox1.Text);
            tOgrenci t = db.tOgrenci.SingleOrDefault(ogrenci => ogrenci.ogrenciID == sil_id);
            db.tOgrenci.Remove(t);
            db.SaveChanges();

            var degerler = db.tOgrenci;
            dataGridView1.DataSource = degerler.ToList();
        }
    }
}
