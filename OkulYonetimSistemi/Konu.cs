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
    public partial class Konu : Form
    {
        public Konu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into derstab values(@DersId,@DersAd)", con);
            cnn.Parameters.AddWithValue("@DersId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@DersAd", textBox2.Text);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("kayıt başarıyla yapıldı.", "KAYDET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from derstab ", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("update derstab set DersAd=@DersAd where DersId=@DersId", con);
            cnn.Parameters.AddWithValue("@DersId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@DersAd", textBox2.Text);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("güncelleme başarıyla yapıldı.", "GÜNCELLEME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete derstab where DersId=@DersId", con);
            cnn.Parameters.AddWithValue("@DersId", int.Parse(textBox1.Text));
       
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("silme başarıyla yapıldı.", "SİL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from derstab ", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Konu_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from derstab ", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
