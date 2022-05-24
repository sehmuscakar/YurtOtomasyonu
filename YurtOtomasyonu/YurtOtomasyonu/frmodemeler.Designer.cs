
namespace YurtOtomasyonu
{
    partial class frmodemeler
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtogrid = new System.Windows.Forms.TextBox();
            this.txtodenen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkalanborc = new System.Windows.Forms.TextBox();
            this.btnodemeal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrkalanborcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblborclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonDataSet2 = new YurtOtomasyonu.yurtOtomasyonDataSet2();
            this.tblborclarTableAdapter = new YurtOtomasyonu.yurtOtomasyonDataSet2TableAdapters.tblborclarTableAdapter();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtodenenay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblborclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İd:";
            // 
            // txtogrid
            // 
            this.txtogrid.Location = new System.Drawing.Point(149, 110);
            this.txtogrid.Name = "txtogrid";
            this.txtogrid.Size = new System.Drawing.Size(214, 30);
            this.txtogrid.TabIndex = 3;
            // 
            // txtodenen
            // 
            this.txtodenen.Location = new System.Drawing.Point(149, 156);
            this.txtodenen.Name = "txtodenen";
            this.txtodenen.Size = new System.Drawing.Size(214, 30);
            this.txtodenen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ödenen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kalan Borç:";
            // 
            // txtkalanborc
            // 
            this.txtkalanborc.Location = new System.Drawing.Point(149, 201);
            this.txtkalanborc.Name = "txtkalanborc";
            this.txtkalanborc.Size = new System.Drawing.Size(214, 30);
            this.txtkalanborc.TabIndex = 5;
            // 
            // btnodemeal
            // 
            this.btnodemeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnodemeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnodemeal.Location = new System.Drawing.Point(172, 299);
            this.btnodemeal.Name = "btnodemeal";
            this.btnodemeal.Size = new System.Drawing.Size(153, 47);
            this.btnodemeal.TabIndex = 7;
            this.btnodemeal.Text = "Ödeme Al";
            this.btnodemeal.UseVisualStyleBackColor = false;
            this.btnodemeal.Click += new System.EventHandler(this.btnodemeal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogradDataGridViewTextBoxColumn,
            this.ogrsoyadDataGridViewTextBoxColumn,
            this.ogrkalanborcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblborclarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(402, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(786, 339);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "ogrid";
            this.ogridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            // 
            // ogradDataGridViewTextBoxColumn
            // 
            this.ogradDataGridViewTextBoxColumn.DataPropertyName = "ograd";
            this.ogradDataGridViewTextBoxColumn.HeaderText = "ograd";
            this.ogradDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogradDataGridViewTextBoxColumn.Name = "ogradDataGridViewTextBoxColumn";
            // 
            // ogrsoyadDataGridViewTextBoxColumn
            // 
            this.ogrsoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.HeaderText = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrsoyadDataGridViewTextBoxColumn.Name = "ogrsoyadDataGridViewTextBoxColumn";
            // 
            // ogrkalanborcDataGridViewTextBoxColumn
            // 
            this.ogrkalanborcDataGridViewTextBoxColumn.DataPropertyName = "ogrkalanborc";
            this.ogrkalanborcDataGridViewTextBoxColumn.HeaderText = "ogrkalanborc";
            this.ogrkalanborcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrkalanborcDataGridViewTextBoxColumn.Name = "ogrkalanborcDataGridViewTextBoxColumn";
            // 
            // tblborclarBindingSource
            // 
            this.tblborclarBindingSource.DataMember = "tblborclar";
            this.tblborclarBindingSource.DataSource = this.yurtOtomasyonDataSet2;
            // 
            // yurtOtomasyonDataSet2
            // 
            this.yurtOtomasyonDataSet2.DataSetName = "yurtOtomasyonDataSet2";
            this.yurtOtomasyonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblborclarTableAdapter
            // 
            this.tblborclarTableAdapter.ClearBeforeFill = true;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(149, 19);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(214, 30);
            this.txtad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ad:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(149, 65);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(214, 30);
            this.txtsoyad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Soyad:";
            // 
            // txtodenenay
            // 
            this.txtodenenay.Location = new System.Drawing.Point(149, 250);
            this.txtodenenay.Name = "txtodenenay";
            this.txtodenenay.Size = new System.Drawing.Size(214, 30);
            this.txtodenenay.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ödenen Ay:";
            // 
            // frmodemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1192, 358);
            this.Controls.Add(this.txtodenenay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnodemeal);
            this.Controls.Add(this.txtkalanborc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtodenen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtogrid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmodemeler";
            this.Text = "Ödemeler";
            this.Load += new System.EventHandler(this.frmodemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblborclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtogrid;
        private System.Windows.Forms.TextBox txtodenen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkalanborc;
        private System.Windows.Forms.Button btnodemeal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private yurtOtomasyonDataSet2 yurtOtomasyonDataSet2;
        private System.Windows.Forms.BindingSource tblborclarBindingSource;
        private yurtOtomasyonDataSet2TableAdapters.tblborclarTableAdapter tblborclarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrkalanborcDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtodenenay;
        private System.Windows.Forms.Label label6;
    }
}