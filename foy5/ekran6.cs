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
    public partial class ekran6 : Form
    {
        public ekran6()
        {
            InitializeComponent();
        }

        Model1 db = new Model1();

        private void button1_Click(object sender, EventArgs e)
        {
            int guncel_id = int.Parse(textBox1.Text);
            var degerler = db.tOgrenciDers.Where(ogrenci => ogrenci.dersID == guncel_id).Select(dersler =>
            new
            {
                Dersi_Alanlar = dersler.ogrenciID,
                Vize = dersler.vize,
                Final = dersler.final
            }
            );

            dataGridView1.DataSource = degerler.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int guncel_ders = int.Parse(textBox4.Text);
            int guncel_ogrenci = int.Parse(textBox5.Text);
            tOgrenciDers t = db.tOgrenciDers.SingleOrDefault(ogrenciDers => ogrenciDers.dersID == guncel_ders && ogrenciDers.ogrenciID == guncel_ogrenci);
            t.vize = int.Parse(textBox2.Text);
            t.final = int.Parse(textBox3.Text);
            db.SaveChanges();

            var degerler = db.tOgrenciDers;
            dataGridView2.DataSource = degerler.ToList();
        }
    }
}
