using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QLNS_Service
{
    [DataContract]
    public class Cls_ChuyenCongTac
    {
        string MaChuyen;
        string MaNV;
        DateTime NgayChuyen;
        string MaCVCu;
        string MaPBCu;
        string MaCVMoi;
        string MaPBMoi;
        [DataMember]
        public string machuyen
        {
            get { return MaChuyen; }
            set { MaChuyen = value; }
        }
        [DataMember]
        public string manv
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        [DataMember]
        public DateTime ngaychuyen
        {
            get { return NgayChuyen; }
            set { NgayChuyen = value; }
        }
        [DataMember]
        public string macvcu
        {
            get { return MaCVCu; }
            set { MaCVCu = value; }
        }
        [DataMember]
        public string mapbcu
        {
            get { return MaPBCu; }
            set { MaPBCu = value; }
        }
        [DataMember]
        public string macvmoi
        {
            get { return MaCVMoi; }
            set { MaCVMoi = value; }
        }
        [DataMember]
        public string mapbmoi
        {
            get { return MaPBMoi; }
            set { MaPBMoi = value; }
        }
    }
}
