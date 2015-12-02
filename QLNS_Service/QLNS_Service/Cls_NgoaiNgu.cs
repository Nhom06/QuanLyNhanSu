using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QLNS_Service
{
    [DataContract]
    public class Cls_NgoaiNgu
    {
        string MaNN;
        string TenNN;
        [DataMember]
        public string mann
        {
            get { return MaNN; }
            set { MaNN = value; }
        }
        [DataMember]
        public string tennn
        {
            get { return TenNN; }
            set { TenNN = value; }
        }
    }
}
