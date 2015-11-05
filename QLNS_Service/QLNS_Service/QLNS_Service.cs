using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QLNS_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "QLNS_Service" in both code and config file together.
    public class QLNS_Service : IQLNS_Service
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
        public DataSet NhanVien()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien", conn);
            DataSet dsNhanVien = new DataSet();
            da.Fill(dsNhanVien);
            return dsNhanVien;
        }
       public DataSet NguoiDung()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from NguoiDung", conn);
            DataSet dsNguoiDung = new DataSet();
            da.Fill(dsNguoiDung);
            return dsNguoiDung;
        }
        public bool ktDangNhap(string UID, string PWD)
       {
            try
            {
                DataClasses1DataContext login = new DataClasses1DataContext();
                var message = from t in login.NguoiDungs
                              where t.TenDN == UID && t.MatKhau == PWD
                              select t;
                if(message.Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
       }
    }
}
