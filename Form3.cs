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
    public partial class Form3 : Form
    {
        public Form3()
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
            dataAdapter = new SqlDataAdapter("Select*From Cekilen", cnn);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            cnn.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            MusteriGetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into Cekilen(musteri_no,miktar,sube_id,tarih) values (@musteri_no,@miktar,@sube_id,@tarih)";
            command = new SqlCommand(sorgu, cnn);
            command.Parameters.AddWithValue("@musteri_no", textBox1.Text);
            command.Parameters.AddWithValue("@miktar", textBox2.Text);
            command.Parameters.AddWithValue("@sube_id", textBox3.Text);
            command.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
            cnn.Open();
            command.ExecuteNonQuery();
            cnn.Close();
            MusteriGetir();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From Cekilen Where musteri_no=@musteri_no";
            command = new SqlCommand(sorgu, cnn);
            command.Parameters.AddWithValue("@musteri_no", Convert.ToInt32(textBox1.Text));
            cnn.Open();
            command.ExecuteNonQuery();
            cnn.Close();
            MusteriGetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "Update into Cekilen Set musteri_no=@musteri_no, miktar=@miktar, sube_id=@sube_id, tarih=@tarih";
            command = new SqlCommand(sorgu, cnn);
            command.Parameters.AddWithValue("@musteri_no", Convert.ToInt32(textBox1));
            command.Parameters.AddWithValue("@miktar", textBox2.Text);
            command.Parameters.AddWithValue("@sube_id", textBox3.Text);
            command.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
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
            dateTimePicker1.Text = "";
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
