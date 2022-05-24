using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtomasyonu
{
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }

        private void anaform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet1.ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonDataSet1.ogrenci);
            timer1.Start();// bu form açıldığında başlasın 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();// timer içine yazalım ki ne zamn calıştırsak o zamanı göstersin tarih
            label2.Text = DateTime.Now.ToLongTimeString();// saat ,dk,sn
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");//hesap makinesini açar 
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe"); 
        }

        private void radyo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://radyomuz.medinefm.net:9786/;";//MEDİNE FM radyosu 
        }

        private void radyo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://b01c02nl.mediatriple.net/videoonlylive/mtsxxkzwwuqtglive/broadcast_5fead000e2128.smil/playlist.m3u8";//TGRT FM radyosu 
        }

        private void radyo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://radyo.turkuradyo.net:4591/;"; // TÜRKÜ RADYO radyosu 
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmogrkayit fr = new frmogrkayit();
            fr.Show();
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmogrliste fr = new frmogrliste();
           fr.Show();
        }

     
     
        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbolumler fr = new frmbolumler();
            fr.Show();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbolumler fr = new frmbolumler();
            fr.Show();
        }

        private void öğrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmodemeler fr = new frmodemeler();
            fr.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgider fr = new frmgider();
            fr.Show();
        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgiderlistesi fr = new frmgiderlistesi();
            fr.Show();
        }

        private void gelirİstaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgeliristatistik fr = new frmgeliristatistik();
            fr.Show();
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmyoneticiduzenle fr = new frmyoneticiduzenle();
            fr.Show();
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpersonel fr = new frmpersonel();
            fr.Show();
        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnotekle fr = new frmnotekle();
            fr.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mersin Üniversitesi", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

       
    }
}
