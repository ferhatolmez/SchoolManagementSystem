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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEROLOGY\FERHADD;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();
            string kullaniciadi = txtUsername.Text;
            string Sifre = txtPassword.Text;
            SqlCommand cnn = new SqlCommand("select KullaniciAdi,Sifre from giristab where KullaniciAdi= '" + txtUsername.Text + "' and Sifre= '" + txtPassword.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                Main mn = new Main();
                mn.Show();

            }
            else
            {
                MessageBox.Show("geçersiz kullanıcı adı veya şifre");
            }
            con.Close();
        }
    }
}
