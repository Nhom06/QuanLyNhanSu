using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QLNS_Service
{
    [DataContract]
    public class Cls_ThaiSan
    {
        string MaTS;
        string MaNV;
        DateTime NgayNghiSinh;
        DateTime NgayTroLai;
        float TroCapCongTy;
        [DataMember]
        public string mats
        {
            get { return MaTS; }
            set { MaTS = value; }
        }
        [DataMember]
        public string manv
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        [DataMember]
        public DateTime ngaynghisinh
        {
            get { return NgayNghiSinh; }
            set { NgayNghiSinh = value; }
        }
        [DataMember]
        public DateTime ngaytrolai
        {
            get { return NgayTroLai; }
            set { NgayTroLai = value; }
        }
        [DataMember]
        public float trocapcongty
        {
            get { return TroCapCongTy; }
            set { TroCapCongTy = value; }
        }
    }
}
