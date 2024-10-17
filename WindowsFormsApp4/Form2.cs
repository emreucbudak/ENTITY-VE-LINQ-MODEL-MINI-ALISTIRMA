using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBENTİTYURUNEntities dbll = new DBENTİTYURUNEntities();
            var giris = (from x in dbll.GIRIS where textBox1.Text == x.KULLANICIADI && textBox2.Text == x.SIFRE select x.ID);
            if (giris.Any())
            {
                Form3 form1 = new Form3();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Şifre Veya Kullanıcı Adı","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
