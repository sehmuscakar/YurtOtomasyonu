﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;// metin belgesi işlemleri giriş cıkış olduğu için bu kütüphane lazım 

namespace YurtOtomasyonu
{
    public partial class frmnotekle : Form
    {
        public frmnotekle()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Kayıt Yeri Seçin";
            saveFileDialog1.Filter = "Metin Dosyası | *.txt";
            saveFileDialog1.InitialDirectory = "C:\\Users\\scaka\\OneDrive\\Masaüstü\\Notlar (yurt otomasyonu)";
            saveFileDialog1.ShowDialog();
            StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
            kaydet.WriteLine(richTextBox1.Text);
            kaydet.Close();
            MessageBox.Show("Kayıt Yapıldı");
        }
    }
}
