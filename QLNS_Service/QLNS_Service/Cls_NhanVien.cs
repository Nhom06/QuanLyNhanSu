using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QLNS_Service
{
    [DataContract]
    public class Cls_NhanVien
    {
        string MaNV;
        string HoTen;
        string GioiTinh;
        DateTime NgaySinh;
        string NoiSinh;
        string SoCMND;
        string MaTG;
        string MaDT;
        string MaPB;
        string MaCV;
        string DienThoai;
        string HoKhau;
        DateTime NgayVaoLam;
        string ChoOHienNay;
        string SoBHYT;
        string SoTheATM;
        [DataMember]
        public string manv 
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        [DataMember]
        public string hoten 
        {
            get { return HoTen; }
            set { HoTen = value; }
        }
        [DataMember]
        public string gioitinh 
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }
        [DataMember]
        public DateTime ngaysinh 
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }
        [DataMember]
        public string noisinh 
        {
            get { return NoiSinh; }
            set { NoiSinh = value; }
        }
        [DataMember]
        public string socmnd
        { 
            get { return SoCMND; }
            set { SoCMND = value; }
        }
        [DataMember]
        public string matg 
        {
            get { return MaTG; }
            set { MaTG = value; } 
        }
        [DataMember]
        public string madt 
        {
            get { return MaDT; }
            set { MaDT = value; } 
        }
        [DataMember]
        public string mapb
        {
            get { return MaPB; }
            set { MaPB = value; }
        }
        [DataMember]
        public string macv 
        {
            get { return MaCV; }
            set { MaCV = value; } 
        }
        [DataMember]
        public string dienthoai 
        {
            get { return DienThoai; }
            set { DienThoai = value; } 
        }
        [DataMember]
        public string hokhau 
        {
            get { return HoKhau; }
            set { HoKhau = value; } 
        }
        [DataMember]
        public DateTime ngayvaolam 
        {
            get { return NgayVaoLam; }
            set { NgayVaoLam = value; } 
        }
        [DataMember]
        public string choohiennay 
        {
            get { return ChoOHienNay; }
            set { ChoOHienNay = value; } 
        }
        [DataMember]
        public string sobhyt 
        {
            get { return SoBHYT; }
            set { SoBHYT = value; } 
        }
        [DataMember]
        public string sotheatm 
        {
            get { return SoTheATM; }
            set { SoTheATM = value; }
        }
    }
}
