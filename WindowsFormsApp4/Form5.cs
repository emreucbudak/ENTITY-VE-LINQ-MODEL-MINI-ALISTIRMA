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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        DBENTİTYURUNEntities dbl = new DBENTİTYURUNEntities();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in dbl.MARKA
                                        select new
                                        {
                                            x.MARKAID,
                                            x.MARKAAD
                                        }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MARKA mark = new MARKA();
            mark.MARKAAD = textBox2.Text;
            dbl.MARKA.Add(mark);
            dbl.SaveChanges();
            MessageBox.Show("Ekleme Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var marka = dbl.MARKA.Find(x);
            marka.MARKAAD = textBox2.Text;
            dbl.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var marka = dbl.MARKA.Find(x);
            dbl.MARKA.Remove(marka);
            dbl.SaveChanges();
            MessageBox.Show("Silme Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
