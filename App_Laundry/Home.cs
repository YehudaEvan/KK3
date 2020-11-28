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
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;

namespace App_Laundry
{
    public partial class Home : Form
    {
        SqlConnection koneksi = new SqlConnection(@"Data Source=LAPTOP-8ADEE2FO\GUSTAM;Initial Catalog=LaundryLogin;Integrated Security=True");
        public Home()
        {
            InitializeComponent();
        }
        string Pilihan_Layanan;
        string imglocation = "";
        SqlCommand cmd;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream streem = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(streem);
            images = brs.ReadBytes((int)streem.Length);
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "insert into [Data] ([Nama_Pelanggan],[Jenis_Cucian],[Berat_per_Kg],[Harga_per_Kg],[Harga_Total],[Uang_Pembayaran],[Kembailan],[Tanggal_Pengambilan],[Pilihan_Layanan],[Foto_Pelanggan]) value ('" + textBox1.Text + "','" + textBox8.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + dateTimePicker1 + "','" + Pilihan_Layanan + "',@images)";
            cmd.CommandText = "INSERT INTO [Data] (" +
                                   " [Nama_Pelanggan]," +
                                    "[Jenis_Cucian]," +
                                    "[Berat_per_Kg]," +
                                    "[Harga_per_Kg]," +
                                    "[Harga_Total]," +
                                    "[Uang_Pembayaran]," +
                                    "[Kembalian]," +
                                    "[Tanggal_Pegambilan]," +
                                    "[Pilihan_Layanan]," +
                                    "[Foto_Pelanggan]" +
                                ") VALUES('" + textBox1.Text + "'," +
                                "'" + textBox8.Text + "'," +
                                textBox2.Text + "'," +
                                textBox4.Text + "'," +
                                textBox5.Text + "'," +
                                textBox3.Text + "'," +
                                textBox6.Text + "'," +
                                dateTimePicker1+ "'," +
                                Pilihan_Layanan+ "',@images)";
            
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            koneksi.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox1.ImageLocation = null;
            display_data();
            MessageBox.Show("Data Sukses Dimasukan");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Pilihan_Layanan = "Standard";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Pilihan_Layanan = "Kilat";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Data] where Nama_Pelanggan = '" + textBox1.Text + "'";
            koneksi.Close();
            textBox1.Text = "";
            display_data();
            MessageBox.Show("Data Sukses Di Hapus");
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream streem = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(streem);
            images = brs.ReadBytes((int)streem.Length);
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [Data] set Nama_Pelanggan'" + this.textBox1.Text + "', Jenis_Cucian'" + this.textBox8.Text + "',Berat_per_Kg'" + this.textBox2.Text + "',Harga_per_Kg'" + this.textBox4.Text + "',Harga_Total'" + this.textBox5.Text + "',Uang_Pembayaran'" + this.textBox3.Text + "', Kembalian'" + this.textBox6.Text + "',Tanggal_Pembayaran'" + this.dateTimePicker1 + "',Pilihan_Layanan'" + this.Pilihan_Layanan + "',Foto=@images where Nama_Pelanggan='"+this.textBox1.Text+"'";
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            koneksi.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox1.ImageLocation = null;
            display_data();
            MessageBox.Show("Data Sukses Di Update");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from [Data] where Nama_Pelanggan = '"+textBox7.Text+"'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
            textBox7.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox1.ImageLocation = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {  
           // koneksi.Open();
           // SqlCommand cmd = koneksi.CreateCommand();
           /// cmd.CommandType = CommandType.Text;
           // cmd.CommandText = "select * from [Data]";
           /// DataTable dta = new DataTable();
           /// SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
           // dataadp.Fill(dta);
           // dataGridView1.DataSource = dta;
           /// koneksi.Close();
            ////
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglocation;
            }
        }
        public void display_data()
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Data]";
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            koneksi.Close();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laundryLoginDataSet1.Data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.laundryLoginDataSet1.Data);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
