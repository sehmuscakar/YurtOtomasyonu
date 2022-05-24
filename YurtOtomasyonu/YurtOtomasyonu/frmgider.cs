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
    public partial class frmgider : Form
    {
        public frmgider()
        {
            InitializeComponent();
        }

        sqlbaglantim bgl = new sqlbaglantim();
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into giderler (elektrik,su,dogalgaz,internet,gıda,personel,diger) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtelektrik.Text);
                komut.Parameters.AddWithValue("@p2", txtsu.Text);
                komut.Parameters.AddWithValue("@p3", txtdogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", txtinternet.Text);
                komut.Parameters.AddWithValue("@p5", txtgida.Text);
                komut.Parameters.AddWithValue("@p6", txtpersonel.Text);
                komut.Parameters.AddWithValue("@p7", txtdiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıtlar Eklendi");


            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu yeniden deneyin");

            }
        }
    }
}
