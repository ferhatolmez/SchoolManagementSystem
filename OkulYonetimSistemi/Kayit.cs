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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker2.CustomFormat = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into kayittbl values(@KId,@OgrenciAd,@Bolum,@KayitTarihi)", con);
            cnn.Parameters.AddWithValue("@KId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@OgrenciAd", textBox2.Text);
            cnn.Parameters.AddWithValue("@KayitTarihi", dateTimePicker2.Value);
            cnn.Parameters.AddWithValue("@Bolum", textBox3.Text);
 
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("kayıt başarıyla yapıldı.", "KAYDET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from kayittbl ", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("update kayittbl set OgrenciAd=@OgrenciAd,Bolum=@Bolum,KayitTarihi=@KayitTarihi where  KId=@KId", con);
            cnn.Parameters.AddWithValue("@KId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@OgrenciAd", textBox2.Text);
            cnn.Parameters.AddWithValue("@KayitTarihi", dateTimePicker2.Value);
            cnn.Parameters.AddWithValue("@Bolum", textBox3.Text);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("güncelleme başarıyla yapıldı.", "GÜNCELLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete kayittbl where KId=@KId", con);
            cnn.Parameters.AddWithValue("@KId", int.Parse(textBox1.Text));
            

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

            SqlCommand cnn = new SqlCommand("select * from kayittbl ", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from kayittbl ", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
