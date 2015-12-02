using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QLNS_Service
{
    [DataContract]
    public class Cls_CTKiLuat
    {
        string MaCTKL;
        string MaKL;
        string MaNV;
        DateTime NgayKL;
        string HinhThuc;
        string NguyenNhan;
        [DataMember]
        public string mactkl
        {
            get { return MaCTKL; }
            set { MaCTKL = value; }
        }
        [DataMember]
        public string makl
        {
            get { return MaKL; }
            set { MaKL = value; }
        }
        [DataMember]
        public string manv
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        [DataMember]
        public DateTime ngaykl
        {
            get { return NgayKL; }
            set { NgayKL = value; }
        }
        [DataMember]
        public string hinhthuc
        {
            get { return HinhThuc; }
            set { HinhThuc = value; }
        }
        [DataMember]
        public string nguyennhan
        {
            get { return NguyenNhan; }
            set { NguyenNhan = value; }
        }
    }
}
