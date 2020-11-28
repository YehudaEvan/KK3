namespace App_Laundry
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namaPelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisCucianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beratperKgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaperKgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uangPembayaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kembalianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalPegambilanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pilihanLayananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoPelangganDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laundryLoginDataSet1 = new App_Laundry.LaundryLoginDataSet1();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.laundryLoginDataSet = new App_Laundry.LaundryLoginDataSet();
            this.laundryLoginDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableAdapter = new App_Laundry.LaundryLoginDataSet1TableAdapters.DataTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryLoginDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryLoginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryLoginDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 77);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::App_Laundry.Properties.Resources.icons8_close_window_24;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(767, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(30, 33);
            this.button7.TabIndex = 1;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 39);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mawar Laundry";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::App_Laundry.Properties.Resources._0_0419142d_f74f_41b0_b56c_bd4cca4f0e26_720_500_jpg;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 711);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaPelangganDataGridViewTextBoxColumn,
            this.jenisCucianDataGridViewTextBoxColumn,
            this.beratperKgDataGridViewTextBoxColumn,
            this.hargaperKgDataGridViewTextBoxColumn,
            this.hargaTotalDataGridViewTextBoxColumn,
            this.uangPembayaranDataGridViewTextBoxColumn,
            this.kembalianDataGridViewTextBoxColumn,
            this.tanggalPegambilanDataGridViewTextBoxColumn,
            this.pilihanLayananDataGridViewTextBoxColumn,
            this.fotoPelangganDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.dataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 403);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(769, 267);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // namaPelangganDataGridViewTextBoxColumn
            // 
            this.namaPelangganDataGridViewTextBoxColumn.DataPropertyName = "Nama_Pelanggan";
            this.namaPelangganDataGridViewTextBoxColumn.HeaderText = "Nama_Pelanggan";
            this.namaPelangganDataGridViewTextBoxColumn.Name = "namaPelangganDataGridViewTextBoxColumn";
            // 
            // jenisCucianDataGridViewTextBoxColumn
            // 
            this.jenisCucianDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Cucian";
            this.jenisCucianDataGridViewTextBoxColumn.HeaderText = "Jenis_Cucian";
            this.jenisCucianDataGridViewTextBoxColumn.Name = "jenisCucianDataGridViewTextBoxColumn";
            // 
            // beratperKgDataGridViewTextBoxColumn
            // 
            this.beratperKgDataGridViewTextBoxColumn.DataPropertyName = "Berat_per_Kg";
            this.beratperKgDataGridViewTextBoxColumn.HeaderText = "Berat_per_Kg";
            this.beratperKgDataGridViewTextBoxColumn.Name = "beratperKgDataGridViewTextBoxColumn";
            // 
            // hargaperKgDataGridViewTextBoxColumn
            // 
            this.hargaperKgDataGridViewTextBoxColumn.DataPropertyName = "Harga_per_Kg";
            this.hargaperKgDataGridViewTextBoxColumn.HeaderText = "Harga_per_Kg";
            this.hargaperKgDataGridViewTextBoxColumn.Name = "hargaperKgDataGridViewTextBoxColumn";
            // 
            // hargaTotalDataGridViewTextBoxColumn
            // 
            this.hargaTotalDataGridViewTextBoxColumn.DataPropertyName = "Harga_Total";
            this.hargaTotalDataGridViewTextBoxColumn.HeaderText = "Harga_Total";
            this.hargaTotalDataGridViewTextBoxColumn.Name = "hargaTotalDataGridViewTextBoxColumn";
            // 
            // uangPembayaranDataGridViewTextBoxColumn
            // 
            this.uangPembayaranDataGridViewTextBoxColumn.DataPropertyName = "Uang_Pembayaran";
            this.uangPembayaranDataGridViewTextBoxColumn.HeaderText = "Uang_Pembayaran";
            this.uangPembayaranDataGridViewTextBoxColumn.Name = "uangPembayaranDataGridViewTextBoxColumn";
            // 
            // kembalianDataGridViewTextBoxColumn
            // 
            this.kembalianDataGridViewTextBoxColumn.DataPropertyName = "Kembalian";
            this.kembalianDataGridViewTextBoxColumn.HeaderText = "Kembalian";
            this.kembalianDataGridViewTextBoxColumn.Name = "kembalianDataGridViewTextBoxColumn";
            // 
            // tanggalPegambilanDataGridViewTextBoxColumn
            // 
            this.tanggalPegambilanDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Pegambilan";
            this.tanggalPegambilanDataGridViewTextBoxColumn.HeaderText = "Tanggal_Pegambilan";
            this.tanggalPegambilanDataGridViewTextBoxColumn.Name = "tanggalPegambilanDataGridViewTextBoxColumn";
            // 
            // pilihanLayananDataGridViewTextBoxColumn
            // 
            this.pilihanLayananDataGridViewTextBoxColumn.DataPropertyName = "Pilihan_Layanan";
            this.pilihanLayananDataGridViewTextBoxColumn.HeaderText = "Pilihan_Layanan";
            this.pilihanLayananDataGridViewTextBoxColumn.Name = "pilihanLayananDataGridViewTextBoxColumn";
            // 
            // fotoPelangganDataGridViewImageColumn
            // 
            this.fotoPelangganDataGridViewImageColumn.DataPropertyName = "Foto_Pelanggan";
            this.fotoPelangganDataGridViewImageColumn.HeaderText = "Foto_Pelanggan";
            this.fotoPelangganDataGridViewImageColumn.Name = "fotoPelangganDataGridViewImageColumn";
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataMember = "Data";
            this.dataBindingSource.DataSource = this.laundryLoginDataSet1;
            // 
            // laundryLoginDataSet1
            // 
            this.laundryLoginDataSet1.DataSetName = "LaundryLoginDataSet1";
            this.laundryLoginDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(375, 306);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 23);
            this.button9.TabIndex = 37;
            this.button9.Text = "Display";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(595, 234);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(146, 23);
            this.button8.TabIndex = 36;
            this.button8.Text = "Browse";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(595, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(613, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Foto Pelanggan";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(132, 67);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(197, 20);
            this.textBox8.TabIndex = 33;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(29, 676);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 32;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(701, 676);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 31;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(713, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = resources.GetString("button4.Text");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(19, 361);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(688, 22);
            this.textBox7.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(666, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Simpan";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(132, 223);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(197, 22);
            this.textBox6.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tanggal Pengambilan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Kembalian";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 192);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 22);
            this.textBox3.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Uang Pembayaran";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(184, 261);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pilihan Layanan";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(462, 68);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 20);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.Text = "Kilat";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(375, 68);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 20);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.Text = "Standard";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(132, 164);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(197, 22);
            this.textBox5.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Harga Total";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(132, 133);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(197, 22);
            this.textBox4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Harga per Kg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jenis Cucian";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 99);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = " Berat per Kg";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Pelanggan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // laundryLoginDataSet
            // 
            this.laundryLoginDataSet.DataSetName = "LaundryLoginDataSet";
            this.laundryLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // laundryLoginDataSetBindingSource
            // 
            this.laundryLoginDataSetBindingSource.DataSource = this.laundryLoginDataSet;
            this.laundryLoginDataSetBindingSource.Position = 0;
            // 
            // dataTableAdapter
            // 
            this.dataTableAdapter.ClearBeforeFill = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryLoginDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryLoginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryLoginDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource laundryLoginDataSetBindingSource;
        private LaundryLoginDataSet laundryLoginDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LaundryLoginDataSet1 laundryLoginDataSet1;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private LaundryLoginDataSet1TableAdapters.DataTableAdapter dataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisCucianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beratperKgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaperKgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uangPembayaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kembalianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalPegambilanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pilihanLayananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoPelangganDataGridViewImageColumn;
    }
}