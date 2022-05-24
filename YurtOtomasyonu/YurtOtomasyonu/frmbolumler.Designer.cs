
namespace YurtOtomasyonu
{
    partial class frmbolumler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbolumler));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbolumid = new System.Windows.Forms.TextBox();
            this.pcrbolumekle = new System.Windows.Forms.PictureBox();
            this.pcrbolumsil = new System.Windows.Forms.PictureBox();
            this.pcrbolumdüzenle = new System.Windows.Forms.PictureBox();
            this.txtbolumad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonDataSet = new YurtOtomasyonu.yurtOtomasyonDataSet();
            this.bolumlerTableAdapter = new YurtOtomasyonu.yurtOtomasyonDataSetTableAdapters.bolumlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcrbolumekle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrbolumsil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrbolumdüzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm İd:";
            // 
            // txtbolumid
            // 
            this.txtbolumid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtbolumid.Enabled = false;
            this.txtbolumid.Location = new System.Drawing.Point(135, 33);
            this.txtbolumid.Name = "txtbolumid";
            this.txtbolumid.Size = new System.Drawing.Size(245, 28);
            this.txtbolumid.TabIndex = 1;
            // 
            // pcrbolumekle
            // 
            this.pcrbolumekle.Image = ((System.Drawing.Image)(resources.GetObject("pcrbolumekle.Image")));
            this.pcrbolumekle.Location = new System.Drawing.Point(426, 12);
            this.pcrbolumekle.Name = "pcrbolumekle";
            this.pcrbolumekle.Size = new System.Drawing.Size(140, 94);
            this.pcrbolumekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrbolumekle.TabIndex = 2;
            this.pcrbolumekle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcrbolumekle, "Bölüm Ekle");
            this.pcrbolumekle.Click += new System.EventHandler(this.pcrbolumekle_Click);
            // 
            // pcrbolumsil
            // 
            this.pcrbolumsil.Image = ((System.Drawing.Image)(resources.GetObject("pcrbolumsil.Image")));
            this.pcrbolumsil.Location = new System.Drawing.Point(584, 12);
            this.pcrbolumsil.Name = "pcrbolumsil";
            this.pcrbolumsil.Size = new System.Drawing.Size(128, 94);
            this.pcrbolumsil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrbolumsil.TabIndex = 3;
            this.pcrbolumsil.TabStop = false;
            this.toolTip1.SetToolTip(this.pcrbolumsil, "Bölüm Sil");
            this.pcrbolumsil.Click += new System.EventHandler(this.pcrbolumsil_Click);
            // 
            // pcrbolumdüzenle
            // 
            this.pcrbolumdüzenle.Image = ((System.Drawing.Image)(resources.GetObject("pcrbolumdüzenle.Image")));
            this.pcrbolumdüzenle.Location = new System.Drawing.Point(501, 122);
            this.pcrbolumdüzenle.Name = "pcrbolumdüzenle";
            this.pcrbolumdüzenle.Size = new System.Drawing.Size(133, 97);
            this.pcrbolumdüzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrbolumdüzenle.TabIndex = 4;
            this.pcrbolumdüzenle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcrbolumdüzenle, "Bölüm Günecelle");
            this.pcrbolumdüzenle.Click += new System.EventHandler(this.pcrbolumdüzenle_Click);
            // 
            // txtbolumad
            // 
            this.txtbolumad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtbolumad.Location = new System.Drawing.Point(135, 78);
            this.txtbolumad.Name = "txtbolumad";
            this.txtbolumad.Size = new System.Drawing.Size(245, 28);
            this.txtbolumad.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bölüm Ad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bolumadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(747, 248);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "bolumid";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "bolumid";
            this.bolumidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            this.bolumidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bolumidDataGridViewTextBoxColumn.Width = 347;
            // 
            // bolumadDataGridViewTextBoxColumn
            // 
            this.bolumadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumadDataGridViewTextBoxColumn.DataPropertyName = "bolumad";
            this.bolumadDataGridViewTextBoxColumn.HeaderText = "bolumad";
            this.bolumadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumadDataGridViewTextBoxColumn.Name = "bolumadDataGridViewTextBoxColumn";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtOtomasyonDataSet;
            // 
            // yurtOtomasyonDataSet
            // 
            this.yurtOtomasyonDataSet.DataSetName = "yurtOtomasyonDataSet";
            this.yurtOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // frmbolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(749, 484);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbolumad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcrbolumdüzenle);
            this.Controls.Add(this.pcrbolumsil);
            this.Controls.Add(this.pcrbolumekle);
            this.Controls.Add(this.txtbolumid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmbolumler";
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.frmbolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcrbolumekle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrbolumsil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrbolumdüzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbolumid;
        private System.Windows.Forms.PictureBox pcrbolumekle;
        private System.Windows.Forms.PictureBox pcrbolumsil;
        private System.Windows.Forms.PictureBox pcrbolumdüzenle;
        private System.Windows.Forms.TextBox txtbolumad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private yurtOtomasyonDataSet yurtOtomasyonDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private yurtOtomasyonDataSetTableAdapters.bolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumadDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}