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
    public partial class Devamlilik : Form
    {
        public Devamlilik()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into devamtbl values(@DId,@OgrenciAd,@Durum)", con);
            cnn.Parameters.AddWithValue("@DId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@OgrenciAd", textBox2.Text);
           
            cnn.Parameters.AddWithValue("@Durum", textBox3.Text);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("kayıt başarıyla yapıldı.", "KAYDET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from devamtbl ", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("update devamtbl set OgrenciAd=@OgrenciAd,Durum=@Durum where DId=@DId", con);
            cnn.Parameters.AddWithValue("@DId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@OgrenciAd", textBox2.Text);

            cnn.Parameters.AddWithValue("@Durum", textBox3.Text);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("güncelleme başarıyla yapıldı.", "GÜNCELLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete devamtbl where DId=@DId", con);
            cnn.Parameters.AddWithValue("@DId", int.Parse(textBox1.Text));
          
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("silme başarıyla yapıldı.", "SİL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from devamtbl ", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Devamlilik_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from devamtbl ", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
