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
    public partial class frmogrduzenle : Form
    {

        sqlbaglantim bgl = new sqlbaglantim();
        public frmogrduzenle()
        {
            InitializeComponent();
        }
        public string id,ad,soyad,tc,telefon,dogum,bolum;

       

        private void btnsil_Click(object sender, EventArgs e)
        {
            //odanın aktif öğrenci sayısını azaltma 

            SqlCommand komutoda = new SqlCommand("update odalar set odaaktif=odaaktif-1 where odano=@oda", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda", cmbogrodano.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();




        }

        public string mail, odano, veliad, velitel, adres;
        private void btngüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update ogrenci set ograd=@p2,ogrsoyad=@p3,ogrtc=@p4,ogrtelefon=@p5,ogrdogum=@p6,ogrbolum=@p7,ogrmail=@p8,ogrodano=@p9,ogrveliadsoyad=@p10,ogrvelitelefon=@p11,ogrveliadres=@p12 where ogrid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtogrid.Text);
                komut.Parameters.AddWithValue("@p2", txtograd.Text);
                komut.Parameters.AddWithValue("@p3", txtogrsoyad.Text);
                komut.Parameters.AddWithValue("@p4", mskogrtc.Text);
                komut.Parameters.AddWithValue("@p5", mskogrtelefon.Text);
                komut.Parameters.AddWithValue("@p6", mskogrdogumtarih.Text);
                komut.Parameters.AddWithValue("@p7", cmbxogrbolum.Text);
                komut.Parameters.AddWithValue("@p8", txtogrmail.Text);
                komut.Parameters.AddWithValue("@p9", cmbogrodano.Text);
                komut.Parameters.AddWithValue("@p10", txtveliadsoyad.Text);
                komut.Parameters.AddWithValue("@p11", mskvelitelefon.Text);
                komut.Parameters.AddWithValue("@p12", rchtxtboxadres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata, yeniden deneyin");

            }
        }

        
        private void frmogrduzenle_Load(object sender, EventArgs e)
        {
            txtogrid.Text = id;
            txtograd.Text = ad;
            txtogrsoyad.Text = soyad;
            mskogrtc.Text = tc;
            mskogrtelefon.Text = telefon;
            mskogrdogumtarih.Text = dogum;
            cmbxogrbolum.Text = bolum;
            txtogrmail.Text = mail;
            cmbogrodano.Text = odano;
            txtveliadsoyad.Text = veliad;
            mskvelitelefon.Text = velitel;
            rchtxtboxadres.Text = adres;

            
           
            
        }
    }
}
