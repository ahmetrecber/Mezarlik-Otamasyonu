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

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 bilgi = new Form6();
            bilgi.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form4 mezarlık = new Form4();
           mezarlık.Show();
           

        }
    }
}
