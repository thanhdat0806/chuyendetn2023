using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn_QL_Karaoke
{
    public partial class Frm_KhachHang : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private object QuanLyKhachHangController;

        public Frm_KhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            // Thiết lập kết nối đến cơ sở dữ liệu
            string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=DB_QLKaraoke;Integrated Security=True;";
            conn = new SqlConnection(connectionString);

            // Khởi tạo adapter và dataTable
            adapter = new SqlDataAdapter("SELECT * FROM KHACHHANG", conn);
            dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Hiển thị dữ liệu trên dataGridView
            dataGridView1.DataSource = dataTable;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Thêm khách hàng mới vào cơ sở dữ liệu
            DataRow newRow = dataTable.NewRow();
            newRow["SDT_KH"] = txt_SDT.Text;
            newRow["TenKH"] = txt_TenKH.Text;
            newRow["LoaiKH"] = txt_LoaiKH.Text;
            newRow["DiaChi"] = txt_DiaChi.Text;
            dataTable.Rows.Add(newRow);

            // Lưu dữ liệu vào cơ sở dữ liệu
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(dataTable);

            // Lấy dữ liệu từ cơ sở dữ liệu và đưa vào dataTable
            dataTable.Clear();
            adapter.Fill(dataTable);

            // Cập nhật hiển thị trên dataGridView
            dataGridView1.DataSource = dataTable;
        }
        
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Sửa thông tin khách hàng trong cơ sở dữ liệu
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataTable.Rows[rowIndex]["SDT_KH"] = txt_SDT.Text;
            dataTable.Rows[rowIndex]["TenKH"] = txt_TenKH.Text;
            dataTable.Rows[rowIndex]["LoaiKH"] = txt_LoaiKH.Text;
            dataTable.Rows[rowIndex]["DiaChi"] = txt_DiaChi.Text;

            // Lưu dữ liệu vào cơ sở dữ liệu
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(dataTable);

            // Lấy dữ liệu từ cơ sở dữ liệu và đưa vào dataTable
            dataTable.Clear();
            adapter.Fill(dataTable);

            // Cập nhật hiển thị trên dataGridView
            dataGridView1.DataSource = dataTable;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // Xóa khách hàng khỏi cơ sở dữ liệu
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataTable.Rows[rowIndex].Delete();

            // Lưu dữ liệu vào cơ sở dữ liệu
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(dataTable);

            // Lấy dữ liệu từ cơ sở dữ liệu và đưa vào dataTable
            dataTable.Clear();
            adapter.Fill(dataTable);

            // Cập nhật hiển thị trên dataGridView
            dataGridView1.DataSource = dataTable;
        }

      
    }
}