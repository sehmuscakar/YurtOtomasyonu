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
    public partial class frmbolumler : Form
    {
        public frmbolumler()
        {
            InitializeComponent();
        }
        sqlbaglantim bgl = new sqlbaglantim();
        private void frmbolumler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet.bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet.bolumler); // refresh 

        }

        private void pcrbolumekle_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand komut1 = new SqlCommand("insert into bolumler (bolumad) values (@p1)", bgl.baglanti());//burdan bgl nesnesi aracılığıyla baglanti adresine giti /link via bgl object from here go git
                komut1.Parameters.AddWithValue("@p1", txtbolumad.Text);
                komut1.ExecuteNonQuery();//değişişklikleri kaydet 
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm Eklendi");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet.bolumler);
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu Yeniden Deneyin");
            }
        }

        private void pcrbolumsil_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand komut2 = new SqlCommand("delete from bolumler where bolumid=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtbolumid.Text);// paremetre girecez 
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet.bolumler);
            }
            catch (Exception)
            {

                MessageBox.Show("Hata,işlem gerçekleşmedi");
            }
        }
        int secilen;//hafızaya alınan 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;// bu hafızaya alınan değer 0 inci index herhalde genelikle 
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString(); //bu da id de tıklanınca  0 incı hücre
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString(); //bu da bolumad da tıklanınca 1 inci hücre 

            txtbolumid.Text = id;
            txtbolumad.Text = bolumad;
        }

        private void pcrbolumdüzenle_Click(object sender, EventArgs e)
        {
            try
            {

                
                SqlCommand komut2 = new SqlCommand("update bolumler set bolumad=@p1 where bolumid=@p2", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p2", txtbolumid.Text);
                komut2.Parameters.AddWithValue("@p1", txtbolumad.Text);
                komut2.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Gerçekleşti");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet.bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
                
            }
        }
    }
}
