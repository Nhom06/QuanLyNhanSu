using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QLNS_Service
{
    [DataContract]
    public class Cls_CTTrinhDo
    {
        string MaCTTD = string.Empty;
        string MaNV = string.Empty;
        string MaTD = string.Empty;
        string ChuyenMon = string.Empty;
        DateTime NgayCap;
        string Truong = string.Empty;
        [DataMember]
        public string macttd
        {
            get { return MaCTTD; }
            set { MaCTTD = value; }
        }
        [DataMember]
        public string manv
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        [DataMember]
        public string matd
        {
            get { return MaTD; }
            set { MaTD = value; }
        }
        [DataMember]
        public string chuyenmon
        {
            get { return ChuyenMon; }
            set { ChuyenMon = value; }
        }
        [DataMember]
        public DateTime ngaycap
        {
            get { return NgayCap; }
            set { NgayCap = value; }
        }
        [DataMember]
        public string truong
        {
            get { return Truong; }
            set { Truong = value; }
        }
    }
}
