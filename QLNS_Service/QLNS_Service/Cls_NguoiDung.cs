using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QLNS_Service
{
    [DataContract]
    public class Cls_NguoiDung
    {
        string TenDN;
        string MatKhau;
        string MaNV;
        string MaPQ;
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
        [DataMember]
        public string manv
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        [DataMember]
        public string mapq
        {
            get { return MaPQ; }
            set { MaPQ = value; }
        }
    }
}
