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
    public partial class Form2 : Form
    {
        public Form2()
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
            dataAdapter = new SqlDataAdapter("Select*From Kredi", cnn);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            cnn.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            MusteriGetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into Kredi(kredi_Vkn,musteri_no,nace_anasektör,urun_ad,risk_turu,doviz_turu,gecikme_gün) values (@kredi_Vkn,@musteri_no,@nace_anasektör,@urun_ad,@risk_turu,@doviz_turu,@gecikme_gün)";
            command = new SqlCommand(sorgu, cnn);
            command.Parameters.AddWithValue("@musteri_no", textBox1.Text);
            command.Parameters.AddWithValue("@kredi_Vkn", textBox2.Text);
            command.Parameters.AddWithValue("@nace_anasektör", comboBox1.Text);
            command.Parameters.AddWithValue("@urun_ad", comboBox2.Text);
            command.Parameters.AddWithValue("@risk_turu", comboBox3.Text);
            command.Parameters.AddWithValue("@doviz_turu", comboBox4.Text);
            command.Parameters.AddWithValue("@gecikme_gün", textBox3.Text);
            cnn.Open();
            command.ExecuteNonQuery();
            cnn.Close();
            MusteriGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From Kredi Where musteri_no=@musteri_no";
            command = new SqlCommand(sorgu, cnn);
            command.Parameters.AddWithValue("@musteri_no", Convert.ToInt32(textBox1.Text));
            cnn.Open();
            command.ExecuteNonQuery();
            cnn.Close();
            MusteriGetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand command = new SqlCommand("Update Kredi Set musteri_no=@musteri_no, kredi_Vkn=@kredi_Vkn,nace_anasektör=@nace_anasektör, urun_ad=@urun_ad,risk_turu=@risk_turu,doviz_turu=@doviz_turu,gecikme_gün=@gecikme_gün Where musteri_no=@musteri_no", cnn);
            command.Parameters.AddWithValue("@musteri_no", Convert.ToInt32(textBox1.Text));
            command.Parameters.AddWithValue("@kredi_Vkn", textBox2.Text);
            command.Parameters.AddWithValue("@nace_anasektör", comboBox1.Text);
            command.Parameters.AddWithValue("@urun_ad", comboBox2.Text);
            command.Parameters.AddWithValue("@risk_turu", comboBox3.Text);
            command.Parameters.AddWithValue("@doviz_turu", comboBox4.Text);
            command.Parameters.AddWithValue("@gecikme_gün", textBox3.Text);
            command.ExecuteNonQuery();
            cnn.Close();
            MusteriGetir();
        }

        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";     
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
