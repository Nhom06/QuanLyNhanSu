using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;


namespace QLNS_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IQLNS_Service" in both code and config file together.
    [ServiceContract]
    public interface IQLNS_Service
    {
        [OperationContract]
        DataSet NhanVien();
        [OperationContract]
        DataSet NguoiDung();
        [OperationContract]
        bool ktDangNhap (string UID, string PWD);
    }
    [DataContract]
    public class LoginInformation
    {
        [DataMember]
        public string UID
        { get; set; }
        [DataMember]
        public string PWD
        { get; set; }
    }
}
