﻿namespace QuanLiBanHang
{
    partial class frmPhieuHen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMaPH = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayHen = new System.Windows.Forms.DateTimePicker();
            this.txtSoLuong = new System.Windows.Forms.MaskedTextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.cboMaDC = new System.Windows.Forms.ComboBox();
            this.lblMaDC = new System.Windows.Forms.Label();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.txtMaPH = new System.Windows.Forms.TextBox();
            this.lblNgayHenGiao = new System.Windows.Forms.Label();
            this.lblMaPhieuHen = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblNgayLapPH = new System.Windows.Forms.Label();
            this.dgvPhieuHen = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.quanLiDoChoiDataSet = new QuanLiBanHang.QuanLiDoChoiDataSet();
            this.quanLiDoChoiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaPhieuHen = new System.Windows.Forms.TextBox();
            this.chiTietPhieuHenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietPhieuHenTableAdapter = new QuanLiBanHang.QuanLiDoChoiDataSetTableAdapters.ChiTietPhieuHenTableAdapter();
            this.maPhieuHenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDoChoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDoChoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuHen)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDoChoiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDoChoiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuHenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(321, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHIẾU HẸN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpNgayLap);
            this.panel1.Controls.Add(this.dtpNgayHen);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.lblSoLuong);
            this.panel1.Controls.Add(this.cboMaDC);
            this.panel1.Controls.Add(this.lblMaDC);
            this.panel1.Controls.Add(this.cboMaKH);
            this.panel1.Controls.Add(this.txtMaPH);
            this.panel1.Controls.Add(this.lblNgayHenGiao);
            this.panel1.Controls.Add(this.lblMaPhieuHen);
            this.panel1.Controls.Add(this.lblMaKH);
            this.panel1.Controls.Add(this.lblNgayLapPH);
            this.panel1.Location = new System.Drawing.Point(26, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 129);
            this.panel1.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtMaPhieuHen);
            this.panel4.Controls.Add(this.lblMaPH);
            this.panel4.Controls.Add(this.btnTim);
            this.panel4.Location = new System.Drawing.Point(26, 467);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(379, 48);
            this.panel4.TabIndex = 47;
            // 
            // lblMaPH
            // 
            this.lblMaPH.AutoSize = true;
            this.lblMaPH.Location = new System.Drawing.Point(14, 13);
            this.lblMaPH.Name = "lblMaPH";
            this.lblMaPH.Size = new System.Drawing.Size(90, 16);
            this.lblMaPH.TabIndex = 40;
            this.lblMaPH.Text = "Mã phiếu hẹn:";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(243, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(118, 34);
            this.btnTim.TabIndex = 43;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(520, 52);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayLap.TabIndex = 63;
            // 
            // dtpNgayHen
            // 
            this.dtpNgayHen.Location = new System.Drawing.Point(520, 14);
            this.dtpNgayHen.Name = "dtpNgayHen";
            this.dtpNgayHen.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayHen.TabIndex = 62;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.Location = new System.Drawing.Point(520, 92);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(200, 22);
            this.txtSoLuong.TabIndex = 61;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(373, 93);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(63, 16);
            this.lblSoLuong.TabIndex = 60;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // cboMaDC
            // 
            this.cboMaDC.FormattingEnabled = true;
            this.cboMaDC.Location = new System.Drawing.Point(138, 90);
            this.cboMaDC.Name = "cboMaDC";
            this.cboMaDC.Size = new System.Drawing.Size(155, 24);
            this.cboMaDC.TabIndex = 59;
            // 
            // lblMaDC
            // 
            this.lblMaDC.AutoSize = true;
            this.lblMaDC.Location = new System.Drawing.Point(26, 93);
            this.lblMaDC.Name = "lblMaDC";
            this.lblMaDC.Size = new System.Drawing.Size(76, 16);
            this.lblMaDC.TabIndex = 58;
            this.lblMaDC.Text = "Mã đồ chơi:";
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(138, 54);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(155, 24);
            this.cboMaKH.TabIndex = 57;
            // 
            // txtMaPH
            // 
            this.txtMaPH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPH.Location = new System.Drawing.Point(138, 14);
            this.txtMaPH.Name = "txtMaPH";
            this.txtMaPH.Size = new System.Drawing.Size(155, 22);
            this.txtMaPH.TabIndex = 56;
            // 
            // lblNgayHenGiao
            // 
            this.lblNgayHenGiao.AutoSize = true;
            this.lblNgayHenGiao.Location = new System.Drawing.Point(373, 56);
            this.lblNgayHenGiao.Name = "lblNgayHenGiao";
            this.lblNgayHenGiao.Size = new System.Drawing.Size(98, 16);
            this.lblNgayHenGiao.TabIndex = 55;
            this.lblNgayHenGiao.Text = "Ngày hẹn giao:";
            // 
            // lblMaPhieuHen
            // 
            this.lblMaPhieuHen.AutoSize = true;
            this.lblMaPhieuHen.Location = new System.Drawing.Point(26, 16);
            this.lblMaPhieuHen.Name = "lblMaPhieuHen";
            this.lblMaPhieuHen.Size = new System.Drawing.Size(90, 16);
            this.lblMaPhieuHen.TabIndex = 54;
            this.lblMaPhieuHen.Text = "Mã phiếu hẹn:";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(26, 56);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(101, 16);
            this.lblMaKH.TabIndex = 53;
            this.lblMaKH.Text = "Mã khách hàng:";
            // 
            // lblNgayLapPH
            // 
            this.lblNgayLapPH.AutoSize = true;
            this.lblNgayLapPH.Location = new System.Drawing.Point(373, 16);
            this.lblNgayLapPH.Name = "lblNgayLapPH";
            this.lblNgayLapPH.Size = new System.Drawing.Size(126, 16);
            this.lblNgayLapPH.TabIndex = 52;
            this.lblNgayLapPH.Text = "Ngày lập phiếu hẹn:";
            // 
            // dgvPhieuHen
            // 
            this.dgvPhieuHen.AllowUserToAddRows = false;
            this.dgvPhieuHen.AutoGenerateColumns = false;
            this.dgvPhieuHen.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPhieuHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuHen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuHenDataGridViewTextBoxColumn,
            this.MaKhachHang,
            this.MaDoChoi,
            this.NgayHen,
            this.NgayLap,
            this.SoLuong,
            this.maDoChoiDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn});
            this.dgvPhieuHen.DataSource = this.chiTietPhieuHenBindingSource;
            this.dgvPhieuHen.Location = new System.Drawing.Point(-3, 196);
            this.dgvPhieuHen.Name = "dgvPhieuHen";
            this.dgvPhieuHen.RowHeadersWidth = 51;
            this.dgvPhieuHen.RowTemplate.Height = 24;
            this.dgvPhieuHen.Size = new System.Drawing.Size(806, 196);
            this.dgvPhieuHen.TabIndex = 48;
            this.dgvPhieuHen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuHen_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(11, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 63);
            this.panel2.TabIndex = 49;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(560, 11);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 39);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(436, 11);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 39);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(678, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 39);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(145, 11);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 39);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(287, 11);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 39);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(7, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 39);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // quanLiDoChoiDataSet
            // 
            this.quanLiDoChoiDataSet.DataSetName = "QuanLiDoChoiDataSet";
            this.quanLiDoChoiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLiDoChoiDataSetBindingSource
            // 
            this.quanLiDoChoiDataSetBindingSource.DataSource = this.quanLiDoChoiDataSet;
            this.quanLiDoChoiDataSetBindingSource.Position = 0;
            // 
            // txtMaPhieuHen
            // 
            this.txtMaPhieuHen.Location = new System.Drawing.Point(110, 10);
            this.txtMaPhieuHen.Name = "txtMaPhieuHen";
            this.txtMaPhieuHen.Size = new System.Drawing.Size(127, 22);
            this.txtMaPhieuHen.TabIndex = 50;
            // 
            // chiTietPhieuHenBindingSource
            // 
            this.chiTietPhieuHenBindingSource.DataMember = "ChiTietPhieuHen";
            this.chiTietPhieuHenBindingSource.DataSource = this.quanLiDoChoiDataSetBindingSource;
            // 
            // chiTietPhieuHenTableAdapter
            // 
            this.chiTietPhieuHenTableAdapter.ClearBeforeFill = true;
            // 
            // maPhieuHenDataGridViewTextBoxColumn
            // 
            this.maPhieuHenDataGridViewTextBoxColumn.DataPropertyName = "MaPhieuHen";
            this.maPhieuHenDataGridViewTextBoxColumn.HeaderText = "MaPhieuHen";
            this.maPhieuHenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPhieuHenDataGridViewTextBoxColumn.Name = "maPhieuHenDataGridViewTextBoxColumn";
            this.maPhieuHenDataGridViewTextBoxColumn.Width = 125;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.HeaderText = "MaKhachHang";
            this.MaKhachHang.MinimumWidth = 6;
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Width = 125;
            // 
            // MaDoChoi
            // 
            this.MaDoChoi.DataPropertyName = "MaDoChoi";
            this.MaDoChoi.HeaderText = "MaDoChoi";
            this.MaDoChoi.MinimumWidth = 6;
            this.MaDoChoi.Name = "MaDoChoi";
            this.MaDoChoi.Width = 125;
            // 
            // NgayHen
            // 
            this.NgayHen.DataPropertyName = "NgayHen";
            this.NgayHen.HeaderText = "NgayHen";
            this.NgayHen.MinimumWidth = 6;
            this.NgayHen.Name = "NgayHen";
            this.NgayHen.Width = 125;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "NgayLap";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "SoLuong";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // maDoChoiDataGridViewTextBoxColumn
            // 
            this.maDoChoiDataGridViewTextBoxColumn.DataPropertyName = "MaDoChoi";
            this.maDoChoiDataGridViewTextBoxColumn.HeaderText = "MaDoChoi";
            this.maDoChoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDoChoiDataGridViewTextBoxColumn.Name = "maDoChoiDataGridViewTextBoxColumn";
            this.maDoChoiDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmPhieuHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvPhieuHen);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmPhieuHen";
            this.Text = "frmPhieuHen";
            this.Load += new System.EventHandler(this.frmPhieuHen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuHen)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDoChoiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDoChoiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuHenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblMaPH;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.DateTimePicker dtpNgayHen;
        private System.Windows.Forms.MaskedTextBox txtSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.ComboBox cboMaDC;
        private System.Windows.Forms.Label lblMaDC;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.TextBox txtMaPH;
        private System.Windows.Forms.Label lblNgayHenGiao;
        private System.Windows.Forms.Label lblMaPhieuHen;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblNgayLapPH;
        private System.Windows.Forms.DataGridView dgvPhieuHen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.BindingSource quanLiDoChoiDataSetBindingSource;
        private QuanLiDoChoiDataSet quanLiDoChoiDataSet;
        private System.Windows.Forms.TextBox txtMaPhieuHen;
        private System.Windows.Forms.BindingSource chiTietPhieuHenBindingSource;
        private QuanLiDoChoiDataSetTableAdapters.ChiTietPhieuHenTableAdapter chiTietPhieuHenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuHenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoChoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDoChoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
    }
}