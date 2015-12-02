using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QLNS_Service
{
    [DataContract]
    public class Cls_HopDong
    {
        string MaLoaiHD;
        string TenHD;
        [DataMember]
        public string maloaihd
        {
            get { return MaLoaiHD; }
            set { MaLoaiHD = value; }
        }
        [DataMember]
        public string tenhd
        {
            get { return TenHD; }
            set { TenHD = value; }
        }
    }
}
