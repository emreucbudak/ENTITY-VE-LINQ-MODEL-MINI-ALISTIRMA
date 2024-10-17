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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        DBENTİTYURUNEntities dbl = new DBENTİTYURUNEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in dbl.TBLKATEGORI
                                        select new
                                        {
                                            x.ID,
                                            x.KATEGORIAD
                                        }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TBLKATEGORI mark = new TBLKATEGORI();
            mark.KATEGORIAD = textBox2.Text;
            dbl.TBLKATEGORI.Add(mark);
            dbl.SaveChanges();
            MessageBox.Show("Ekleme Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var marka = dbl.TBLKATEGORI.Find(x);
            marka.KATEGORIAD = textBox2.Text;
            dbl.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var marka = dbl.TBLKATEGORI.Find(x);
            dbl.TBLKATEGORI.Remove(marka);
            dbl.SaveChanges();
            MessageBox.Show("Silme Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
