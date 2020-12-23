using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static string bolgegonder;
        private void button1_Click(object sender, EventArgs e)
        {
            bolgegonder = button1.Text;
            Form3 mezarlık = new Form3();
            mezarlık.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bolgegonder = button2.Text;
            Form3 mezarlık = new Form3();
            mezarlık.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bolgegonder = button3.Text;
            Form3 mezarlık = new Form3();
            mezarlık.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bolgegonder = button4.Text;
            Form3 mezarlık = new Form3();
            mezarlık.ShowDialog();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bolgegonder = button5.Text;
            Form3 mezarlık = new Form3();
            mezarlık.ShowDialog();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bolgegonder = button6.Text;
            Form3 mezarlık = new Form3();
            mezarlık.ShowDialog();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bolgegonder = button9.Text;
            Form3 mezarlık = new Form3();
            mezarlık.ShowDialog();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bolgegonder = button8.Text;
            Form3 mezarlık = new Form3();
            mezarlık.ShowDialog();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bolgegonder = button7.Text;
            Form3 mezarlık = new Form3();
            mezarlık.ShowDialog();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bolgegonder = button10.Text;
            Form3 mezarlık = new Form3();
            mezarlık.ShowDialog();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bolgegonder = button11.Text;
            Form3 mezarlık = new Form3();
            mezarlık.ShowDialog();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bolgegonder = button12.Text;
            Form3 mezarlık = new Form3();
            mezarlık.ShowDialog();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bolgegonder = button13.Text;
            Form3 mezarlık = new Form3();
            mezarlık.ShowDialog();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bolgegonder = button14.Text;
            Form3 mezarlık = new Form3();
            mezarlık.ShowDialog();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            bolgegonder = button15.Text;
            Form3 mezarlık = new Form3();
            mezarlık.ShowDialog();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            bolgegonder = button16.Text;
            Form3 mezarlık = new Form3();
            mezarlık.ShowDialog();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            bolgegonder = button17.Text;
            Form3 mezarlık = new Form3();
            mezarlık.ShowDialog();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            bolgegonder = button18.Text;
            Form3 mezarlık = new Form3();
            mezarlık.ShowDialog();
            this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            bolgegonder = button19.Text;
            Form3 mezarlık = new Form3();
            mezarlık.ShowDialog();
            this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            bolgegonder = button20.Text;
            Form3 mezarlık = new Form3();
            mezarlık.ShowDialog();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlConnection ass = new SqlConnection("Data Source=DESKTOP-GMITMRC;Initial Catalog=mezar;Integrated Security=True");
            ass.Open();
            string SQL = "Select*From kayit where durum=@durum and bolge=@bolge ";
            
            SqlParameter prm1 = new SqlParameter("bolge", button1.Text);
            SqlParameter prm2 = new SqlParameter("bolge", button2.Text);
            SqlParameter prm3 = new SqlParameter("bolge", button3.Text);
            SqlParameter prm4 = new SqlParameter("bolge", button4.Text);
            SqlParameter prm5 = new SqlParameter("bolge", button5.Text);
            SqlParameter prm6 = new SqlParameter("bolge", button6.Text);
            SqlParameter prm7 = new SqlParameter("bolge", button7.Text);
            SqlParameter prm8 = new SqlParameter("bolge", button8.Text);
            SqlParameter prm9 = new SqlParameter("bolge", button9.Text);
            SqlParameter prm10 = new SqlParameter("bolge", button10.Text);
            SqlParameter prm11 = new SqlParameter("bolge", button11.Text);
            SqlParameter prm12 = new SqlParameter("bolge", button12.Text);
            SqlParameter prm13 = new SqlParameter("bolge", button13.Text);
            SqlParameter prm14 = new SqlParameter("bolge", button14.Text);
            SqlParameter prm15 = new SqlParameter("bolge", button15.Text);
            SqlParameter prm16 = new SqlParameter("bolge", button16.Text);
            SqlParameter prm17 = new SqlParameter("bolge", button17.Text);
            SqlParameter prm18 = new SqlParameter("bolge", button18.Text);
            SqlParameter prm19 = new SqlParameter("bolge", button19.Text);
            SqlParameter prm20 = new SqlParameter("bolge", button20.Text);
            SqlParameter prm21 = new SqlParameter("durum","DOLU");
            SqlParameter prm22 = new SqlParameter("durum", "DOLU");
            SqlParameter prm23 = new SqlParameter("durum", "DOLU");
            SqlParameter prm24 = new SqlParameter("durum", "DOLU");
            SqlParameter prm25 = new SqlParameter("durum", "DOLU");
            SqlParameter prm26 = new SqlParameter("durum", "DOLU");
            SqlParameter prm27 = new SqlParameter("durum", "DOLU");
            SqlParameter prm28 = new SqlParameter("durum", "DOLU");
            SqlParameter prm29 = new SqlParameter("durum", "DOLU");
            SqlParameter prm30 = new SqlParameter("durum", "DOLU");
            SqlParameter prm31 = new SqlParameter("durum", "DOLU");
            SqlParameter prm32 = new SqlParameter("durum", "DOLU");
            SqlParameter prm33 = new SqlParameter("durum", "DOLU");
            SqlParameter prm34 = new SqlParameter("durum", "DOLU");
            SqlParameter prm35 = new SqlParameter("durum", "DOLU");
            SqlParameter prm36 = new SqlParameter("durum", "DOLU");
            SqlParameter prm37 = new SqlParameter("durum", "DOLU");
            SqlParameter prm38 = new SqlParameter("durum", "DOLU");
            SqlParameter prm39 = new SqlParameter("durum", "DOLU");
            SqlParameter prm40 = new SqlParameter("durum", "DOLU");


            SqlCommand komut = new SqlCommand(SQL, ass);
            komut.Parameters.Add(prm1);
            komut.Parameters.Add(prm21);
            SqlCommand komut1 = new SqlCommand(SQL, ass);
            komut1.Parameters.Add(prm2);
            komut1.Parameters.Add(prm22);
            SqlCommand komut3 = new SqlCommand(SQL, ass);
            komut3.Parameters.Add(prm3);
            komut3.Parameters.Add(prm23);
            SqlCommand komut4 = new SqlCommand(SQL, ass);
            komut4.Parameters.Add(prm4);
            komut4.Parameters.Add(prm24);
            SqlCommand komut5 = new SqlCommand(SQL, ass);
            komut5.Parameters.Add(prm5);
            komut5.Parameters.Add(prm25);
            SqlCommand komut6 = new SqlCommand(SQL, ass);
            komut6.Parameters.Add(prm6);
            komut6.Parameters.Add(prm26);
            SqlCommand komut7 = new SqlCommand(SQL, ass);
            komut7.Parameters.Add(prm7);
            komut7.Parameters.Add(prm27);
            SqlCommand komut8 = new SqlCommand(SQL, ass);
            komut8.Parameters.Add(prm8);
            komut8.Parameters.Add(prm28);
            SqlCommand komut9 = new SqlCommand(SQL, ass);
            komut9.Parameters.Add(prm9);
            komut9.Parameters.Add(prm29);
            SqlCommand komut10 = new SqlCommand(SQL, ass);
            komut10.Parameters.Add(prm10);
            komut10.Parameters.Add(prm30);
            SqlCommand komut11 = new SqlCommand(SQL, ass);
            komut11.Parameters.Add(prm11);
            komut11.Parameters.Add(prm31);
            SqlCommand komut12 = new SqlCommand(SQL, ass);
            komut12.Parameters.Add(prm12);
            komut12.Parameters.Add(prm32);
            SqlCommand komut13 = new SqlCommand(SQL, ass);
            komut13.Parameters.Add(prm13);
            komut13.Parameters.Add(prm33);
            SqlCommand komut14 = new SqlCommand(SQL, ass);
            komut14.Parameters.Add(prm14);
            komut14.Parameters.Add(prm34);
            SqlCommand komut15 = new SqlCommand(SQL, ass);
            komut15.Parameters.Add(prm15);
            komut15.Parameters.Add(prm35);
            SqlCommand komut16 = new SqlCommand(SQL, ass);
            komut16.Parameters.Add(prm16);
            komut16.Parameters.Add(prm36);
            SqlCommand komut17 = new SqlCommand(SQL, ass);
            komut17.Parameters.Add(prm17);
            komut17.Parameters.Add(prm37);
            SqlCommand komut18 = new SqlCommand(SQL, ass);
            komut18.Parameters.Add(prm18);
            komut18.Parameters.Add(prm38);
            SqlCommand komut19 = new SqlCommand(SQL, ass);
            komut19.Parameters.Add(prm19);
            komut19.Parameters.Add(prm39);
            SqlCommand komut20 = new SqlCommand(SQL, ass);
            komut20.Parameters.Add(prm20);
            komut20.Parameters.Add(prm40);

            DataTable dt = new DataTable();

            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            DataTable dt5 = new DataTable();
            DataTable dt6 = new DataTable();
            DataTable dt7 = new DataTable();

            DataTable dt8 = new DataTable();
            DataTable dt9 = new DataTable();
            DataTable dt10 = new DataTable();
            DataTable dt11 = new DataTable();
            DataTable dt12 = new DataTable();
            DataTable dt13 = new DataTable();
            DataTable dt14 = new DataTable();
            DataTable dt15 = new DataTable();
            DataTable dt16 = new DataTable();
            DataTable dt17 = new DataTable();
            DataTable dt18 = new DataTable();
            DataTable dt19 = new DataTable();


            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataAdapter da1 = new SqlDataAdapter(komut1);
            SqlDataAdapter da2 = new SqlDataAdapter(komut3);
            SqlDataAdapter da3 = new SqlDataAdapter(komut4);
            SqlDataAdapter da4 = new SqlDataAdapter(komut5);
            SqlDataAdapter da5 = new SqlDataAdapter(komut6);
            SqlDataAdapter da6 = new SqlDataAdapter(komut7);
            SqlDataAdapter da7 = new SqlDataAdapter(komut8);
            SqlDataAdapter da8 = new SqlDataAdapter(komut9);
            SqlDataAdapter da9 = new SqlDataAdapter(komut10);
            SqlDataAdapter da10 = new SqlDataAdapter(komut11);
            SqlDataAdapter da11 = new SqlDataAdapter(komut12);
            SqlDataAdapter da12 = new SqlDataAdapter(komut13);
            SqlDataAdapter da13 = new SqlDataAdapter(komut14);
            SqlDataAdapter da14 = new SqlDataAdapter(komut15);
            SqlDataAdapter da15 = new SqlDataAdapter(komut16);
            SqlDataAdapter da16 = new SqlDataAdapter(komut17);
            SqlDataAdapter da17 = new SqlDataAdapter(komut18);
            SqlDataAdapter da18 = new SqlDataAdapter(komut19);
            SqlDataAdapter da19 = new SqlDataAdapter(komut20);


            da.Fill(dt);
            da1.Fill(dt1);
            da2.Fill(dt2);
            da3.Fill(dt3);
            da4.Fill(dt4);
            da5.Fill(dt5);
            da6.Fill(dt6);
            da7.Fill(dt7);
            da8.Fill(dt8);
            da9.Fill(dt9);
            da10.Fill(dt10);
            da11.Fill(dt11);
            da12.Fill(dt12);
            da13.Fill(dt13);
            da14.Fill(dt14);
            da15.Fill(dt15);
            da16.Fill(dt16);
            da17.Fill(dt17);
            da18.Fill(dt18);
            da19.Fill(dt19);

            if (dt.Rows.Count > 0  )
            {
               
                    button1.BackColor = Color.Red;
                    button1.Enabled = false;
                }
                else
                {
                    button1.BackColor = Color.White;
                    button1.Enabled = true;
                }




            if (dt1.Rows.Count > 0)
            {

                button2.BackColor = Color.Red;
                button2.Enabled = false;
            }
            else
            {
                button2.BackColor = Color.White;
                button2.Enabled = true;
            }


            if (dt2.Rows.Count > 0)
            {

                button3.BackColor = Color.Red;
                button3.Enabled = false;
            }
            else
            {
                button3.BackColor = Color.White;
                button3.Enabled = true;
            }


            if (dt3.Rows.Count > 0)
            {

                button4.BackColor = Color.Red;
                button4.Enabled = false;
            }
            else
            {
                button4.BackColor = Color.White;
                button4.Enabled = true;
            }

            if (dt4.Rows.Count > 0)
            {

                button5.BackColor = Color.Red;
                button5.Enabled = false;
            }
            else
            {
                button5.BackColor = Color.White;
                button5.Enabled = true;
            }


            if (dt5.Rows.Count > 0)
            {

                button6.BackColor = Color.Red;
                button6.Enabled = false;
            }
            else
            {
                button6.BackColor = Color.White;
                button6.Enabled = true;
            }



            if (dt6.Rows.Count > 0)
            {

                button7.BackColor = Color.Red;
                button7.Enabled = false;
            }
            else
            {
                button7.BackColor = Color.White;
                button7.Enabled = true;
            }

            if (dt7.Rows.Count > 0)
            {

                button8.BackColor = Color.Red;
                button8.Enabled = false;
            }
            else
            {
                button8.BackColor = Color.White;
                button8.Enabled = true;
            }


            if (dt8.Rows.Count > 0)
            {

                button9.BackColor = Color.Red;
                button9.Enabled = false;
            }
            else
            {
                button9.BackColor = Color.White;
                button9.Enabled = true;
            }


            if (dt9.Rows.Count > 0)
            {

                button10.BackColor = Color.Red;
                button10.Enabled = false;
            }
            else
            {
                button10.BackColor = Color.White;
                button10.Enabled = true;
            }

            if (dt10.Rows.Count > 0)
            {

                button11.BackColor = Color.Red;
                button11.Enabled = false;
            }
            else
            {
                button11.BackColor = Color.White;
                button11.Enabled = true;
            }


            if (dt11.Rows.Count > 0)
            {

                button12.BackColor = Color.Red;
                button12.Enabled = false;
            }
            else
            {
                button12.BackColor = Color.White;
                button12.Enabled = true;
            }

            if (dt12.Rows.Count > 0)
            {

                button13.BackColor = Color.Red;
                button13.Enabled = false;
            }
            else
            {
                button13.BackColor = Color.White;
                button13.Enabled = true;
            }

            if (dt13.Rows.Count > 0)
            {

                button14.BackColor = Color.Red;
                button14.Enabled = false;
            }
            else
            {
                button14.BackColor = Color.White;
                button14.Enabled = true;
            }


            if (dt14.Rows.Count > 0)
            {

                button15.BackColor = Color.Red;
                button15.Enabled = false;
            }
            else
            {
                button15.BackColor = Color.White;
                button15.Enabled = true;
            }



            if (dt15.Rows.Count > 0)
            {

                button16.BackColor = Color.Red;
                button16.Enabled = false;
            }
            else
            {
                button16.BackColor = Color.White;
                button16.Enabled = true;
            }


            if (dt16.Rows.Count > 0)
            {

                button17.BackColor = Color.Red;
                button17.Enabled = false;
            }
            else
            {
                button17.BackColor = Color.White;
                button17.Enabled = true;
            }


            if (dt17.Rows.Count > 0)
            {

                button18.BackColor = Color.Red;
                button18.Enabled = false;
            }
            else
            {
                button18.BackColor = Color.White;
                button18.Enabled = true;
            }


            if (dt18.Rows.Count > 0)
            {

                button19.BackColor = Color.Red;
                button19.Enabled = false;
            }
            else
            {
                button19.BackColor = Color.White;
                button19.Enabled = true;
            }


            if (dt19.Rows.Count > 0)
            {

                button20.BackColor = Color.Red;
                button20.Enabled = false;
            }
            else
            {
                button20.BackColor = Color.White;
                button20.Enabled = true;
            }




        }

        private void button21_Click(object sender, EventArgs e)
        {

        }
    }
}
