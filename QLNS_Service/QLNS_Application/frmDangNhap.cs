using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using QLNS_Application.QLNVServiceReference;

namespace QLNS_Application
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            QLNVServiceReference.QLNS_ServiceClient ck_login = new QLNS_Application.QLNVServiceReference.QLNS_ServiceClient();
            bool result = ck_login.ktDangNhap(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim());
            if(result == true)
            {
                this.Hide();
                frmManHinhChinh ss = new frmManHinhChinh();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, vui lòng kiểm tra lại!");
            }
            
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }
         protected override bool ProcessCmdKey(ref Message msg, Keys keydata) 
        { 
            if (keydata == Keys.Enter) 
            {
                btDangNhap.PerformClick(); 
                return true; 
            } 
            return false; 
        }  
    }
}
