using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection BAGLANTI = new SqlConnection("Data Source=DESKTOP-GMITMRC;Initial Catalog=mezar;Integrated Security=True");


        public static string adgonder;
        public static string dogumgonder;
        public static string olumgonder;
        public static string baba_adıgonder;
        public static string cepnogonder;
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (BAGLANTI.State == ConnectionState.Closed)
            {

                BAGLANTI.Open();
                SqlCommand ekle = new SqlCommand("INSERT INTO kayit(adsoyad,dogum,ölüm,telefon,baba_adı,bolge,durum) VALUES (@adsoyad,@dogum,@ölüm,@telefon,@baba_adı,@bolge,@durum)", BAGLANTI);

                ekle.Parameters.AddWithValue("@adsoyad", textBox1.Text);
                ekle.Parameters.AddWithValue("@dogum", textBox2.Text);
                ekle.Parameters.AddWithValue("@ölüm", textBox3.Text);
                ekle.Parameters.AddWithValue("@telefon", textBox4.Text);
                ekle.Parameters.AddWithValue("@baba_adı", textBox5.Text);
                ekle.Parameters.AddWithValue("@bolge", textBox6.Text);
                ekle.Parameters.AddWithValue("@durum", textBox7.Text);

                ekle.ExecuteNonQuery();
                BAGLANTI.Close();
                MessageBox.Show("KAYIT TAMAMLANMIŞTIR...", "KAYIT BİLGİSİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form4 a = new Form4();
                a.Show();


            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox6.Text = Form4.bolgegonder;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.Enabled = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
        && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
        && !char.IsSeparator(e.KeyChar);
        }
    }
}
