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
    public partial class frmogrkayit : Form
    {
        public frmogrkayit()
        {
            InitializeComponent();
        }

        sqlbaglantim bgl = new sqlbaglantim();
        private void frmogrkayit_Load(object sender, EventArgs e)
        {
            //bölümleri listeleme komutları 
           
            SqlCommand komut = new SqlCommand("select bolumad from bolumler",bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();// ExecuteReader(); bu paremetlerin okuma işlemini yapıyor ,çalıştırılan öğeleri okusun 
            while (oku.Read())// okuma işi devam etiği sürece 
            {
                cmbxogrbolum.Items.Add(oku[0].ToString());// ekle ne yi ekle oku dan gelen 0 cıdeğeri cmbogrbolum e ekle 
                // burda dizi mantığı olduğu için bolumad sutun bir tane olduğu için 1 tane yaptık iki tane olsaydı oku[1] daha olurdu daha fazlası olsaydı kuralınca devam ederdi  
            }
            bgl.baglanti().Close();

            //boş odaları listeleme komutları 

          
            SqlCommand komut2 = new SqlCommand("select odano from odalar where odakapasite !=odaaktif", bgl.baglanti());// boş odaları getirme ,where odakapasite !=odaaktif
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbogrodano.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //Öğrenci Bilgilerinin kayıt edilme komutları 
            try
            {
                
                SqlCommand komutkaydet = new SqlCommand("insert into ogrenci (ograd,ogrsoyad,ogrtc,ogrtelefon,ogrdogum,ogrbolum,ogrmail,ogrodano,ogrveliadsoyad,ogrvelitelefon,ogrveliadres) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", txtograd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", txtogrsoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", mskogrtc.Text);
                komutkaydet.Parameters.AddWithValue("@p4", mskogrtelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p5", mskogrdogumtarih.Text);
                komutkaydet.Parameters.AddWithValue("@p6", cmbxogrbolum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", txtogrmail.Text);
                komutkaydet.Parameters.AddWithValue("@p8", cmbogrodano.Text);
                komutkaydet.Parameters.AddWithValue("@p9", txtveliadsoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p10", mskvelitelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p11", rchtxtboxadres.Text);
                komutkaydet.ExecuteNonQuery();//sorgular üzerinde değişiklikler yapıyor ve kaydediyor galiba 
                bgl.baglanti().Close();
                MessageBox.Show("KAYIT BAŞARILI BİR ŞEKİLDE EKLENDİ ");

                //Öğrenci İd yi labela çekme
                SqlCommand komut = new SqlCommand("select ogrid from ogrenci", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();// Execute:Uygulamak , Reader:Okuyucu
                while(oku.Read())
                {
                    label12.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();
                //Öğrenci Borç Alanı Oluşturma / Student Debt Area
                SqlCommand komutkaydet2 = new SqlCommand("insert into tblborclar (ogrid,ograd,ogrsoyad) values (@b1,@b2,@b3)", bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label12.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", txtograd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", txtogrsoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();

            }
            catch (Exception) // bi hatta yaz 
            {
                MessageBox.Show("HATTA!!!  Lütfen Tekrar Deneyin ");
                
            }

            //öğrenci oda kontenjanı arttırma 
            SqlCommand komutoda = new SqlCommand("update odalar set odaaktif=odaaktif+1 where odano=@oda1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", cmbogrodano.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();

        }
    }
}
