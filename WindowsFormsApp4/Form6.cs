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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection mezar = new SqlConnection("Data Source=DESKTOP-GMITMRC;Initial Catalog=mezar;Integrated Security=True");
        private void verilerigoruntule()
        {
            mezar.Open();
            SqlCommand komut = new SqlCommand("Select *From kayit", mezar);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["dogum"].ToString());
                ekle.SubItems.Add(oku["ölüm"].ToString());
                ekle.SubItems.Add(oku["bolge"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["baba_adı"].ToString());
                listView1.Items.Add(ekle);
            }
            mezar.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mezar.Open();
            int a = Convert.ToInt32(listView1.SelectedItems[0].Text);
            SqlCommand sil = new SqlCommand("Delete From kayit where id=(" + a + ")", mezar);
            listView1.Items.Clear();
            sil.ExecuteNonQuery();
            mezar.Close();
            verilerigoruntule();

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            verilerigoruntule();
        }
    }
}
