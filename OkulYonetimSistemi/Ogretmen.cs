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
    public partial class Ogretmen : Form
    {
        public Ogretmen()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into ogretmentab values(@OgretmenId,@OgretmenAd,@Cinsiyet,@Telefon)", con);
            cnn.Parameters.AddWithValue("@OgretmenId", int.Parse(textBox4.Text));
            cnn.Parameters.AddWithValue("@OgretmenAd", textBox3.Text);
            cnn.Parameters.AddWithValue("@Cinsiyet", textBox5.Text);
            cnn.Parameters.AddWithValue("@Telefon", textBox6.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("kayıt başarıyla yapıldı.", "KAYDET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from ogretmentab ", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("update ogretmentab set OgretmenAd=@OgretmenAd,Cinsiyet=@Cinsiyet,Telefon=@Telefon where OgretmenId=@OgretmenId", con);
            cnn.Parameters.AddWithValue("@OgretmenId", int.Parse(textBox4.Text));
            cnn.Parameters.AddWithValue("@OgretmenAd", textBox3.Text);
            cnn.Parameters.AddWithValue("@Cinsiyet", textBox5.Text);
            cnn.Parameters.AddWithValue("@Telefon", textBox6.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("güncelleme başarıyla yapıldı.", "GÜNCELLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete ogretmentab where OgretmenId=@OgretmenId", con);
            cnn.Parameters.AddWithValue("@OgretmenId", int.Parse(textBox4.Text));
   
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("silme başarıyla yapıldı.", "SİL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from ogretmentab ", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Ogretmen_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from ogretmentab ", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
