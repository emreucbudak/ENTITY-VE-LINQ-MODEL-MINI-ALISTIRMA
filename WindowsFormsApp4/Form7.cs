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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        DBENTİTYURUNEntities dbl = new DBENTİTYURUNEntities();
        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in dbl.TBLSATIS
                                        select new
                                        {
                                            x.ID,
                                            x.URUNAD,
                                            x.FIYAT,
                                            x.KATEGORİ,
                                            x.MARKA
                                        }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBLSATIS tbl = new TBLSATIS();
            tbl.URUNAD= int.Parse(textBox1.Text);
            tbl.FIYAT = int.Parse(textBox3.Text);
            tbl.KATEGORİ = int.Parse(textBox2.Text);
            tbl.MARKA = int.Parse(textBox4.Text);
            dbl.TBLSATIS.Add(tbl);
            dbl.SaveChanges();
            MessageBox.Show("Ekleme Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox5.Text);
            var marka = dbl.TBLSATIS.Find(x);
            dbl.TBLSATIS.Remove(marka);
            dbl.SaveChanges();
            MessageBox.Show("Silme Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox5.Text);
            var marka = dbl.TBLSATIS.Find(x);
            marka.URUNAD = int.Parse(textBox2.Text);
            dbl.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
