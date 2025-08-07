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
   

namespace OkulYonetimSistemi
{
    public partial class Ogrenci : Form
    {
        public Ogrenci()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void Ogrenci_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Back)
            {
                dateTimePicker1.CustomFormat = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();
           
            SqlCommand cnn = new SqlCommand("insert into ogrencitab values(@OgrenciId,@OgrenciAd,@Tarih,@Cinsiyet,@Telefon,@Email)",con);
            cnn.Parameters.AddWithValue("@OgrenciId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@OgrenciAd", textBox2.Text);
            cnn.Parameters.AddWithValue("@Tarih", dateTimePicker1.Value); 
            cnn.Parameters.AddWithValue("@Cinsiyet", textBox3.Text);
            cnn.Parameters.AddWithValue("@Telefon", textBox4.Text);
            cnn.Parameters.AddWithValue("@Email", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("kayıt başarıyla yapıldı.", "KAYDET", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from ogrencitab ", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("update ogrencitab set OgrenciAd=@OgrenciAd,Tarih=@Tarih,Cinsiyet=@Cinsiyet,Telefon=@Telefon,Email=@Email where OgrenciId=@OgrenciId", con);
            cnn.Parameters.AddWithValue("@OgrenciId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@OgrenciAd", textBox2.Text);
            cnn.Parameters.AddWithValue("@Tarih", dateTimePicker1.Value);
            cnn.Parameters.AddWithValue("@Cinsiyet", textBox3.Text);
            cnn.Parameters.AddWithValue("@Telefon", textBox4.Text);
            cnn.Parameters.AddWithValue("@Email", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("kayıt güncelleme yapıldı.", "GÜNCELLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete ogrencitab where OgrenciId=@OgrenciId", con);
            cnn.Parameters.AddWithValue("@OgrenciId", int.Parse(textBox1.Text));
            
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("silme başarıyla yapıldı.", "SİL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from ogrencitab ", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Ogrenci_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from ogrencitab ", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
