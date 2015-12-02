using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QLNS_Service
{
    [DataContract]
    public class Cls_CTKhenThuong
    {
        string SoQD;
        string MaNV;
        DateTime NgayQD;
        string MaLoai;
        string NoiDung;
        string HinhThuc;
        [DataMember]
        public string soqd
        {
            get { return SoQD; }
            set { SoQD = value; }
        }
        [DataMember]
        public string manv
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        [DataMember]
        public DateTime ngayqd
        {
            get { return NgayQD; }
            set { NgayQD = value; }
        }
        [DataMember]
        public string maloai
        {
            get { return MaLoai; }
            set { MaLoai = value; }
        }
        [DataMember]
        public string noidung
        {
            get { return NoiDung; }
            set { NoiDung = value; }
        }
        [DataMember]
        public string hinhthuc
        {
            get { return HinhThuc; }
            set { HinhThuc = value; }
        }
    }
}
