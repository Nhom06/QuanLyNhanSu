using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QLNS_Service
{
    [DataContract]
    public class Cls_TonGiao
    {
        string MaTG;
        string TenTG;
        [DataMember]
        public string matg
        {
            get { return MaTG; }
            set { MaTG = value; }
        }
        [DataMember]
        public string tentg
        {
            get { return TenTG; }
            set { TenTG = value; }
        }
    }
}
