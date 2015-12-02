using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QLNS_Service
{
    [DataContract]
    public class Cls_PhongBan
    {
        string MaPB;
        string TenPB;
        string DienThoai;
        string Fax;
        [DataMember]
        public string mapb 
        { 
            get { return MaPB; }
            set { MaPB = value; }
        }
        [DataMember]
        public string tenpb
        {
            get { return TenPB; }
            set { TenPB = value; }
        }
        [DataMember]
        public string dienthoai
        {
            get { return DienThoai; }
            set { DienThoai = value; }
        }
        [DataMember]
        public string fax
        {
            get { return Fax; }
            set { Fax = value; }
        }
    }
}
