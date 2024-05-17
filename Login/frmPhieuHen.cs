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
    public partial class frmPhieuHen : Form
    {
        DataTable tblPhieuHen;
        int chucNangDaChon = ChucNang.NONE;
        public frmPhieuHen()
        {
            InitializeComponent();
        }

        private void frmPhieuHen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLiDoChoiDataSet.ChiTietPhieuHen' table. You can move, or remove it, as needed.
            this.chiTietPhieuHenTableAdapter.Fill(this.quanLiDoChoiDataSet.ChiTietPhieuHen);

            LoadDataGridView();
            btnLuu.Enabled = false;
        }
        private void LoadDataGridView()
        {
            txtMaPH.Enabled = false;
            cboMaKH.Enabled = false;
            cboMaDC.Enabled = false;
            dtpNgayHen.Enabled = false;
            dtpNgayLap.Enabled = false;
            txtSoLuong.Enabled = false;

            string sql = "SELECT PhieuHen.MaPhieuHen, PhieuHen.NgayHen, PhieuHen.NgayLap, PhieuHen.MaKhachHang, " +
                         "ChiTietPhieuHen.MaDoChoi, ChiTietPhieuHen.SoLuong " +
                         "FROM PhieuHen " +
                         "INNER JOIN ChiTietPhieuHen ON PhieuHen.MaPhieuHen = ChiTietPhieuHen.MaPhieuHen";
            tblPhieuHen = Functions.GetDataToTable(sql);
            dgvPhieuHen.DataSource = tblPhieuHen;

            string qr = "SELECT MaDoChoi FROM DoChoi";
            DataTable dtMaDoChoi = Class.Functions.GetDataToTable(qr);
            cboMaDC.DataSource = dtMaDoChoi;
            cboMaDC.DisplayMember = "MaDoChoi";
            cboMaDC.ValueMember = "MaDoChoi";

            string query = "SELECT MaKhachHang FROM KhachHang";
            DataTable dtMaKhachHang = Class.Functions.GetDataToTable(query);
            cboMaKH.DataSource = dtMaKhachHang;
            cboMaKH.DisplayMember = "MaKhachHang";
            cboMaKH.ValueMember = "MaKhachHang";


            dgvPhieuHen.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPhieuHen.AllowUserToAddRows = false;
        }
        private void SetStateControl(bool trangThai)
        {
            btnThem.Enabled = trangThai;
            btnSua.Enabled = trangThai;
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
                    txtMaPH.Enabled = true;
                    cboMaKH.Enabled = true;
                    cboMaDC.Enabled = true;
                    dtpNgayHen.Enabled = true;
                    dtpNgayLap.Enabled = true;
                    txtSoLuong.Enabled = true;
                    ResetValue();
                    txtMaPH.Focus();
                    break;
                case ChucNang.UPDATE:
                    SetStateControl(false);
                    txtMaPH.Enabled = false;
                    cboMaKH.Enabled = true;
                    cboMaDC.Enabled = false;
                    dtpNgayHen.Enabled = true;
                    dtpNgayLap.Enabled = true;
                    txtSoLuong.Enabled = true;
                    break;
                case ChucNang.NONE:
                    SetStateControl(true);
                    txtMaPH.Enabled = false;
                    cboMaKH.Enabled = false;
                    cboMaDC.Enabled = false;
                    dtpNgayHen.Enabled = false;
                    dtpNgayLap.Enabled = false;
                    txtSoLuong.Enabled = false;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (tblPhieuHen.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaPH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM PhieuHen WHERE MaPhieuHen = N'" + txtMaPH.Text + "'";
                string qr = "DELETE FROM ChiTietPhieuHen WHERE MaDoChoi = N'" + cboMaDC.Text + "' AND MaPhieuHen = N'" + txtMaPH.Text + "'";

                Functions.RunSqlDel(qr);
                Functions.RunSqlDel(sql);
                MessageBox.Show("Xóa thành công!", "Thông báo");
                LoadDataGridView();
                ResetValue();
            }
        }
        private void ResetValue()
        {
            txtMaPH.Text = "";
            txtSoLuong.Text = "";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (chucNangDaChon == ChucNang.NONE)
                SwitchMode(ChucNang.UPDATE);
            else
                SwitchMode(ChucNang.NONE);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chucNangDaChon == ChucNang.ADD)
            {
                if (txtMaPH.Text.Trim().Length == 0 || cboMaKH.Text.Trim().Length == 0 ||
                    cboMaDC.Text.Trim().Length == 0 || txtSoLuong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                string sqlCheck = "SELECT MaPhieuHen FROM PhieuHen WHERE MaPhieuHen = '" + txtMaPH.Text.Trim() + "'";
                if (Functions.CheckKey(sqlCheck))
                {
                    MessageBox.Show("Mã phiếu hẹn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaPH.Focus();
                    return;
                }

                string ngayHenFormatted = dtpNgayHen.Value.ToString("yyyy/MM/dd");
                string ngayLapFormatted = dtpNgayLap.Value.ToString("yyyy/MM/dd");

                string sqlInsertPH = $"INSERT INTO PhieuHen (MaPhieuHen, NgayHen, NgayLap, MaKhachHang) " +
                                     $"VALUES (N'{txtMaPH.Text.Trim()}', '{ngayHenFormatted}', '{ngayLapFormatted}', N'{cboMaKH.Text.Trim()}')";
                string sqlInsertCTPH = $"INSERT INTO ChiTietPhieuHen (MaPhieuHen, MaDoChoi, SoLuong) " +
                                       $"VALUES (N'{txtMaPH.Text.Trim()}', N'{cboMaDC.Text.Trim()}', {int.Parse(txtSoLuong.Text)})";

                Functions.RunSQL(sqlInsertPH);
                Functions.RunSQL(sqlInsertCTPH);

                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }
            else if (chucNangDaChon == ChucNang.UPDATE)
            {
                if (txtMaPH.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string ngayHenFormatted = dtpNgayHen.Value.ToString("yyyy/MM/dd");
                string ngayLapFormatted = dtpNgayLap.Value.ToString("yyyy/MM/dd");

                string sqlUpdatePH = $"UPDATE PhieuHen SET NgayHen = '{ngayHenFormatted}', NgayLap = '{ngayLapFormatted}', " +
                                     $"MaKhachHang = N'{cboMaKH.Text.Trim()}' WHERE MaPhieuHen = N'{txtMaPH.Text.Trim()}'";
                string sqlUpdateCTPH = $"UPDATE ChiTietPhieuHen SET MaDoChoi = N'{cboMaDC.Text.Trim()}', SoLuong = {int.Parse(txtSoLuong.Text)} " +
                                       $"WHERE MaPhieuHen = N'{txtMaPH.Text.Trim()}'";

                Functions.RunSQL(sqlUpdatePH);
                Functions.RunSQL(sqlUpdateCTPH);

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }

            ResetValue();
            SwitchMode(ChucNang.NONE);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
            SwitchMode(ChucNang.NONE);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuHen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phiếu hẹn cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xây dựng câu truy vấn SQL để tìm kiếm thông tin phiếu hẹn và chi tiết phiếu hẹn tương ứng
            string sql = "SELECT PhieuHen.MaPhieuHen, PhieuHen.NgayHen, PhieuHen.NgayLap, PhieuHen.MaKhachHang, " +
                         "ChiTietPhieuHen.MaDoChoi, ChiTietPhieuHen.SoLuong " +
                         "FROM PhieuHen " +
                         "INNER JOIN ChiTietPhieuHen ON " +
                         "PhieuHen.MaPhieuHen = ChiTietPhieuHen.MaPhieuHen " +
                         "WHERE PhieuHen.MaPhieuHen LIKE '%" + txtMaPhieuHen.Text + "%'";
            tblPhieuHen = Class.Functions.GetDataToTable(sql);
            dgvPhieuHen.DataSource = tblPhieuHen;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPhieuHen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                txtMaPH.Focus();
                return;
            }

            if (tblPhieuHen.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMaPH.Text = dgvPhieuHen.CurrentRow.Cells["MaPhieuHen"].Value.ToString();
            cboMaKH.Text = dgvPhieuHen.CurrentRow.Cells["MaKhachHang"].Value.ToString();
            cboMaDC.Text = dgvPhieuHen.CurrentRow.Cells["MaDoChoi"].Value.ToString();
            dtpNgayHen.Value = DateTime.Parse(dgvPhieuHen.CurrentRow.Cells["NgayHen"].Value.ToString());
            dtpNgayLap.Value = DateTime.Parse(dgvPhieuHen.CurrentRow.Cells["NgayLap"].Value.ToString());
            txtSoLuong.Text = dgvPhieuHen.CurrentRow.Cells["SoLuong"].Value.ToString();
        }
    }
}
