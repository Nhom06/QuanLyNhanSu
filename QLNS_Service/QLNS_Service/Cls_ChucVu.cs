using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QLNS_Service
{
    [DataContract]
    public class Cls_ChucVu
    {
        string MaCV;
        string TenCV;
        float LuongCB;
        [DataMember]
        public string macv
        {
            get { return MaCV; }
            set { MaCV = value;}
        }
        [DataMember]
        public string tencv
        {
            get { return TenCV; }
            set { TenCV = value; }
        }
        [DataMember]
        public float luongcb
        {
            get { return LuongCB; }
            set { LuongCB = value; }
        }
    }
}
