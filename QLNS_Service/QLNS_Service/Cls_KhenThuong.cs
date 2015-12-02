using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QLNS_Service
{
    [DataContract]
    public class Cls_KhenThuong
    {
        string MaLoai;
        string TenLoai;
        [DataMember]
        public string maloai
        {
            get { return MaLoai; }
            set { MaLoai = value; }
        }
        [DataMember]
        public string tenloai
        {
            get { return TenLoai; }
            set { TenLoai = value; }
        }
    }
}
