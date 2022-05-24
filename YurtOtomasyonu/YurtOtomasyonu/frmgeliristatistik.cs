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
    public partial class frmgeliristatistik : Form
    {
        public frmgeliristatistik()
        {
            InitializeComponent();
        }
        sqlbaglantim bgl = new sqlbaglantim();
        private void frmgeliristatistik_Load(object sender, EventArgs e)
        {
            // kasada ki toplam tutar 
            SqlCommand komut = new SqlCommand("select sum (odememiktar) from kasa", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblpara.Text = oku[0].ToString() +" TL ";
            }
            bgl.baglanti().Close();

            //tekrarsız olarak ayları listeleme 
            SqlCommand komut2 = new SqlCommand("select distinct (odemeay) from kasa", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbay.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

            // grafiklere veri tabanından veri çekme 
            SqlCommand komut3 = new SqlCommand("select odemeay,sum(odememiktar) from kasa group by odemeay", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0], oku3[1]);
            }
            bgl.baglanti().Close();

        }

        private void cmbay_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select sum(odememiktar) from kasa where odemeay=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbay.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblaykazanç.Text = oku[0].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
