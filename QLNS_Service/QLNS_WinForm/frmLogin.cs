using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS_WinForm.QLNS_ServiceReference;
using System.Runtime.Serialization;

namespace QLNS_WinForm
{
    public partial class frmLogin : Form
    {
        QLNS_WinForm.QLNS_ServiceReference.QLNS_ServiceClient ss = new QLNS_ServiceClient();
        QLNS_ServiceReference.Cls_NguoiDung nd = new Cls_NguoiDung();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTaiKhoan.Text.Trim()) && string.IsNullOrEmpty(txtMatKhau.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tài khoản & mật khẩu!");
            }
            else
            {
                if (string.IsNullOrEmpty(txtTaiKhoan.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập tài khoản!");
                }
                else
                    if(string.IsNullOrEmpty(txtMatKhau.Text.Trim()))
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu!");
                    }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }
    }
}
