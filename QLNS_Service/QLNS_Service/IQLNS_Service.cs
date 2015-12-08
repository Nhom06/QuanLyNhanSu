using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;


namespace QLNS_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IQLNS_Service" in both code and config file together.
    [ServiceContract]
    public interface IQLNS_Service
    {
        [OperationContract]
        void myconnect();
        //-------------------------------------------------------NHÂN VIÊN-----------------------------------------//
        [OperationContract]
        DataSet Load_NhanVien(string tenbang);
        [OperationContract]
        string Add_NhanVien(Cls_NhanVien nv);
        [OperationContract]
        string Update_NhanVien(Cls_NhanVien nv);
        [OperationContract]
        string Delete_NhanVien(Cls_NhanVien nv);
        //-------------------------------------------------------TRÌNH ĐỘ-----------------------------------------//
        [OperationContract]
        DataSet Load_TrinhDo();
        [OperationContract]
        string Add_TrinhDo(Cls_TrinhDo td);
        [OperationContract]
        string Update_TrinhDo(Cls_TrinhDo td);
        [OperationContract]
        string Delete_TrinhDo(Cls_TrinhDo td);
        //-------------------------------------------------------CT TRÌNH ĐỘ-----------------------------------------//
        [OperationContract]
        DataSet Load_CTTrinhDo();
        [OperationContract]
        string Add_CTTrinhDo(Cls_CTTrinhDo cttd);
        [OperationContract]
        string Update_CTTrinhDo(Cls_CTTrinhDo cttd);
        [OperationContract]
        string Delete_CTTrinhDo(Cls_CTTrinhDo cttd);
        //-------------------------------------------------------NGOẠI NGỮ-----------------------------------------//
        [OperationContract]
        DataSet Load_NgoaiNgu();
        [OperationContract]
        string Add_NgoaiNgu(Cls_NgoaiNgu nn);
        [OperationContract]
        string Update_NgoaiNgu(Cls_NgoaiNgu nn);
        [OperationContract]
        string Delete_NgoaiNgu(Cls_NgoaiNgu nn);
        //-------------------------------------------------------CHI TIẾT NGOẠI NGỮ-----------------------------------------//
        [OperationContract]
        DataSet Load_CTNgoaiNgu();
        [OperationContract]
        string Add_CTNgoaiNgu(Cls_CTNgoaiNgu ctnn);
        [OperationContract]
        string Update_CTNgoaiNgu(Cls_CTNgoaiNgu ctnn);
        [OperationContract]
        string Delete_CTNgoaiNgu(Cls_CTNgoaiNgu ctnn);
        //-------------------------------------------------------PHÒNG BAN-----------------------------------------//
        [OperationContract]
        DataSet Load_PhongBan( string tenbang);
        [OperationContract]
        string Add_PhongBan(Cls_PhongBan pb);
        [OperationContract]
        string Update_PhongBan(Cls_PhongBan pb);
        [OperationContract]
        string Delete_PhongBan(Cls_PhongBan pb);
        //-------------------------------------------------------CHỨC VỤ-----------------------------------------//
        [OperationContract]
        DataSet Load_ChucVu(string tenbang);
        [OperationContract]
        string Add_ChucVu(Cls_ChucVu cv);
        [OperationContract]
        string Update_ChucVu(Cls_ChucVu cv);
        [OperationContract]
        string Delete_ChucVu(Cls_ChucVu cv);
        //-------------------------------------------------------THAI SẢN-----------------------------------------//
        [OperationContract]
        DataSet Load_ThaiSan();
        [OperationContract]
        string Add_ThaiSan(Cls_ThaiSan ts);
        [OperationContract]
        string Update_ThaiSan(Cls_ThaiSan ts);
        [OperationContract]
        string Delete_ThaiSan(Cls_ThaiSan ts);
        //-------------------------------------------------------HỢP ĐỒNG-----------------------------------------//
        [OperationContract]
        DataSet Load_HopDong( string tenbang);
        [OperationContract]
        string Add_HopDong(Cls_HopDong hd);
        [OperationContract]
        string Update_HopDong(Cls_HopDong hd);
        [OperationContract]
        string Delete_HopDong(Cls_HopDong hd);
        //-------------------------------------------------------CHI TIẾT HỢP ĐỒNG-----------------------------------------//
        [OperationContract]
        DataSet Load_CTHopDong();
        [OperationContract]
        string Add_CTHopDong(Cls_CTHopDong cthd);
        [OperationContract]
        string Update_CTHopDong(Cls_CTHopDong cthd);
        [OperationContract]
        string Delete_CTHopDong(Cls_CTHopDong cthd);
        //-------------------------------------------------------PHÂN QUYỀN-----------------------------------------//
        [OperationContract]
        DataSet Load_PhanQuyen();
        [OperationContract]
        string Add_PhanQuyen(Cls_PhanQuyen pq);
        [OperationContract]
        string Update_PhanQuyen(Cls_PhanQuyen pq);
        [OperationContract]
        string Delete_PhanQuyen(Cls_PhanQuyen pq);
        //-------------------------------------------------------NGƯỜI DÙNG-----------------------------------------//
        [OperationContract]
        DataSet Load_NguoiDung();
        [OperationContract]
        string Add_NguoiDung(Cls_NguoiDung nd);
        [OperationContract]
        string Update_NguoiDung(Cls_NguoiDung nd);
        [OperationContract]
        string Delete_NguoiDung(Cls_NguoiDung nd);
        //-------------------------------------------------------KĨ LUẬT-----------------------------------------//
        [OperationContract]
        DataSet Load_KiLuat();
        [OperationContract]
        string Add_KiLuat(Cls_KiLuat kl);
        [OperationContract]
        string Update_KiLuat(Cls_KiLuat kl);
        [OperationContract]
        string Delete_KiLuat(Cls_KiLuat kl);
        //-------------------------------------------------------CHI TIẾT KĨ LUẬT-----------------------------------------//
        [OperationContract]
        DataSet Load_CTKiLuat();
        [OperationContract]
        string Add_CTKiLuat(Cls_CTKiLuat ctkl);
        [OperationContract]
        string Update_CTKiLuat(Cls_CTKiLuat ctkl);
        [OperationContract]
        string Delete_CTKiLuat(Cls_CTKiLuat ctkl);
        //-------------------------------------------------------KHEN THƯỞNG-----------------------------------------//
        [OperationContract]
        DataSet Load_KhenThuong();
        [OperationContract]
        string Add_KhenThuong(Cls_KhenThuong kt);
        [OperationContract]
        string Update_KhenThuong(Cls_KhenThuong kt);
        [OperationContract]
        string Delete_KhenThuong(Cls_KhenThuong kt);
        //-------------------------------------------------------CHI TIẾT KHEN THƯỞNG-----------------------------------------//
        [OperationContract]
        DataSet Load_CTKhenThuong();
        [OperationContract]
        string Add_CTKhenThuong(Cls_CTKhenThuong ctkt);
        [OperationContract]
        string Update_CTKhenThuong(Cls_CTKhenThuong ctkt);
        [OperationContract]
        string Delete_CTKhenThuong(Cls_CTKhenThuong ctkt);
        //-------------------------------------------------------CHUYỂN CÔNG TÁC-----------------------------------------//
        [OperationContract]
        DataSet Load_ChuyenCongTac();
        [OperationContract]
        string Add_ChuyenCongTac(Cls_ChuyenCongTac cct);
        [OperationContract]
        string Update_ChuyenCongTac(Cls_ChuyenCongTac cct);
        [OperationContract]
        string Delete_ChuyenCongTac(Cls_ChuyenCongTac cct);
        //-------------------------------------------------------ĐĂNG NHẬP-----------------------------------------//
        /*
        [OperationContract]
        bool ktDangNhap(string user, string pass);
         * */
    }
}
