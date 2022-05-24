using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace YurtOtomasyonu
{
    public partial class frmgiderguncelle : Form
    {
        public frmgiderguncelle()
        {
            InitializeComponent();
        }
        public string elektrik, su, dogalgaz, gida, diger, internet, personel,id;

        sqlbaglantim bgl = new sqlbaglantim();
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update giderler set elektrik=@p1,su=@p2,dogalgaz=@p3,internet=@p4,gıda=@p5,personel=@p6,diger=@p7 where odemeid=@p8", bgl.baglanti());
                komut.Parameters.AddWithValue("@p8", txtgiderid.Text);
                komut.Parameters.AddWithValue("@p1", txtelektrik.Text);
                komut.Parameters.AddWithValue("@p2", txtsu.Text);
                komut.Parameters.AddWithValue("@p3", txtdogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", txtinternet.Text);
                komut.Parameters.AddWithValue("@p5", txtgida.Text);
                komut.Parameters.AddWithValue("@p6", txtpersonel.Text);
                komut.Parameters.AddWithValue("@p7", txtdiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Yapıldı");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu yeniden deneyin ");
               
            }
        }

        private void frmgiderguncelle_Load(object sender, EventArgs e)
        {
            txtgiderid.Text = id;
            txtelektrik.Text = elektrik;
            txtgida.Text = gida;
            txtsu.Text = su;
            txtpersonel.Text = personel;
            txtinternet.Text = internet;
            txtdogalgaz.Text = dogalgaz;
            txtdiger.Text = diger;
            

        }
    }
}
