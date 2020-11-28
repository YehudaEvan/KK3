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

namespace App_Laundry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection(@"Data Source=LAPTOP-8ADEE2FO\GUSTAM;Initial Catalog=LaundryLogin;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from Login where NamaUser = '" + textBox1.Text + "' and Password = '" + textBox2.Text +"'",koneksi);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Home panggil = new Home();
                panggil.Show();
            }
            else
            {
                MessageBox.Show("Mohon Isi User Name dan Password Anda dengan Benar !", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
