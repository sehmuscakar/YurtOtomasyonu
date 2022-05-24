
namespace YurtOtomasyonu
{
    partial class frmogrliste
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrdogumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrbolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrodanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrveliadsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrvelitelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrveliadresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonDataSet3 = new YurtOtomasyonu.yurtOtomasyonDataSet3();
            this.ogrenciTableAdapter = new YurtOtomasyonu.yurtOtomasyonDataSet3TableAdapters.ogrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogradDataGridViewTextBoxColumn,
            this.ogrsoyadDataGridViewTextBoxColumn,
            this.ogrtcDataGridViewTextBoxColumn,
            this.ogrtelefonDataGridViewTextBoxColumn,
            this.ogrdogumDataGridViewTextBoxColumn,
            this.ogrbolumDataGridViewTextBoxColumn,
            this.ogrmailDataGridViewTextBoxColumn,
            this.ogrodanoDataGridViewTextBoxColumn,
            this.ogrveliadsoyadDataGridViewTextBoxColumn,
            this.ogrvelitelefonDataGridViewTextBoxColumn,
            this.ogrveliadresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1608, 367);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "ogrid";
            this.ogridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogridDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogradDataGridViewTextBoxColumn
            // 
            this.ogradDataGridViewTextBoxColumn.DataPropertyName = "ograd";
            this.ogradDataGridViewTextBoxColumn.HeaderText = "ograd";
            this.ogradDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogradDataGridViewTextBoxColumn.Name = "ogradDataGridViewTextBoxColumn";
            this.ogradDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrsoyadDataGridViewTextBoxColumn
            // 
            this.ogrsoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.HeaderText = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrsoyadDataGridViewTextBoxColumn.Name = "ogrsoyadDataGridViewTextBoxColumn";
            this.ogrsoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrtcDataGridViewTextBoxColumn
            // 
            this.ogrtcDataGridViewTextBoxColumn.DataPropertyName = "ogrtc";
            this.ogrtcDataGridViewTextBoxColumn.HeaderText = "ogrtc";
            this.ogrtcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrtcDataGridViewTextBoxColumn.Name = "ogrtcDataGridViewTextBoxColumn";
            this.ogrtcDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrtelefonDataGridViewTextBoxColumn
            // 
            this.ogrtelefonDataGridViewTextBoxColumn.DataPropertyName = "ogrtelefon";
            this.ogrtelefonDataGridViewTextBoxColumn.HeaderText = "ogrtelefon";
            this.ogrtelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrtelefonDataGridViewTextBoxColumn.Name = "ogrtelefonDataGridViewTextBoxColumn";
            this.ogrtelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrdogumDataGridViewTextBoxColumn
            // 
            this.ogrdogumDataGridViewTextBoxColumn.DataPropertyName = "ogrdogum";
            this.ogrdogumDataGridViewTextBoxColumn.HeaderText = "ogrdogum";
            this.ogrdogumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrdogumDataGridViewTextBoxColumn.Name = "ogrdogumDataGridViewTextBoxColumn";
            this.ogrdogumDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrbolumDataGridViewTextBoxColumn
            // 
            this.ogrbolumDataGridViewTextBoxColumn.DataPropertyName = "ogrbolum";
            this.ogrbolumDataGridViewTextBoxColumn.HeaderText = "ogrbolum";
            this.ogrbolumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrbolumDataGridViewTextBoxColumn.Name = "ogrbolumDataGridViewTextBoxColumn";
            this.ogrbolumDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrmailDataGridViewTextBoxColumn
            // 
            this.ogrmailDataGridViewTextBoxColumn.DataPropertyName = "ogrmail";
            this.ogrmailDataGridViewTextBoxColumn.HeaderText = "ogrmail";
            this.ogrmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrmailDataGridViewTextBoxColumn.Name = "ogrmailDataGridViewTextBoxColumn";
            this.ogrmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrodanoDataGridViewTextBoxColumn
            // 
            this.ogrodanoDataGridViewTextBoxColumn.DataPropertyName = "ogrodano";
            this.ogrodanoDataGridViewTextBoxColumn.HeaderText = "ogrodano";
            this.ogrodanoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrodanoDataGridViewTextBoxColumn.Name = "ogrodanoDataGridViewTextBoxColumn";
            this.ogrodanoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrveliadsoyadDataGridViewTextBoxColumn
            // 
            this.ogrveliadsoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrveliadsoyad";
            this.ogrveliadsoyadDataGridViewTextBoxColumn.HeaderText = "ogrveliadsoyad";
            this.ogrveliadsoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrveliadsoyadDataGridViewTextBoxColumn.Name = "ogrveliadsoyadDataGridViewTextBoxColumn";
            this.ogrveliadsoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrvelitelefonDataGridViewTextBoxColumn
            // 
            this.ogrvelitelefonDataGridViewTextBoxColumn.DataPropertyName = "ogrvelitelefon";
            this.ogrvelitelefonDataGridViewTextBoxColumn.HeaderText = "ogrvelitelefon";
            this.ogrvelitelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrvelitelefonDataGridViewTextBoxColumn.Name = "ogrvelitelefonDataGridViewTextBoxColumn";
            this.ogrvelitelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrveliadresDataGridViewTextBoxColumn
            // 
            this.ogrveliadresDataGridViewTextBoxColumn.DataPropertyName = "ogrveliadres";
            this.ogrveliadresDataGridViewTextBoxColumn.HeaderText = "ogrveliadres";
            this.ogrveliadresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrveliadresDataGridViewTextBoxColumn.Name = "ogrveliadresDataGridViewTextBoxColumn";
            this.ogrveliadresDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtOtomasyonDataSet3;
            // 
            // yurtOtomasyonDataSet3
            // 
            this.yurtOtomasyonDataSet3.DataSetName = "yurtOtomasyonDataSet3";
            this.yurtOtomasyonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // frmogrliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1608, 367);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmogrliste";
            this.Text = "Öğrenci Liste";
            this.Load += new System.EventHandler(this.frmogrliste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private yurtOtomasyonDataSet3 yurtOtomasyonDataSet3;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private yurtOtomasyonDataSet3TableAdapters.ogrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrdogumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrbolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrodanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrveliadsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrvelitelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrveliadresDataGridViewTextBoxColumn;
    }
}