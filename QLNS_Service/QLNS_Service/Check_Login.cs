using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace QLNS_Service
{
    [DataContract]
    public class Check_Login
    {
        string TenDN;
        string MatKhau;
        [DataMember]
        public string tendn 
        { 
            get { return TenDN; } 
            set { TenDN = value; }
        }
        [DataMember]
        public string matkhau
        {
            get { return MatKhau; }
            set { MatKhau = value; }
        }
    }
}
