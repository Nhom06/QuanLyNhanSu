using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace QLNS_Service
{
    [DataContract]
    public class Check_Login
    {
        [DataMember]
        public string UID { get; set; }
        [DataMember]
        public string PWD { get; set; }
    }
}
