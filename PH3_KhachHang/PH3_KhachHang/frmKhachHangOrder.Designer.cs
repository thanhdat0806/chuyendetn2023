namespace PH_KhachHangOrder
{
    partial class frmKhachHangOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHangOrder));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_DichVu = new System.Windows.Forms.ListView();
            this.btn_ODER = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_huyChonMon = new System.Windows.Forms.Button();
            this.btn_ChonMon = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.num_soLuong = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txt_TenDV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxt_Note = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_soLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Coca.png");
            this.imageList1.Images.SetKeyName(1, "BiDao.jpg");
            this.imageList1.Images.SetKeyName(2, "Heineken.jpg");
            this.imageList1.Images.SetKeyName(3, "NuocCam.jpg");
            this.imageList1.Images.SetKeyName(4, "NuocLoc.jpg");
            this.imageList1.Images.SetKeyName(5, "Pepsi.jpg");
            this.imageList1.Images.SetKeyName(6, "RedBull.jpg");
            this.imageList1.Images.SetKeyName(7, "Saigon.jpg");
            this.imageList1.Images.SetKeyName(8, "Sting.jpg");
            this.imageList1.Images.SetKeyName(9, "Tiger.jpg");
            this.imageList1.Images.SetKeyName(10, "HetHang.jpg");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 168);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dịch vụ đã sử dụng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(469, 143);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 25F;
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên dịch vụ ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn Giá";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thành Tiền";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_DichVu);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 197);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh dách dịch vụ";
            // 
            // lst_DichVu
            // 
            this.lst_DichVu.BackColor = System.Drawing.SystemColors.Info;
            this.lst_DichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_DichVu.HideSelection = false;
            this.lst_DichVu.LargeImageList = this.imageList1;
            this.lst_DichVu.Location = new System.Drawing.Point(3, 16);
            this.lst_DichVu.Name = "lst_DichVu";
            this.lst_DichVu.Size = new System.Drawing.Size(475, 178);
            this.lst_DichVu.TabIndex = 1;
            this.lst_DichVu.UseCompatibleStateImageBehavior = false;
            this.lst_DichVu.Click += new System.EventHandler(this.lst_DichVu_Click);
            // 
            // btn_ODER
            // 
            this.btn_ODER.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_ODER.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ODER.Location = new System.Drawing.Point(1060, 385);
            this.btn_ODER.Name = "btn_ODER";
            this.btn_ODER.Size = new System.Drawing.Size(135, 68);
            this.btn_ODER.TabIndex = 12;
            this.btn_ODER.Text = "Xác nhận Order";
            this.btn_ODER.UseVisualStyleBackColor = false;
            this.btn_ODER.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column6});
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(470, 287);
            this.dataGridView2.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên dịch vụ ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Note";
            this.Column6.Name = "Column6";
            // 
            // btn_huyChonMon
            // 
            this.btn_huyChonMon.BackColor = System.Drawing.Color.Red;
            this.btn_huyChonMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huyChonMon.Location = new System.Drawing.Point(893, 385);
            this.btn_huyChonMon.Name = "btn_huyChonMon";
            this.btn_huyChonMon.Size = new System.Drawing.Size(131, 68);
            this.btn_huyChonMon.TabIndex = 25;
            this.btn_huyChonMon.Text = "Hủy Món";
            this.btn_huyChonMon.UseVisualStyleBackColor = false;
            this.btn_huyChonMon.Click += new System.EventHandler(this.btn_huyChonMon_Click);
            // 
            // btn_ChonMon
            // 
            this.btn_ChonMon.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ChonMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonMon.Location = new System.Drawing.Point(719, 385);
            this.btn_ChonMon.Name = "btn_ChonMon";
            this.btn_ChonMon.Size = new System.Drawing.Size(130, 68);
            this.btn_ChonMon.TabIndex = 24;
            this.btn_ChonMon.Text = "Thêm món";
            this.btn_ChonMon.UseVisualStyleBackColor = false;
            this.btn_ChonMon.Click += new System.EventHandler(this.btn_ChonMon_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(719, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 319);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dịch vụ đã chọn";
            // 
            // num_soLuong
            // 
            this.num_soLuong.Location = new System.Drawing.Point(577, 217);
            this.num_soLuong.Name = "num_soLuong";
            this.num_soLuong.Size = new System.Drawing.Size(120, 20);
            this.num_soLuong.TabIndex = 35;
            this.num_soLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Đơn Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Đơn vị tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tên dịch vụ";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(577, 168);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(120, 20);
            this.txtDonViTinh.TabIndex = 28;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(577, 118);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(120, 20);
            this.txtDonGia.TabIndex = 29;
            // 
            // txt_TenDV
            // 
            this.txt_TenDV.Location = new System.Drawing.Point(577, 76);
            this.txt_TenDV.Name = "txt_TenDV";
            this.txt_TenDV.Size = new System.Drawing.Size(120, 20);
            this.txt_TenDV.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Số lượng";
            // 
            // rtxt_Note
            // 
            this.rtxt_Note.Location = new System.Drawing.Point(577, 263);
            this.rtxt_Note.Name = "rtxt_Note";
            this.rtxt_Note.Size = new System.Drawing.Size(120, 51);
            this.rtxt_Note.TabIndex = 36;
            this.rtxt_Note.Text = "";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1235, 57);
            this.label7.TabIndex = 37;
            this.label7.Text = "MENU";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1235, 465);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtxt_Note);
            this.Controls.Add(this.num_soLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txt_TenDV);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_huyChonMon);
            this.Controls.Add(this.btn_ChonMon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ODER);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKhachHangOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_soLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();



            this.comboBoxPhongHat = new System.Windows.Forms.ComboBox();
            this.btnThayDoiMaPH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxPhongHat
            // 
            this.comboBoxPhongHat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPhongHat.FormattingEnabled = true;
            this.comboBoxPhongHat.Location = new System.Drawing.Point(12, 12);
            this.comboBoxPhongHat.Name = "comboBoxPhongHat";
            this.comboBoxPhongHat.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPhongHat.TabIndex = 0;
            this.comboBoxPhongHat.SelectedIndexChanged += new System.EventHandler(this.comboBoxPhongHat_SelectedIndexChanged);
            // 
            // btnThayDoiMaPH
            // 
            this.btnThayDoiMaPH.Location = new System.Drawing.Point(12, 50);
            this.btnThayDoiMaPH.Name = "btnThayDoiMaPH";
            this.btnThayDoiMaPH.Size = new System.Drawing.Size(100, 23);
            this.btnThayDoiMaPH.TabIndex = 1;
            this.btnThayDoiMaPH.Text = "Thay đổi MaPH";
            this.btnThayDoiMaPH.UseVisualStyleBackColor = true;
            this.btnThayDoiMaPH.Click += new System.EventHandler(this.btnThayDoiMaPH_Click);
            // 
            // frmKhachHangOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 85);
            this.Controls.Add(this.btnThayDoiMaPH);
            this.Controls.Add(this.comboBoxPhongHat);
            this.Name = "frmKhachHangOrder";
            //this.TxtKH = "Khach Hang Order";
            this.Load += new System.EventHandler(this.frmKhachHangOrder_Load);
            this.ResumeLayout(false);


        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ODER;
        private System.Windows.Forms.ListView lst_DichVu;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_huyChonMon;
        private System.Windows.Forms.Button btn_ChonMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown num_soLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txt_TenDV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxt_Note;
        private System.Windows.Forms.Label label7;



        private System.Windows.Forms.ComboBox comboBoxPhongHat;
        private System.Windows.Forms.Button btnThayDoiMaPH;
        //private System.Windows.Forms.TextBox TxtKH;
    }
}