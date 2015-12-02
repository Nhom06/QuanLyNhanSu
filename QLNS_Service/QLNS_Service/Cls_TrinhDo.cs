using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QLNS_Service
{
    [DataContract]
    public class Cls_TrinhDo
    {
        string MaTD = string.Empty;
        string TenTD = string.Empty;
        [DataMember]
        public string matd
        {
            get { return MaTD; }
            set { MaTD = value; }
        }
        [DataMember]
        public string tentd
        {
            get { return TenTD; }
            set { TenTD = value; }
        }
    }
}
