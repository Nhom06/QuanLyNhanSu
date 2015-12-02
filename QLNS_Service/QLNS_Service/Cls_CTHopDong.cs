using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QLNS_Service
{
    [DataContract]
    public class Cls_CTHopDong
    {
        string SoHD;
        string MaLoaiHD;
        string MaNV;
        DateTime NgayBatDau;
        DateTime NgayKetThuc;
        float LuongCB;
        string MaCV;
        [DataMember]
        public string sohd
        {
            get { return SoHD; }
            set { SoHD = value; }
        }
        [DataMember]
        public string maloaihd
        {
            get { return MaLoaiHD; }
            set { MaLoaiHD = value; }
        }
        [DataMember]
        public string manv
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        [DataMember]
        public DateTime ngaybatdau
        {
            get { return NgayBatDau; }
            set { NgayBatDau = value; }
        }
        [DataMember]
        public DateTime ngayketthuc
        {
            get { return NgayKetThuc; }
            set { NgayKetThuc = value; }
        }
        [DataMember]
        public float luongcb
        {
            get { return LuongCB; }
            set { LuongCB = value; }
        }
        [DataMember]
        public string macv
        {
            get { return MaCV; }
            set { MaCV = value; }
        }
    }
}
