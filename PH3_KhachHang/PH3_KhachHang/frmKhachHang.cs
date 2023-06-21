using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH3_KhachHang
{
    public partial class frmKhachHang : Form
    {
        XyLyDatabase db = new XyLyDatabase();
        DataTable dtGetMaTP, dtGetMaDV, dtGetDonGiaDV,dtGetSL;
        DataTable dtdichvu, dtchitietdichvu, dtchitietdichvu1;
        DataColumn[] keyDV = new DataColumn[1];
        DateTime TGHienTai = DateTime.Now;
        ListViewItem lsv_Item;
        int Flat = 0;
        int a = 0;
        string MaPhongHat, MaThuePhong, TenDichVu;
        public frmKhachHang(string MaPH)
        {
            MaPhongHat = MaPH;
            MaThuePhong = getMaThuePhong(MaPhongHat);
            InitializeComponent();
        }
        public string getMaThuePhong(string MaPH)
        {
            string sql = string.Format(@"select * from THUEPHONG where MaPH='PH_10' and TinhTrang=N'Đã Nhận Phòng'");
            dtGetMaTP = db.LayDuLieu(sql);
            DataRow getma = dtGetMaTP.Rows[0];
            string matp = getma["MaTP"].ToString();
            return matp;
        }

        public int getSoLuong(string tenDV)
        {
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                if (dataGridView2.Rows[i].Cells[0].Value.ToString() == tenDV)
                {
                    return i;
                }
            }
            return 0;
        }
        public void xulyOrder(string matp, string tendv, string maph)
        {
            dtchitietdichvu1 = db.LayDuLieu("select *from chiTietDichVu");
            if (checkDichVu(tendv) == 0)
            {
                DataRow newrow = dtchitietdichvu1.NewRow();
                newrow[0] = getMaDV(tendv).ToString();
                newrow[1] = MaThuePhong;
                newrow[2] = maph;
                newrow[3] = dataGridView2.Rows[getSoLuong(tendv)].Cells[1].Value.ToString();
                newrow[4] = getDonGiaDV(tendv);
                newrow[5] = "0.0";
                newrow[6] = rtxt_Note.Text;


                dtchitietdichvu1.Rows.Add(newrow);
                try
                {
                    string sql = "select * from chiTietDichVu";
                    db.UpdateData(sql, dtchitietdichvu1);
                    showDVdaSuDung(MaThuePhong);
                }
                catch (Exception)
                {
                    MessageBox.Show("Loi~111111");
                }
            }
            else
            {
                try
                {
                    string sql = "update CHITIETDICHVU set SoLuong = SoLuong + " + dataGridView2.Rows[0].Cells[1].Value.ToString() + " , Note = N'" + dataGridView2.Rows[0].Cells[2].Value.ToString() + "' where MaDV = '" + getMaDV(tendv) + "'and MaTP = '" + matp + "'";
                    db.ThemXoaSua(sql);
                    showDVdaSuDung(MaThuePhong);
                }
                catch (Exception)
                {
                    MessageBox.Show("Loi~aaa");
                }
            }
        }
        public string getMaDV(string TenDV)
        {
            string sql = string.Format(@"select * from DichVu where TenDV=N'{0}'", TenDV);
            dtGetMaDV = db.LayDuLieu(sql);
            DataRow getma = dtGetMaDV.Rows[0];
            string maDV = getma["MaDV"].ToString();
            return maDV;
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            ShowListViewDichVu();
            showDVdaSuDung(MaThuePhong);
            Text();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn oder  ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    TenDichVu = dataGridView2.Rows[i].Cells[0].Value.ToString();
                    xulyOrder(MaThuePhong, TenDichVu, MaPhongHat);
                }
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();
            }
            ShowListViewDichVu();

        }
        private void lst_DichVu_Click(object sender, EventArgs e)
        {
            txt_TenDV.Text = lst_DichVu.SelectedItems[0].SubItems[0].Text;
            xulyViewData(txt_TenDV.Text);
        }

        public string getDonGiaDV(string tenDV)
        {
            string sql = string.Format(@"select * from DICHVU Where TenDV = N'{0}'", tenDV);
            dtGetDonGiaDV = db.LayDuLieu(sql);
            DataRow getma = dtGetDonGiaDV.Rows[0];
            string dongia = getma["DonGia"].ToString();
            return dongia;
        }

        private void btn_ChonMon_Click(object sender, EventArgs e)
        {
            if (txt_TenDV.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một món nào đó");
            }
            else
            {
                xuLyChonDV(txt_TenDV.Text);
                rtxt_Note.Text = "";
                txt_TenDV.Text = "";
                txtDonViTinh.Text = "";
                txtDonGia.Text = "";
                if (Flat == 0)
                {
                    btn_huyChonMon.Enabled = btn_ODER.Enabled = true;
                }
                else
                {
                    btn_huyChonMon.Enabled = btn_ODER.Enabled = false;
                    Flat = 0;
                }

            }
        }
        public void showDVdaSuDung(string matp)
        {
            dataGridView1.AutoGenerateColumns = false;
            dtchitietdichvu = db.LayDuLieu("select ROW_NUMBER() OVER (ORDER BY DICHVU.MaDV) AS STT,TenDV,SoLuong ,CHITIETDICHVU.DonGia,ThanhTien from CHITIETDICHVU,DICHVU where DICHVU.MaDV=CHITIETDICHVU.MaDV and MaTP = '" + matp + "'");
            dataGridView1.DataSource = dtchitietdichvu;
            dataGridView1.Columns[0].DataPropertyName = "STT";
            dataGridView1.Columns[1].DataPropertyName = "TenDV";
            dataGridView1.Columns[2].DataPropertyName = "SoLuong";
            dataGridView1.Columns[3].DataPropertyName = "DonGia";
            dataGridView1.Columns[4].DataPropertyName = "ThanhTien";
        }
        public void ShowListViewDichVu()
        {
            lst_DichVu.Items.Clear();
            dtdichvu = db.LayDuLieu("select * from DICHVU");
            for (int i = 0; i < dtdichvu.Rows.Count; i++)
            {
                if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "coca".ToLower())
                {
                    if (int.Parse(dtdichvu.Rows[i]["SLTon"].ToString()) == 0)
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 10;
                    }
                    else
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 0;
                    }

                }
                if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "Bí đao".ToLower())
                {
                    if (int.Parse(dtdichvu.Rows[i]["SLTon"].ToString()) == 0)
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 10;
                    }
                    else
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 1;
                    }
                }
                if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "bia Heineken".ToLower())
                {
                    if (int.Parse(dtdichvu.Rows[i]["SLTon"].ToString()) == 0)
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 10;
                    }
                    else
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 2;
                    }
                }
                if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "Nước cam".ToLower())
                {
                    if (int.Parse(dtdichvu.Rows[i]["SLTon"].ToString()) == 0)
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 10;
                    }
                    else
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 3;
                    }
                }
                if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "nước lọc".ToLower())
                {
                    if (int.Parse(dtdichvu.Rows[i]["SLTon"].ToString()) == 0)
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 10;
                    }
                    else
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 4;
                    }
                }
                if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "pepsi".ToLower())
                {
                    if (int.Parse(dtdichvu.Rows[i]["SLTon"].ToString()) == 0)
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 10;
                    }
                    else
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 5;
                    }
                }
                if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "redbull".ToLower())
                {
                    if (int.Parse(dtdichvu.Rows[i]["SLTon"].ToString()) == 0)
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 10;
                    }
                    else
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 6;
                    }
                }
                if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "bia sài gòn".ToLower())
                {
                    if (int.Parse(dtdichvu.Rows[i]["SLTon"].ToString()) == 0)
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 10;
                    }
                    else
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 7;
                    }
                }
                if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "Sting".ToLower())
                {
                    if (int.Parse(dtdichvu.Rows[i]["SLTon"].ToString()) == 0)
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 10;
                    }
                    else
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 8;
                    }
                }
                if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "Bia tiger".ToLower())
                {
                    if (int.Parse(dtdichvu.Rows[i]["SLTon"].ToString()) == 0)
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 10;
                    }
                    else
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 9;
                    }
                }

            }
        }
        public void xulyViewData(string TenDV)
        {
            try
            {
                string laydulieu = "select * from DICHVU where TenDV = N'" + TenDV + "'";
                dtdichvu = db.LayDuLieu(laydulieu);
                DataRow data = dtdichvu.Rows[0];
                txtDonGia.Text = data["DonGia"].ToString();
                txtDonViTinh.Text = data["DonViTinh"].ToString();
            }
            catch (Exception)
            {

            }
        }
        private void btn_huyChonMon_Click(object sender, EventArgs e)
        {
            XulyHuyMon();
            if (dataGridView2.Rows[0].Cells[0].Value == null)
            {
                btn_huyChonMon.Enabled = false;
                btn_ODER.Enabled = false;
            }
        }

       

        public void XulyHuyMon()
        {
            if (dataGridView2.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Bạn chưa Oder món nào hết nhé!");
            }
            else
            {
                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                //MessageBox.Show("" + selectedrowindex);
                string tenmon = Convert.ToString(selectedRow.Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Xác Nhận Hủy Món: " + tenmon, "Thong Bao", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        if (!this.dataGridView2.Rows[selectedrowindex].IsNewRow)
                        {
                            this.dataGridView2.Rows.RemoveAt(selectedrowindex);
                            dataGridView2.Refresh();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Loi Huy Mon !");
                    }
                }
            }
        }
        public int checkDichVu(string tendv)
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == tendv)
                {
                    return 1;
                }
            }
            return 0;
        }
        public void  Text()
        {
            txt_TenDV.Enabled = txtDonGia.Enabled = txtDonViTinh.Enabled = false;
            rtxt_Note.Text = "";
            btn_huyChonMon.Enabled = btn_ODER.Enabled = false;
        }

        public string GetSL(string TenDV)
        {
            string sql = string.Format(@"select * from DichVu where TenDV=N'{0}'", TenDV);
            dtGetSL = db.LayDuLieu(sql);
            DataRow getma = dtGetSL.Rows[0];
            string SLTon = getma["SLTon"].ToString();
            return SLTon;
        }
        public void xuLyChonDV(string tendv)
        {
            dtdichvu = db.LayDuLieu("select * from DICHVU");
            if (int.Parse(GetSL(txt_TenDV.Text)) == 0)
            {
                MessageBox.Show(txt_TenDV.Text + " đã hết mời bạn chọn món khác");
                Flat = 1;
            }
            else if (int.Parse(GetSL(txt_TenDV.Text)) < int.Parse(num_soLuong.Text))
            {
                int soluongdatduoc = int.Parse(GetSL(txt_TenDV.Text));
                MessageBox.Show("So lượng " + txt_TenDV.Text + " trong kho không đủ bạn chỉ được oder với số lượng là:" + soluongdatduoc);
             
            }
            else if (dataGridView2.Rows[0].Cells[0].Value == null)
            {
                int rowId = dataGridView2.Rows.Add();
                DataGridViewRow row = dataGridView2.Rows[rowId];
                row.Cells["dataGridViewTextBoxColumn2"].Value = txt_TenDV.Text;
                row.Cells["dataGridViewTextBoxColumn3"].Value = num_soLuong.Text;
                row.Cells["Column6"].Value = rtxt_Note.Text;
              
            }
            else
            {
                if (checkDichVu1(tendv) == 0)
                {
                    int rowId = dataGridView2.Rows.Add();
                    DataGridViewRow row = dataGridView2.Rows[rowId];
                    row.Cells["dataGridViewTextBoxColumn2"].Value = txt_TenDV.Text;
                    row.Cells["dataGridViewTextBoxColumn3"].Value = num_soLuong.Text;
                    row.Cells["Column6"].Value = rtxt_Note.Text;
                }
                else
                {
                    int vitri = Layvitritrung(tendv);
                    string soluong = dataGridView2.Rows[vitri].Cells[1].Value.ToString();
                    a = int.Parse(soluong) + int.Parse(num_soLuong.Text);
                    dataGridView2.Rows[vitri].Cells[1].Value = "" + a;
                }
            }
        }
        public int checkDichVu1(string tendv)
        {
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                if (dataGridView2.Rows[i].Cells[0].Value.ToString() == tendv)
                {
                    return 1;
                }
            }
            return 0;
        }
        public int Layvitritrung(string tendv)
        {
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                if (dataGridView2.Rows[i].Cells[0].Value.ToString() == tendv)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
