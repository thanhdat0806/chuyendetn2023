
namespace DoAn_QL_Karaoke
{
    partial class Frm_ThongKeDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ThongKeDoanhThu));
            this.dpk_ngaycuoi = new System.Windows.Forms.DateTimePicker();
            this.dpk_ngaydau = new System.Windows.Forms.DateTimePicker();
            this.btn_DT = new System.Windows.Forms.Button();
            this.dBQLKaraokeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_QLKaraokeDataSet = new DoAn_QL_Karaoke.DB_QLKaraokeDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dBQLKaraokeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLKaraokeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // dpk_ngaycuoi
            // 
            this.dpk_ngaycuoi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpk_ngaycuoi.Location = new System.Drawing.Point(108, 72);
            this.dpk_ngaycuoi.Name = "dpk_ngaycuoi";
            this.dpk_ngaycuoi.Size = new System.Drawing.Size(174, 20);
            this.dpk_ngaycuoi.TabIndex = 12;
            // 
            // dpk_ngaydau
            // 
            this.dpk_ngaydau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpk_ngaydau.Location = new System.Drawing.Point(108, 40);
            this.dpk_ngaydau.Name = "dpk_ngaydau";
            this.dpk_ngaydau.Size = new System.Drawing.Size(174, 20);
            this.dpk_ngaydau.TabIndex = 13;
            this.dpk_ngaydau.Value = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            // 
            // btn_DT
            // 
            this.btn_DT.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_DT.Location = new System.Drawing.Point(31, 101);
            this.btn_DT.Name = "btn_DT";
            this.btn_DT.Size = new System.Drawing.Size(251, 23);
            this.btn_DT.TabIndex = 14;
            this.btn_DT.Text = "Xem Doanh Thu";
            this.btn_DT.UseVisualStyleBackColor = false;
            this.btn_DT.Click += new System.EventHandler(this.btn_DT_Click);
            // 
            // dBQLKaraokeDataSetBindingSource
            // 
            this.dBQLKaraokeDataSetBindingSource.DataSource = this.dB_QLKaraokeDataSet;
            this.dBQLKaraokeDataSetBindingSource.Position = 0;
            // 
            // dB_QLKaraokeDataSet
            // 
            this.dB_QLKaraokeDataSet.DataSetName = "DB_QLKaraokeDataSet";
            this.dB_QLKaraokeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(31, 130);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 15;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(251, 437);
            this.dataGridView2.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Từ Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(35, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "Đến Ngày";
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(339, 40);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tong";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(489, 216);
            this.chart1.TabIndex = 97;
            this.chart1.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(485, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 13);
            this.label3.TabIndex = 98;
            this.label3.Text = "Biểu Đồ Thống Kê Doanh Thu Theo Ngày";
            // 
            // chart2
            // 
            this.chart2.BorderlineColor = System.Drawing.Color.Black;
            this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart2.BorderlineWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(339, 291);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Tong";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(489, 260);
            this.chart2.TabIndex = 104;
            this.chart2.Text = "chart2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(485, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 13);
            this.label5.TabIndex = 106;
            this.label5.Text = "Biểu Đồ Thống Kê Doanh Thu Theo Phòng Hát";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(861, 30);
            this.label6.TabIndex = 107;
            this.label6.Text = "THỐNG KÊ DOANH THU";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 80F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 120F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tổng Tiền (x1000 vnđ)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Frm_ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(861, 581);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_DT);
            this.Controls.Add(this.dpk_ngaydau);
            this.Controls.Add(this.dpk_ngaycuoi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ThongKeDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Doanh Thu";
            this.Load += new System.EventHandler(this.Frm_ThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBQLKaraokeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLKaraokeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dpk_ngaycuoi;
        private System.Windows.Forms.DateTimePicker dpk_ngaydau;
        private System.Windows.Forms.Button btn_DT;
        private System.Windows.Forms.BindingSource dBQLKaraokeDataSetBindingSource;
        private DB_QLKaraokeDataSet dB_QLKaraokeDataSet;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}