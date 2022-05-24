
namespace YurtOtomasyonu
{
    partial class frmogrkayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtograd = new System.Windows.Forms.TextBox();
            this.txtogrsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskogrtc = new System.Windows.Forms.MaskedTextBox();
            this.mskogrtelefon = new System.Windows.Forms.MaskedTextBox();
            this.mskogrdogumtarih = new System.Windows.Forms.MaskedTextBox();
            this.cmbxogrbolum = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtogrmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbogrodano = new System.Windows.Forms.ComboBox();
            this.txtveliadsoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskvelitelefon = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rchtxtboxadres = new System.Windows.Forms.RichTextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ad:";
            // 
            // txtograd
            // 
            this.txtograd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtograd.Location = new System.Drawing.Point(167, 28);
            this.txtograd.Name = "txtograd";
            this.txtograd.Size = new System.Drawing.Size(360, 28);
            this.txtograd.TabIndex = 1;
            // 
            // txtogrsoyad
            // 
            this.txtogrsoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtogrsoyad.Location = new System.Drawing.Point(167, 62);
            this.txtogrsoyad.Name = "txtogrsoyad";
            this.txtogrsoyad.Size = new System.Drawing.Size(360, 28);
            this.txtogrsoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Öğrenci Bölüm:";
            // 
            // mskogrtc
            // 
            this.mskogrtc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mskogrtc.Location = new System.Drawing.Point(167, 96);
            this.mskogrtc.Mask = "00000000000";
            this.mskogrtc.Name = "mskogrtc";
            this.mskogrtc.Size = new System.Drawing.Size(360, 28);
            this.mskogrtc.TabIndex = 12;
            this.mskogrtc.ValidatingType = typeof(int);
            // 
            // mskogrtelefon
            // 
            this.mskogrtelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mskogrtelefon.Location = new System.Drawing.Point(167, 130);
            this.mskogrtelefon.Mask = "(999) 000-0000";
            this.mskogrtelefon.Name = "mskogrtelefon";
            this.mskogrtelefon.Size = new System.Drawing.Size(360, 28);
            this.mskogrtelefon.TabIndex = 13;
            // 
            // mskogrdogumtarih
            // 
            this.mskogrdogumtarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mskogrdogumtarih.Location = new System.Drawing.Point(167, 164);
            this.mskogrdogumtarih.Mask = "00/00/0000";
            this.mskogrdogumtarih.Name = "mskogrdogumtarih";
            this.mskogrdogumtarih.Size = new System.Drawing.Size(360, 28);
            this.mskogrdogumtarih.TabIndex = 14;
            this.mskogrdogumtarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmbxogrbolum
            // 
            this.cmbxogrbolum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbxogrbolum.FormattingEnabled = true;
            this.cmbxogrbolum.Location = new System.Drawing.Point(167, 201);
            this.cmbxogrbolum.Name = "cmbxogrbolum";
            this.cmbxogrbolum.Size = new System.Drawing.Size(360, 30);
            this.cmbxogrbolum.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mail:";
            // 
            // txtogrmail
            // 
            this.txtogrmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtogrmail.Location = new System.Drawing.Point(167, 241);
            this.txtogrmail.Name = "txtogrmail";
            this.txtogrmail.Size = new System.Drawing.Size(360, 28);
            this.txtogrmail.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Oda No:";
            // 
            // cmbogrodano
            // 
            this.cmbogrodano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbogrodano.FormattingEnabled = true;
            this.cmbogrodano.Location = new System.Drawing.Point(167, 280);
            this.cmbogrodano.Name = "cmbogrodano";
            this.cmbogrodano.Size = new System.Drawing.Size(360, 30);
            this.cmbogrodano.TabIndex = 19;
            // 
            // txtveliadsoyad
            // 
            this.txtveliadsoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtveliadsoyad.Location = new System.Drawing.Point(167, 320);
            this.txtveliadsoyad.Name = "txtveliadsoyad";
            this.txtveliadsoyad.Size = new System.Drawing.Size(360, 28);
            this.txtveliadsoyad.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Veli Ad Soyad:";
            // 
            // mskvelitelefon
            // 
            this.mskvelitelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mskvelitelefon.Location = new System.Drawing.Point(167, 354);
            this.mskvelitelefon.Mask = "(999) 000-0000";
            this.mskvelitelefon.Name = "mskvelitelefon";
            this.mskvelitelefon.Size = new System.Drawing.Size(360, 28);
            this.mskvelitelefon.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "Veli Telefon:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(92, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 24);
            this.label11.TabIndex = 24;
            this.label11.Text = "Adres:";
            // 
            // rchtxtboxadres
            // 
            this.rchtxtboxadres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rchtxtboxadres.Location = new System.Drawing.Point(167, 392);
            this.rchtxtboxadres.Name = "rchtxtboxadres";
            this.rchtxtboxadres.Size = new System.Drawing.Size(360, 143);
            this.rchtxtboxadres.TabIndex = 25;
            this.rchtxtboxadres.Text = "";
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnkaydet.Location = new System.Drawing.Point(223, 540);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(235, 57);
            this.btnkaydet.TabIndex = 26;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 24);
            this.label12.TabIndex = 27;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // frmogrkayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(554, 599);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.rchtxtboxadres);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mskvelitelefon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtveliadsoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbogrodano);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtogrmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbxogrbolum);
            this.Controls.Add(this.mskogrdogumtarih);
            this.Controls.Add(this.mskogrtelefon);
            this.Controls.Add(this.mskogrtc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtogrsoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtograd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmogrkayit";
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.frmogrkayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtograd;
        private System.Windows.Forms.TextBox txtogrsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskogrtc;
        private System.Windows.Forms.MaskedTextBox mskogrtelefon;
        private System.Windows.Forms.MaskedTextBox mskogrdogumtarih;
        private System.Windows.Forms.ComboBox cmbxogrbolum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtogrmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbogrodano;
        private System.Windows.Forms.TextBox txtveliadsoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskvelitelefon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rchtxtboxadres;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label12;
    }
}

