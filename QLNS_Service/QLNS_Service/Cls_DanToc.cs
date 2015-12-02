using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QLNS_Service
{
    [DataContract]
    public class Cls_DanToc
    {
        string MaDT;
        string TenDT;
        [DataMember]
        public string madt
        {
            get { return MaDT; }
            set { MaDT = value; }
        }
        [DataMember]
        public string tendt
        {
            get { return TenDT; }
            set { TenDT = value; }
        }
    }
}
