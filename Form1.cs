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


namespace KrediTakipSstm3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        SqlCommand command;
        SqlDataAdapter dataAdapter;

        void MusteriGetir()
        {
            cnn = new SqlConnection("server=DESKTOP-KPKAV02; Initial Catalog=KrediTakipSstm4 ;Integrated Security=SSPI");
            cnn.Open();
            dataAdapter = new SqlDataAdapter("Select*From Musteri", cnn);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            cnn.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MusteriGetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        { 
            string sorgu = "Insert into Musteri(musteri_no,Ad_soyad,TCKN,musteri_segment,musteri_durum,musteri_grup) values (@musteri_no,@Ad_Soyad,@TCKN,@musteri_segment,@musteri_durum,@musteri_grup)";
            command = new SqlCommand(sorgu, cnn);
            command.Parameters.AddWithValue("@musteri_no", textBox1.Text);
            command.Parameters.AddWithValue("@Ad_Soyad", textBox2.Text);
            command.Parameters.AddWithValue("@TCKN", textBox3.Text);
            command.Parameters.AddWithValue("@musteri_segment", comboBox1.Text);
            command.Parameters.AddWithValue("@musteri_durum", comboBox2.Text);
            command.Parameters.AddWithValue("@musteri_grup", textBox4.Text);
            cnn.Open();
            command.ExecuteNonQuery();
            cnn.Close();
            MusteriGetir();

         }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From Musteri Where musteri_no=@musteri_no";
            command = new SqlCommand(sorgu, cnn);
            command.Parameters.AddWithValue("@musteri_no", Convert.ToInt32(textBox1.Text));
            cnn.Open();
            command.ExecuteNonQuery();
            cnn.Close();
            MusteriGetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "Update Musteri Set Ad_Soyad=@Ad_Soyad,TCKN=@TCKN, musteri_segment=@musteri_segment,musteri_durum=@musteri_durum,musteri_grup=@musteri_grup Where musteri_no=@musteri_no";
            command = new SqlCommand(sorgu, cnn);
            command.Parameters.AddWithValue("@musteri_no", Convert.ToInt32(textBox1.Text));
            command.Parameters.AddWithValue("@AD_Soyad", textBox2.Text);
            command.Parameters.AddWithValue("@TCKN", textBox3.Text);
            command.Parameters.AddWithValue("@musteri_segment", comboBox1.Text);
            command.Parameters.AddWithValue("@musteri_durum", comboBox2.Text);
            command.Parameters.AddWithValue("@musteri_grup", textBox4.Text);
            cnn.Open();
            command.ExecuteNonQuery();
            cnn.Close();
            MusteriGetir();
        }
        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
   
}


