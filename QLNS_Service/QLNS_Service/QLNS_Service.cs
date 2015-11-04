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
        public DataSet NhanVien()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien", conn);
            DataSet dsNhanVien = new DataSet();
            da.Fill(dsNhanVien);
            return dsNhanVien;        
        }
    }
}
