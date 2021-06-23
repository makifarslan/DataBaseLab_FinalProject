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
    public partial class ekran5 : Form
    {
        public ekran5()
        {
            InitializeComponent();
        }

        Model1 db = new Model1();

        private void button1_Click(object sender, EventArgs e)
        {
            int guncel_id = int.Parse(textBox1.Text);
            var degerler = db.tOgrenciDers.Where(ogrenci => ogrenci.ogrenciID == guncel_id).Select(dersler => 
            new 
            {
                Aldigi_Dersler = dersler.dersID
            }
            );

            dataGridView1.DataSource = degerler.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int guncel_dersid = int.Parse(textBox4.Text);
            String guncel_yil = textBox2.Text;
            String guncel_yariyil = textBox3.Text;
            var degerler = db.tOgrenciDers.Where(x => x.yil == guncel_yil && x.yariyil == guncel_yariyil && x.dersID == guncel_dersid).Select(ogrenci => 
            new
            {
                Alan_Öğrenciler = ogrenci.ogrenciID
            }
            ).Distinct();
            
            dataGridView2.DataSource = degerler.ToList();
        }
    }
}