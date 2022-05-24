using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YurtOtomasyonu
{
    public partial class frmadmingiris : Form
    {
        public frmadmingiris()
        {
            InitializeComponent();
        }
        sqlbaglantim bgl = new sqlbaglantim();
        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from admin where yoneticiad=@p1 and yoneticisifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtkullaniciadi.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                anaform fr = new anaform();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya sifre !!!");
                txtkullaniciadi.Clear();
                txtsifre.Clear();
                txtkullaniciadi.Focus();
            }
            bgl.baglanti().Close();

        }

   
    }
}
