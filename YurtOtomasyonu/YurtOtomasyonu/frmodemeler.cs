using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YurtOtomasyonu
{
    public partial class frmodemeler : Form
    {
        public frmodemeler()
        {
            InitializeComponent();
        }
        sqlbaglantim bgl = new sqlbaglantim();
        private void frmodemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet2.tblborclar' table. You can move, or remove it, as needed.
            this.tblborclarTableAdapter.Fill(this.yurtOtomasyonDataSet2.tblborclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            txtad.Text = ad;
            txtsoyad.Text = soyad;
            txtkalanborc.Text = kalan;
            txtogrid.Text = id;

        }

        private void btnodemeal_Click(object sender, EventArgs e)
        {

            //ödenen tutarı kalan tutardan düşme
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt32(txtodenen.Text);
            kalan = Convert.ToInt32(txtkalanborc.Text);
            yeniborc = kalan - odenen;
            txtkalanborc.Text = yeniborc.ToString();

            //yeni tutarı veri tabanına kaydetme 
            SqlCommand komut = new SqlCommand("update tblborclar set ogrkalanborc=@p1 where ogrid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", txtogrid.Text);
            komut.Parameters.AddWithValue("@p1", txtkalanborc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Ödendi");
            this.tblborclarTableAdapter.Fill(this.yurtOtomasyonDataSet2.tblborclar);

            //kasa tablosuna ekleme yapma 
            SqlCommand komut2 = new SqlCommand("insert into kasa (odemeay,odememiktar) values (@k1,@k2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1", txtodenenay.Text);
            komut2.Parameters.AddWithValue("@k2", txtodenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
