using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QLNS_Service
{
    [DataContract]
    public class Cls_CTNgoaiNgu
    {
        string MaCTNN;
        string MaNN;
        string MaNV;
        string TrinhDo;
        string NoiCap;
        DateTime NgayCap;
        [DataMember]
        public string mactnn
        {
            get { return MaCTNN; }
            set { MaCTNN = value; }
        }
        [DataMember]
        public string mann
        {
            get { return MaNN; }
            set { MaNN = value; }
        }
        [DataMember]
        public string manv
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        [DataMember]
        public string trinhdo
        {
            get { return TrinhDo; }
            set { TrinhDo = value; }
        }
        [DataMember]
        public DateTime ngaycap
        {
            get { return NgayCap; }
            set { NgayCap = value; }
        }
        [DataMember]
        public string noicap
        {
            get { return NoiCap; }
            set { NoiCap = value; }
        }
    }
}
