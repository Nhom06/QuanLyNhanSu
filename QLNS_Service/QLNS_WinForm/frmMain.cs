using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLNS_WinForm.QLNS_ServiceReference;

namespace QLNS_WinForm
{
    public partial class frmMain : Form
    {
        QLNS_WinForm.QLNS_ServiceReference.QLNS_ServiceClient ss = new QLNS_WinForm.QLNS_ServiceReference.QLNS_ServiceClient();
        QLNS_WinForm.QLNS_ServiceReference.Cls_NhanVien nv = new Cls_NhanVien();
        QLNS_WinForm.QLNS_ServiceReference.Cls_ChucVu cv = new Cls_ChucVu();
        QLNS_WinForm.QLNS_ServiceReference.Cls_PhongBan pb = new Cls_PhongBan();
        public frmMain()
        {
            InitializeComponent();
        }
        protected void Form1_Load(object sender, EventArgs e)
        {
            gridNhanVien();
            gridChucVu();
        }
        //-----------------------------------------------------------------------------FORM NHÂN VIÊN----------------------------------------------------------------//
        private void gridNhanVien()
        {
            btnKhongThem.Enabled = false;
            btnSave.Enabled = false;
            btnKhongSua_1.Enabled = false;
            btnSave_1.Enabled = false;
            Enabled_Them(true);
            Enabled_SuaXoa(true);
            DataSet ds = ss.Load_NhanVien("Tb_NhanVien");
            dgridNhanVien.DataSource = ds.Tables[0];
        }
        private void btnKhongSua1_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnKhongSua_1.Enabled = false;
            btnSave_1.Enabled = false;
            btnXoa.Enabled = true;
            Enabled_SuaXoa(true);
        }
        private void MaTuDongTang()
        {
            /*
            ss.myconnect();
            DataSet dsNV = ss.Load_NhanVien("Tb_NhanVien");
            string s = "";
            if(dsNV.Tables[0].Rows.Count < 0)
            {
                s = "NV001";
            }
            else
            {
                int k;
                s = "NV";
                k = Convert.ToInt32(dsNV.Tables[0].Rows[dsNV.Tables[0].Rows.Count - 1][0].ToString().Substring(2, 3));
                k = k + 1;
                if (k < 10)
                    s = s + "0";
                else if (k < 100)
                    s = s + "00";
                s = s + k.ToString();
            }
            txtMaNV.Text = s;
             * */
        }
        private void dgridNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtMaNV.Text = dgridNhanVien.Rows[hang].Cells[0].Value.ToString();
                txtHoTen.Text = dgridNhanVien.Rows[hang].Cells[1].Value.ToString();
                txtGioiTinh.Text = dgridNhanVien.Rows[hang].Cells[2].Value.ToString();
                dpkNgaySinh.Value = Convert.ToDateTime(dgridNhanVien.Rows[hang].Cells[3].Value.ToString());
                txtNoiSinh.Text = dgridNhanVien.Rows[hang].Cells[4].Value.ToString();
                txtSoCMND.Text = dgridNhanVien.Rows[hang].Cells[5].Value.ToString();
                txtTonGiao.Text = dgridNhanVien.Rows[hang].Cells[6].Value.ToString();
                txtDanToc.Text = dgridNhanVien.Rows[hang].Cells[7].Value.ToString();
                ss.myconnect();
                DataSet dsCV = ss.Load_NhanVien("Tb_ChucVu");
                cboMaCV.DataSource = dsCV.Tables[0];
                cboMaCV.ValueMember = "MaCV";
                cboMaCV.DisplayMember = "MaCV";
                cboMaPB.Text = dgridNhanVien.Rows[hang].Cells[8].Value.ToString();

                DataSet dsPB = ss.Load_PhongBan("Tb_PhongBan");
                cboMaPB.DataSource = dsPB.Tables[0];
                cboMaPB.ValueMember = "MaPB";
                cboMaPB.DisplayMember = "MaPB";

