using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QLNS_Service
{
    [DataContract]
    public class Cls_PhanQuyen
    {
        string MaPQ;
        string TenPQ;
        [DataMember]
        public string mapq
        {
            get { return MaPQ; }
            set { MaPQ = value; }
        }
        [DataMember]
        public string tenpq
        {
            get { return TenPQ; }
            set { TenPQ = value; }
        }
    }
}
