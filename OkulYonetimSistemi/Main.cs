using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulYonetimSistemi
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Ogrenci st = new Ogrenci();
            st.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Konu sj = new Konu();
            sj.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ogretmen tr = new Ogretmen();
            tr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bolum sn = new Bolum();
            sn.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kayit et = new Kayit();
            et.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Devamlilik ae = new Devamlilik();
            ae.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            KontrolPaneli dd = new KontrolPaneli();
            dd.Show();
        }
    }
}