                cboMaCV.Text = dgridNhanVien.Rows[hang].Cells[9].Value.ToString();
                txtDienThoai.Text = dgridNhanVien.Rows[hang].Cells[10].Value.ToString();
                txtHoKhau.Text = dgridNhanVien.Rows[hang].Cells[11].Value.ToString();
                txtChoOHienNay.Text = dgridNhanVien.Rows[hang].Cells[12].Value.ToString();
                dpkNgayVaoLam.Value = Convert.ToDateTime(dgridNhanVien.Rows[hang].Cells[13].Value.ToString());
                txtSoBHYT.Text = dgridNhanVien.Rows[hang].Cells[14].Value.ToString();
                txtSoTheATM.Text = dgridNhanVien.Rows[hang].Cells[15].Value.ToString();
            }
            catch
            {

            }
            try
            {
                int hang = e.RowIndex;
                txtMaNV_1.Text = dgridNhanVien.Rows[hang].Cells[0].Value.ToString();
                txtHoTen_1.Text = dgridNhanVien.Rows[hang].Cells[1].Value.ToString();
                txtGioiTinh_1.Text = dgridNhanVien.Rows[hang].Cells[2].Value.ToString();
                dpkNgaySinh_1.Text = dgridNhanVien.Rows[hang].Cells[3].Value.ToString();
                txtNoiSinh_1.Text = dgridNhanVien.Rows[hang].Cells[4].Value.ToString();
                txtSoCMND_1.Text = dgridNhanVien.Rows[hang].Cells[5].Value.ToString();
                txtTonGiao_1.Text = dgridNhanVien.Rows[hang].Cells[6].Value.ToString();
                txtDanToc_1.Text = dgridNhanVien.Rows[hang].Cells[7].Value.ToString();
                txtMaPB_1.Text = dgridNhanVien.Rows[hang].Cells[8].Value.ToString();
                txtMaCV_1.Text = dgridNhanVien.Rows[hang].Cells[9].Value.ToString();
                txtDienThoai_1.Text = dgridNhanVien.Rows[hang].Cells[10].Value.ToString();
                txtHoKhau_1.Text = dgridNhanVien.Rows[hang].Cells[11].Value.ToString();
                txtChoOHienNay_1.Text = dgridNhanVien.Rows[hang].Cells[12].Value.ToString();
                dpkNgayVaoLam_1.Text = dgridNhanVien.Rows[hang].Cells[13].Value.ToString();
                txtSoBHYT_1.Text = dgridNhanVien.Rows[hang].Cells[14].Value.ToString();
                txtSoTheATM_1.Text = dgridNhanVien.Rows[hang].Cells[15].Value.ToString();
            }
            catch
            {

            }
        }
        private void Empty()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtGioiTinh.ResetText();
            dpkNgaySinh.ResetText();
            txtNoiSinh.Clear();
            txtSoCMND.Clear();
            txtTonGiao.ResetText();
            txtDanToc.ResetText();
            cboMaPB.ResetText();
            cboMaCV.ResetText();
            txtDienThoai.Clear();
            txtHoKhau.Clear();
            txtChoOHienNay.Clear();
            dpkNgayVaoLam.ResetText();
            txtSoBHYT.Clear();
            txtSoTheATM.Clear();
        }
        private void Enabled_SuaXoa(bool Mo)
        {
            txtMaNV_1.Enabled = !Mo;
            txtHoTen_1.Enabled = !Mo;
            txtGioiTinh_1.Enabled = !Mo;
            dpkNgaySinh_1.Enabled = !Mo;
            txtNoiSinh_1.Enabled = !Mo;
            txtSoCMND_1.Enabled = !Mo;
            txtTonGiao_1.Enabled = !Mo;
            txtDanToc_1.Enabled = !Mo;
            txtMaPB_1.Enabled = !Mo;
            txtMaCV_1.Enabled = !Mo;
            txtDienThoai_1.Enabled = !Mo;
            txtHoKhau_1.Enabled = !Mo;
            txtChoOHienNay_1.Enabled = !Mo;
            dpkNgayVaoLam_1.Enabled = !Mo;
            txtSoBHYT_1.Enabled = !Mo;
            txtSoTheATM_1.Enabled = !Mo;
        }
        private void Enabled_Them(bool Mo)
        {
            txtMaNV.Enabled = !Mo;
            txtHoTen.Enabled = !Mo;
            txtGioiTinh.Enabled = !Mo;
            dpkNgaySinh.Enabled = !Mo;
            txtNoiSinh.Enabled = !Mo;
            txtSoCMND.Enabled = !Mo;
            txtTonGiao.Enabled = !Mo;
            txtDanToc.Enabled = !Mo;
            cboMaPB.Enabled = !Mo;
            cboMaCV.Enabled = !Mo;
            txtDienThoai.Enabled = !Mo;
            txtHoKhau.Enabled = !Mo;
            txtChoOHienNay.Enabled = !Mo;
            dpkNgayVaoLam.Enabled = !Mo;
            txtSoBHYT.Enabled = !Mo;
            txtSoTheATM.Enabled = !Mo;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MaTuDongTang();
            ss.myconnect();
            DataSet dsCV = ss.Load_NhanVien("Tb_ChucVu");
            cboMaCV.DataSource = dsCV.Tables[0];
            cboMaCV.ValueMember = "MaCV";
            cboMaCV.DisplayMember = "MaCV";

            DataSet dsPB = ss.Load_PhongBan("Tb_PhongBan");
            cboMaPB.DataSource = dsPB.Tables[0];
            cboMaPB.ValueMember = "MaPB";
            cboMaPB.DisplayMember = "MaPB";
            btnKhongThem.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            Enabled_Them(false);
            Empty();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaNV_1.Text.Trim() == "" || txtMaNV_1.TextLength == 0 || txtMaPB_1.Text.Trim() == "" || txtMaPB_1.TextLength == 0 || txtMaCV_1.Text.Trim() == "" || txtMaCV_1.TextLength == 0)
            {
                MessageBox.Show("Các thông tin (*) là bắt buộc!");
            }
            else
            {
                nv.manv = txtMaNV.Text;
                nv.hoten = txtHoTen.Text;
                nv.gioitinh = txtGioiTinh.Text;
                nv.ngaysinh = dpkNgaySinh.Value.ToString("dd/MM/yyyy");
                nv.noisinh = txtNoiSinh.Text;
                nv.socmnd = txtSoCMND.Text;
                nv.tongiao = txtTonGiao.Text;
                nv.dantoc = txtDanToc.Text;
                nv.mapb = cboMaPB.Text;
                nv.macv = cboMaCV.Text;
                nv.dienthoai = txtDienThoai.Text;
                nv.hokhau = txtHoKhau.Text;
                nv.choohiennay = txtChoOHienNay.Text;
                nv.ngayvaolam = dpkNgayVaoLam.Value.ToString("dd/MM/yyyy");
                nv.sobhyt = txtSoBHYT.Text;
                nv.sotheatm = txtSoTheATM.Text;

                ss.Add_NhanVien(nv);
                gridNhanVien();
                MessageBox.Show("Thêm " + txtMaNV.Text + " thành công!");
                btnAdd.Enabled = true;
                btnKhongThem.Enabled = false;
                btnSave.Enabled = false;
                Enabled_Them(true);
                Empty();
            }
        }

        private void btnKhongThem_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnKhongThem.Enabled = false;
            btnSave.Enabled = false;
            Enabled_Them(true);
            Empty();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            btnKhongSua_1.Enabled = true;
            btnSave_1.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            Enabled_SuaXoa(false);
            txtMaNV_1.Enabled = false;
        }

        private void btnSave_1_Click(object sender, EventArgs e)
        {
            if (txtMaNV_1.Text.Trim() == "" || txtMaNV_1.TextLength == 0 || txtMaPB_1.Text.Trim() == "" || txtMaPB_1.TextLength == 0 || txtMaCV_1.Text.Trim() == "" || txtMaCV_1.TextLength == 0)
            {
                MessageBox.Show("Các thông tin (*) là bắt buộc!");
            }
            else
            {
                nv.manv = txtMaNV_1.Text;
                nv.hoten = txtHoTen_1.Text;
                nv.gioitinh = txtGioiTinh_1.Text;
                nv.ngaysinh = dpkNgaySinh_1.Value.ToString("dd/MM/yyy");
                nv.noisinh = txtNoiSinh_1.Text;
                nv.socmnd = txtSoCMND_1.Text;
                nv.tongiao = txtTonGiao_1.Text;
                nv.dantoc = txtDanToc_1.Text;
                nv.mapb = txtMaPB_1.Text;
                nv.macv = txtMaCV_1.Text;
                nv.dienthoai = txtDienThoai_1.Text;
                nv.hokhau = txtHoKhau_1.Text;
                nv.choohiennay = txtChoOHienNay_1.Text;
                nv.ngayvaolam = dpkNgayVaoLam_1.Value.ToString("dd/MM/yyyy");
                nv.sobhyt = txtSoBHYT_1.Text;
                nv.sotheatm = txtSoTheATM_1.Text;

                ss.Update_NhanVien(nv);
                gridNhanVien();
                MessageBox.Show("Sửa " + txtMaNV_1.Text + " thành công!");
                btnSua.Enabled = true;
                btnKhongSua_1.Enabled = false;
                btnSave_1.Enabled = false;
                btnXoa.Enabled = true;    
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nv.manv = txtMaNV_1.Text;
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa " + txtMaNV_1.Text + " không?", "Đã xóa", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                ss.Delete_NhanVien(nv);
                gridNhanVien();
            }
            else if (dr == DialogResult.No)
            {
                //do something else
            }
        }
        private void radTimTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (radTimTatCa.Checked == true)
            {
                txtTimMaPB.Enabled = false;
                txtTimMaNV.Enabled = false;
                txtTimMaCV.Enabled = false;
                grpDKTim.Enabled = false;
                int ThuTuXem = 0;
            }
        }
        private void radTimMaPB_CheckedChanged(object sender, EventArgs e)
        {
            if (radTimMaPB.Checked == true)
            {
                txtTimMaPB.Enabled = true;
                txtTimMaNV.Enabled = false;
                txtTimMaCV.Enabled = false;
                grpDKTim.Enabled = false;
                int ThuTuXem = 1;
            }
        }
        private void radTimMaNV_CheckedChanged(object sender, EventArgs e)
        {
            if (radTimMaNV.Checked == true)
            {
                txtTimMaPB.Enabled = false;
                txtTimMaNV.Enabled = true;
                txtTimMaCV.Enabled = false;
                grpDKTim.Enabled = false;
                int ThuTuXem = 2;
            }
        }

        private void radTimMaCV_CheckedChanged(object sender, EventArgs e)
        {
            if (radTimMaCV.Checked == true)
            {
                txtTimMaPB.Enabled = false;
                txtTimMaNV.Enabled = false;
                txtTimMaCV.Enabled = true;
                grpDKTim.Enabled = false;
                int ThuTuXem = 3;
            }
        }

        private void radTimTheoDK_CheckedChanged(object sender, EventArgs e)
        {
            if (radTimTheoDK.Checked == true)
            {
                txtTimMaPB.Enabled = false;
                txtTimMaNV.Enabled = false;
                txtTimMaCV.Enabled = false;
                grpDKTim.Enabled = true;
                int ThuTuXem = 4;
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void txtTimMaPB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimMaNV_TextChanged(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------------------FORM CHỨC VỤ - PHÒNG BAN----------------------------------------------------------------//
        private void gridChucVu()
        {
            btnThemCV.Enabled = true;
            btnKhongThemCV.Enabled = false;
            btnSaveCV.Enabled = false;
            btnKhongSuaCV.Enabled = false;
            btnSaveCV_3.Enabled = false;
            Enabled_Them_CV(true);
            Enabled_Sua_CV(true);
            DataSet ds = ss.Load_ChucVu("Tb_ChucVu");
            dgridChucVu.DataSource = ds.Tables[0];

        }
        private void Enabled_Them_CV(bool Mo)
        {
            txtMaCV_2.Enabled = !Mo;
            txtTenCV_2.Enabled = !Mo;
            txtLuongCB_2.Enabled = !Mo;
        }
        private void Enabled_Sua_CV(bool Mo)
        {
            txtMaCV_3.Enabled = !Mo;
            txtTenCV_3.Enabled = !Mo;
            txtLuongCB_3.Enabled = !Mo;
        }
        private void Empty_CV()
        {
            txtMaCV_2.ResetText();
            txtTenCV_2.ResetText();
            txtLuongCB_2.ResetText();
        }
        private void dgridChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtMaCV_2.Text = dgridChucVu.Rows[hang].Cells[0].Value.ToString();
                txtTenCV_2.Text = dgridChucVu.Rows[hang].Cells[1].Value.ToString();
                txtLuongCB_2.Text = dgridChucVu.Rows[hang].Cells[2].Value.ToString();
            }
            catch
            {

            }
            try
            {
                int hang = e.RowIndex;
                txtMaCV_3.Text = dgridChucVu.Rows[hang].Cells[0].Value.ToString();
                txtTenCV_3.Text = dgridChucVu.Rows[hang].Cells[1].Value.ToString();
                txtLuongCB_3.Text = dgridChucVu.Rows[hang].Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnThemCV_Click(object sender, EventArgs e)
        {
            btnThemCV.Enabled = false;
            btnKhongThemCV.Enabled = true;
            btnSaveCV.Enabled = true;
            Enabled_Them_CV(false);
            Empty_CV();
        }

        private void btnKhongThemCV_Click(object sender, EventArgs e)
        {
            Enabled_Them_CV(true);
            Empty_CV();
            btnThemCV.Enabled = true;
            btnKhongThemCV.Enabled = false;
            btnSaveCV.Enabled = false;
        }
        private void btnSaveCV_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (txtMaCV_2.Text.Trim() == "" || txtMaCV_2.TextLength == 0 || txtTenCV_2.Text.Trim() == "" || txtTenCV_2.TextLength == 0 || txtLuongCB_2.TextLength == 0 || txtLuongCB_2.Text.Trim() == "0")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                if (int.TryParse(this.txtLuongCB_2.Text, out n))
                {
                    cv.macv = txtMaCV_2.Text;
                    cv.tencv = txtTenCV_2.Text;
                    cv.luongcb = float.Parse(txtLuongCB_2.Text);

                    ss.Add_ChucVu(cv);
                    gridChucVu();
                    MessageBox.Show("Thêm " + txtMaCV_2.Text + "thành công!");
                }
                else
                {
                    MessageBox.Show("Lương cơ bản phải là kiểu số!");
                }
            }
        }

        private void btnSuaCV_Click(object sender, EventArgs e)
        {
            btnSuaCV.Enabled = false;
            btnKhongSuaCV.Enabled = true;
            btnSaveCV_3.Enabled = true;
            btnXoaCV.Enabled = false;
            Enabled_Sua_CV(false);
            txtMaCV_3.Enabled = false;
        }

        private void btnKhongSuaCV_Click(object sender, EventArgs e)
        {
            Enabled_Sua_CV(true);
            btnSuaCV.Enabled = true;
            btnXoaCV.Enabled = true;
            btnKhongSuaCV.Enabled = false;
            btnSaveCV_3.Enabled = false;
        }

        private void btnSaveCV_3_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (txtMaCV_2.Text.Trim() == "" || txtMaCV_2.TextLength == 0 || txtTenCV_2.Text.Trim() == "" || txtTenCV_2.TextLength == 0 || txtLuongCB_2.TextLength == 0 || txtLuongCB_2.Text.Trim() == "0")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                if (int.TryParse(this.txtLuongCB_2.Text, out n))
                {
                    cv.macv = txtMaCV_2.Text;
                    cv.tencv = txtTenCV_2.Text;
                    cv.luongcb = float.Parse(txtLuongCB_2.Text);

                    ss.Update_ChucVu(cv);
                    gridChucVu();
                    MessageBox.Show("Thêm " + txtMaCV_2.Text + "thành công!");
                }
                else
                {
                    MessageBox.Show("Lương cơ bản phải là kiểu số!");
                }
            }
        }
    }
}