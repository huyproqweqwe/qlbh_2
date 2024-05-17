using QuanLiBanHang.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanHang
{
    public partial class frmHoaDon : Form
    {
        DataTable tblCTHoaDon;
        int chucNangDaChon = ChucNang.NONE;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            btnLuu.Enabled = false;
        }

        private void LoadDataGridView()
        {
            txtMaHD.Enabled = false;
            txtTenKH.Enabled = false;
            txtDiaChi.Enabled = false;
            cboMaKH.Enabled = false;
            mtbDienThoai.Enabled = false;
            cboMaDC.Enabled = false;
            txtSoLuong.Enabled = false;
            txtTenDC.Enabled = false;
            txtDonGia.Enabled = false;
            txtThanhTien.Enabled = false;
            dtpNgayLapHD.Enabled = false;

            //string sql = "SELECT * FROM ChiTietHoaDon";
            //tblCTHoaDon = Class.Functions.GetDataToTable(sql);
            //dgvHDBanHang.DataSource = tblCTHoaDon;
            string qr = "SELECT MaKhachHang FROM KhachHang";
            DataTable dtMaNhaCungCap = Class.Functions.GetDataToTable(qr);

            dgvHDBanHang.DataSource = tblCTHoaDon;
            cboMaKH.DisplayMember = "MaKhachHang";  // Hiển thị mã nhà cung cấp
            cboMaKH.ValueMember = "MaKhachHang";   // Giá trị của mỗi mục là mã nhà cung cấp

            dgvHDBanHang.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvHDBanHang.AllowUserToAddRows = false;
        }

        private void btnPhieuGhiNo_Click(object sender, EventArgs e)
        {
            frmPhieuTraNo frmPhieuTraNo = new frmPhieuTraNo();
            this.Hide();
            frmPhieuTraNo.ShowDialog();
            this.Show();
        }

        private void btnPhieuHen_Click(object sender, EventArgs e)
        {
            frmPhieuHen frm = new frmPhieuHen();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void ResetValue()
        {
            //txtMaHD.Text = "";
            txtTenKH.Text = "";
            cboMaKH.Text = "";
            mtbDienThoai.Text = "";
            txtDiaChi.Text = "";
            
            cboMaDC.Text = "";
            txtTenDC.Text = "";
            txtThanhTien.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
        }

        private void SetStateControl(bool trangThai)
        {
            btnThem.Enabled = trangThai;
            btnXoa.Enabled = trangThai;
            btnLuu.Enabled = !trangThai;
            btnHuy.Enabled = !trangThai;
            btnExit.Enabled = trangThai;
        }

        private void SwitchMode(int chucNang)
        {
            chucNangDaChon = chucNang;
            switch (chucNang)
            {
                case ChucNang.ADD:
                    SetStateControl(false);
                    txtMaHD.Text = Class.Functions.CreateKey("HDB");
                    cboMaDC.Enabled = true;
                    txtSoLuong.Enabled = true;
                    txtDiaChi.Enabled = true;
                    txtTenKH.Enabled = true;
                    cboMaKH.Enabled = true;
                    dtpNgayLapHD.Enabled = true;
                    mtbDienThoai.Enabled = true;
                    txtDonGia.Enabled = true;
                    ResetValue();
                    break;

                case ChucNang.UPDATE:
                    SetStateControl(false);
                    txtTenKH.Enabled = true;
                    txtDiaChi.Enabled = true;
                    mtbDienThoai.Enabled = true;
                    break;

                case ChucNang.NONE:
                    SetStateControl(true);
                    txtTenKH.Enabled = false;
                    txtDiaChi.Enabled = false;
                    mtbDienThoai.Enabled = false;
                    break;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (chucNangDaChon == ChucNang.NONE)
                SwitchMode(ChucNang.ADD);
            else
                SwitchMode(ChucNang.NONE);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
