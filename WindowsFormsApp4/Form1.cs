using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DBENTİTYURUNEntities dbl = new DBENTİTYURUNEntities();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in dbl.TBLURUN select new
            {
                x.URUNID,x.URUNAD,x.MARKA.MARKAAD,x.FIYAT,x.TBLKATEGORI.KATEGORIAD,x.DURUM
            }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TBLURUN urun = new TBLURUN();
            urun.URUNAD = textBox2.Text;
            urun.URUNKATEGORİ = int.Parse(textBox3.Text);
            urun.URUNMARKA = int.Parse(textBox5.Text);
            urun.FIYAT = int.Parse(textBox4.Text);
            urun.DURUM = true;
            dbl.TBLURUN.Add(urun);
            dbl.SaveChanges();
            MessageBox.Show("Ekleme Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(textBox1.Text);
            var ktgr = dbl.TBLURUN.Find(x);
            dbl.TBLURUN.Remove(ktgr);
            dbl.SaveChanges();
            MessageBox.Show("Silme Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(textBox1.Text);
            var ktgr = dbl.TBLURUN.Find(x);
            ktgr.URUNAD = textBox2.Text;
            ktgr.URUNKATEGORİ = int.Parse(textBox3.Text);
            ktgr.URUNMARKA = int.Parse(textBox5.Text);
            ktgr.FIYAT = int.Parse(textBox4.Text);
            dbl.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
