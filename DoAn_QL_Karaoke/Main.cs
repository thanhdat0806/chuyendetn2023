using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QL_Karaoke
{
    public partial class Main : Form
    {

        String MaNV = "";
        String ChucVu = "";
        public Main(string maNV)
        {
            InitializeComponent();
           MaNV = maNV;

            // Kiểm tra chức vụ của nhân viên
            if (ChucVu == "1")
            {
                // Nếu chức vụ là 1, cho phép sử dụng tất cả chức năng
                EnableAllMenuItems();
            }
            else if (ChucVu == "2")
            {
                // Nếu chức vụ là 2, chỉ cho phép sử dụng các chức năng cụ thể
                EnableLimitedMenuItems();
            }
            else
            {
                UnenableAllMenuItems();
            }
        }

        private void EnableAllMenuItems()
        {
            // Kích hoạt tất cả các menu item
            đăngNhậpToolStripMenuItem.Enabled = false;
            đặtPhòngOnlineToolStripMenuItem.Enabled = true;
            kháchHàngToolStripMenuItem.Enabled = true;
            đăngXuấtToolStripMenuItem.Enabled = true;
            thoátToolStripMenuItem.Enabled = true;
            nhậnĐặtPhòngToolStripMenuItem.Enabled = true;
            dịchVụToolStripMenuItem.Enabled = true;
            thốngKêDoanhThuToolStripMenuItem.Enabled = true;
            thốngKêNguyênVậtLiệuToolStripMenuItem.Enabled = true;
            nhàSánXuấtToolStripMenuItem.Enabled = true;
            nhậpNguyênVậtLiệuToolStripMenuItem.Enabled = true;
            phòngHátToolStripMenuItem.Enabled = true;
            nhânViênToolStripMenuItem.Enabled = true;
        }

        private void EnableLimitedMenuItems()
        {
            đăngNhậpToolStripMenuItem.Enabled = false;
            // Chỉ kích hoạt các menu item cần thiết
            đặtPhòngOnlineToolStripMenuItem.Enabled = true;
            kháchHàngToolStripMenuItem.Enabled = true;
            đăngXuấtToolStripMenuItem.Enabled = true;
            thoátToolStripMenuItem.Enabled = true;
            nhậnĐặtPhòngToolStripMenuItem.Enabled = true;
            dịchVụToolStripMenuItem.Enabled = true;
            phòngHátToolStripMenuItem.Enabled = true;

            // Vô hiệu hóa các menu item khác
            thốngKêDoanhThuToolStripMenuItem.Enabled = false;
            thốngKêNguyênVậtLiệuToolStripMenuItem.Enabled = false;
            nhàSánXuấtToolStripMenuItem.Enabled = false;
            nhậpNguyênVậtLiệuToolStripMenuItem.Enabled = false;
            
            nhânViênToolStripMenuItem.Enabled = false;
        }
        private void UnenableAllMenuItems()
        {
            // Vô hiệu hóa tất các menu
            đăngNhậpToolStripMenuItem.Enabled = true;
            đặtPhòngOnlineToolStripMenuItem.Enabled = false;
            kháchHàngToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = false;
            thoátToolStripMenuItem.Enabled = true;
            nhậnĐặtPhòngToolStripMenuItem.Enabled = false;
            dịchVụToolStripMenuItem.Enabled = false;
            nhânViênToolStripMenuItem.Enabled = false;

            thốngKêDoanhThuToolStripMenuItem.Enabled = false;
            thốngKêNguyênVậtLiệuToolStripMenuItem.Enabled = false;
            nhàSánXuấtToolStripMenuItem.Enabled = false;
            nhậpNguyênVậtLiệuToolStripMenuItem.Enabled = false;
            phòngHátToolStripMenuItem.Enabled = false;
        }


        /* private int childFormNumber = 0;
         *//*String MaNV = "NV_1";
        public Main(string maNV)
         {
             InitializeComponent();

         }*//*



         private void ShowNewForm(object sender, EventArgs e)
         {
             Form childForm = new Form();
             childForm.MdiParent = this;
             childForm.Text = "Window " + childFormNumber++;
             childForm.Show();
         }*/

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        
        
       

        private void CloseAllChildForms()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void test_Load(object sender, EventArgs e)
        {
            string[] smangNgay = { "Chủ Nhật", "Thứ Hai", "Thứ Ba", "Thứ Tư", "Thứ Năm", "Thứ Sáu", "Thứ Bảy" };
            int ingay = DateTime.Now.DayOfWeek.GetHashCode();
            Lbl_HomNay.Text = Lbl_HomNay.Text + smangNgay[ingay].ToString() + " Ngày " + DateTime.Today.Day.ToString()
                + " Tháng " + DateTime.Today.Month.ToString() + " Năm " + DateTime.Today.Year.ToString();
            /*Frm_NhanDatPhong FrmDP = new Frm_NhanDatPhong(MaNV);
            
            FrmDP.Show();*/
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Frm_DichVu FrmDP = new Frm_DichVu();
            /*FrmDP.MdiParent = this;*/
            FrmDP.ShowDialog();
        }

        private void nhậnĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Frm_NhanDatPhong FrmDP = new Frm_NhanDatPhong(MaNV);
            FrmDP.MdiParent = this;
            FrmDP.Show();
            
        }
        

        
        

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void đặtPhòngOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Frm_DatPhongOnline FrmDP = new Frm_DatPhongOnline(MaNV);
           
            FrmDP.ShowDialog();
            
        }

        private void thôngTinTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Frm_ThongTin FrmDP = new Frm_ThongTin();
           
            FrmDP.ShowDialog();
            
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Frm_ThongKeDoanhThu FrmDP = new Frm_ThongKeDoanhThu();
            /*FrmDP.MdiParent = this;*/
            FrmDP.ShowDialog();
        }

        private void thốngKêNguyênVậtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Frm_ThongKeVatLieu FrmDP = new Frm_ThongKeVatLieu();
            FrmDP.MdiParent = this;
            FrmDP.Show();
        }

        private void nhàSánXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Frm_NhaSanXuat FrmDP = new Frm_NhaSanXuat();
            FrmDP.MdiParent = this;
            FrmDP.Show();
        }

        private void nhậpNguyênVậtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Frm_NhapHang FrmDP = new Frm_NhapHang();
            FrmDP.MdiParent = this;
            FrmDP.Show();
        }

        private void phòngHátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Frm_PhongHat FrmDP = new Frm_PhongHat();
            FrmDP.MdiParent = this;
            FrmDP.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Frm_KhachHang FrmDP = new Frm_KhachHang();
            FrmDP.MdiParent = this;
            FrmDP.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {

                CloseAllChildForms();
                UnenableAllMenuItems();
                MessageBox.Show("Đăng xuất tài khoản thành công!", "Thông báo");
                /*Frm_DangNhap frmDangNhap = new Frm_DangNhap();
                frmDangNhap.Show();*/  // Sửa thành frmDangNhap.Show() thay vì frmDangNhap.ShowDialog()
                                       // Kiểm tra giá trị chức vụ sau khi đăng nhập

            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DangNhap frmDangNhap = new Frm_DangNhap();
            frmDangNhap.ShowDialog();

            // Kiểm tra giá trị chức vụ sau khi đăng nhập
            if (frmDangNhap.ChucVu == "1")
            {
                // Chức vụ là 1
                EnableAllMenuItems();
            }
            else if (frmDangNhap.ChucVu == "2")
            {
                // Chức vụ là 2
                EnableLimitedMenuItems();
            }
            else
            {
                UnenableAllMenuItems();
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Frm_NhanVien FrmDP = new Frm_NhanVien();
            FrmDP.MdiParent = this;
            FrmDP.Show();
        }
    }
}
