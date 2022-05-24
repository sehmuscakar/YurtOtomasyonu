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
    public partial class frmpersonel : Form
    {
        public frmpersonel()
        {
            InitializeComponent();
        }

        sqlbaglantim bgl = new sqlbaglantim();
        private void frmpersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet15.personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.yurtOtomasyonDataSet15.personel);

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into personel (personeladsoyad,personeldepartman) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtpersonelad.Text);
            komut.Parameters.AddWithValue("@p2", txtpersonelgorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Eklendi");
            this.personelTableAdapter.Fill(this.yurtOtomasyonDataSet15.personel);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from personel where personelid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtpersonelid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");
            this.personelTableAdapter.Fill(this.yurtOtomasyonDataSet15.personel);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, gorev, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            gorev = dataGridView1.Rows[secilen].Cells[2].Value.ToString();


            txtpersonelad.Text = ad;
            txtpersonelgorev.Text = gorev;
            txtpersonelid.Text = id;
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutgun = new SqlCommand("update personel set personeladsoyad=@p1,personeldepartman=@p2 where personelid=@p3", bgl.baglanti());
            komutgun.Parameters.AddWithValue("@p1", txtpersonelad.Text);
            komutgun.Parameters.AddWithValue("@p2", txtpersonelgorev.Text);
            komutgun.Parameters.AddWithValue("@p3", txtpersonelid.Text);
            komutgun.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");
            this.personelTableAdapter.Fill(this.yurtOtomasyonDataSet15.personel);
        } 
    }
}
