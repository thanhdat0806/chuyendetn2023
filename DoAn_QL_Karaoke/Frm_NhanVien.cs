using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn_QL_Karaoke
{
    public partial class Frm_NhanVien : Form
    {
        SqlConnection conn = null;
        SqlDataAdapter daNhanVien = null;
        DataTable dtNhanVien = null;
        bool themMoi = false;

        public Frm_NhanVien()
        {
            InitializeComponent();
        }

        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=DB_QLKaraoke;Integrated Security=True;";
            conn = new SqlConnection(connectionString);

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                daNhanVien = new SqlDataAdapter("SELECT * FROM NHANVIEN", conn);
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                daNhanVien.Fill(dtNhanVien);
                dataGridView1.DataSource = dtNhanVien;

                txt_MaNV.Enabled = false;
                txt_TenNV.Enabled = false;
                txt_DiaChi.Enabled = false;
                txt_SDT.Enabled = false;
                txt_ChucVu.Enabled = false;
                txt_Pass.Enabled = false;

                btn_Luu.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NHANVIEN. Lỗi rồi!!!");
            }
        }

        private void ResetValues()
        {
            txt_MaNV.Text = "";
            txt_TenNV.Text = "";
            txt_DiaChi.Text = "";
            txt_SDT.Text = "";
            txt_ChucVu.Text = "";
            txt_Pass.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btn_Them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaNV.Focus();
                return;
            }

            if (dtNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txt_MaNV.Text = dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
            txt_Pass.Text = dataGridView1.CurrentRow.Cells["Column2"].Value.ToString();
            txt_TenNV.Text = dataGridView1.CurrentRow.Cells["Column3"].Value.ToString();
            txt_DiaChi.Text = dataGridView1.CurrentRow.Cells["Column4"].Value.ToString();
            txt_SDT.Text = dataGridView1.CurrentRow.Cells["Column5"].Value.ToString();
            txt_ChucVu.Text = dataGridView1.CurrentRow.Cells["Column6"].Value.ToString();

            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            txt_MaNV.Enabled = false;
            txt_TenNV.Enabled = true;
            txt_DiaChi.Enabled = true;
            txt_SDT.Enabled = true;
            txt_ChucVu.Enabled = true;
            txt_Pass.Enabled = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_TaiLai.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Them.Enabled = false;
            ResetValues();
            txt_MaNV.Enabled = true;
            txt_TenNV.Enabled = true;
            txt_DiaChi.Enabled = true;
            txt_SDT.Enabled = true;
            txt_ChucVu.Enabled = true;
            txt_Pass.Enabled = true;
            txt_MaNV.Focus();
            themMoi = true;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dtNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txt_MaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE NHANVIEN SET TenNV=N'" + txt_TenNV.Text.Trim() + "',DiaChi=N'" + txt_DiaChi.Text.Trim() + "',SDT='" + txt_SDT.Text.Trim() + "',ChucVu=N'" + txt_ChucVu.Text.Trim() + "' WHERE MaNV='" + txt_MaNV.Text + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                ResetValues();
                btn_TaiLai.Enabled = true;
                btn_Them.Enabled = true;
                btn_Xoa.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Luu.Enabled = false;
                txt_MaNV.Enabled = false;
                txt_TenNV.Enabled = false;
                txt_DiaChi.Enabled = false;
                txt_SDT.Enabled = false;
                txt_ChucVu.Enabled = false;
                txt_Pass.Enabled = false;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txt_MaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM NHANVIEN WHERE MaNV='" + txt_MaNV.Text + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                ResetValues();
                btn_TaiLai.Enabled = true;
                btn_Them.Enabled = true;
                btn_Xoa.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Luu.Enabled = false;
                txt_MaNV.Enabled = false;
                txt_TenNV.Enabled = false;
                txt_DiaChi.Enabled = false;
                txt_SDT.Enabled = false;
                txt_ChucVu.Enabled = false;
                txt_Pass.Enabled = false;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_MaNV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaNV.Focus();
                return;
            }

            if (txt_TenNV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenNV.Focus();
                return;
            }

            if (txt_DiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_DiaChi.Focus();
                return;
            }

            if (txt_SDT.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SDT.Focus();
                return;
            }

            if (txt_ChucVu.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ChucVu.Focus();
                return;
            }

            if (txt_Pass.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Pass.Focus();
                return;
            }

            if (themMoi)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO NHANVIEN(MaNV, Pass, TenNV, DiaChi, SDT, ChucVu) VALUES('" + txt_MaNV.Text.Trim() + "', '" + txt_Pass.Text.Trim() + "', N'" + txt_TenNV.Text.Trim() + "', N'" + txt_DiaChi.Text.Trim() + "', '" + txt_SDT.Text.Trim() + "', N'" + txt_ChucVu.Text.Trim() + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                ResetValues();
                btn_TaiLai.Enabled = true;
                btn_Them.Enabled = true;
                btn_Xoa.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Luu.Enabled = false;
                txt_MaNV.Enabled = false;
                txt_TenNV.Enabled = false;
                txt_DiaChi.Enabled = false;
                txt_SDT.Enabled = false;
                txt_ChucVu.Enabled = false;
                txt_Pass.Enabled = false;
            }
        }

       
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
