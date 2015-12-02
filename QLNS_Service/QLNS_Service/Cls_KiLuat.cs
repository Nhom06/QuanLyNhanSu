using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QLNS_Service
{
    [DataContract]
    public class Cls_KiLuat
    {
        string MaKL;
        string TenKL;
        [DataMember]
        public string makl
        {
            get { return MaKL; }
            set { MaKL = value; }
        }
        [DataMember]
        public string tenkl
        {
            get { return TenKL; }
            set { TenKL = value; }
        }
    }
}
