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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        DBENTİTYURUNEntities dbl = new DBENTİTYURUNEntities();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            label2.Text = dbl.TBLURUN.Count().ToString();
            label4.Text = dbl.TBLSATIS.Sum(x => x.FIYAT).ToString();
            label6.Text = dbl.TBLKATEGORI.Count().ToString();
            label8.Text = dbl.GIRIS.Count().ToString();
            label10.Text = (from x in dbl.TBLURUN select x.URUNKATEGORİ).Distinct().Count().ToString();
            label12.Text = dbl.MARKA.Count().ToString();
            label14.Text = (from x in dbl.TBLURUN select x.URUNMARKA).Distinct().Count().ToString();
            label16.Text = (from x in dbl.TBLURUN select x.URUNKATEGORİ == 1).Count().ToString();
            label18.Text = dbl.MARKAGETIR().FirstOrDefault().ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
