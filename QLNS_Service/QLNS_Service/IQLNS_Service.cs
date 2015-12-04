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
        //-------------------------------------------------------NHÂN VIÊN-----------------------------------------//
        [OperationContract]
        DataSet Load_NhanVien();
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
        DataSet Load_PhongBan();
        [OperationContract]
        string Add_PhongBan(Cls_PhongBan pb);
        [OperationContract]
        string Update_PhongBan(Cls_PhongBan pb);
        [OperationContract]
        string Delete_PhongBan(Cls_PhongBan pb);
        //-------------------------------------------------------TÔN GIÁO-----------------------------------------//
        [OperationContract]
        DataSet Load_TonGiao();
        [OperationContract]
        string Add_TonGiao(Cls_TonGiao tg);
        [OperationContract]
        string Update_TonGiao(Cls_TonGiao tg);
        [OperationContract]
        string Delete_TonGiao(Cls_TonGiao tg);
        //-------------------------------------------------------DÂN TỘC-----------------------------------------//
        [OperationContract]
        DataSet Load_DanToc();
        [OperationContract]
        string Add_DanToc(Cls_DanToc dt);
        [OperationContract]
        string Update_DanToc(Cls_DanToc dt);
        [OperationContract]
        string Delete_DanToc(Cls_DanToc dt);
        //-------------------------------------------------------CHỨC VỤ-----------------------------------------//
        [OperationContract]
        DataSet Load_ChucVu();
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
        string Add_HopDong(Cls_HopDong hd);
        //-------------------------------------------------------CHI TIẾT HỢP ĐỒNG-----------------------------------------//
        [OperationContract]
        string Add_CTHopDong(Cls_CTHopDong cthd);
        //-------------------------------------------------------PHÂN QUYỀN-----------------------------------------//
        [OperationContract]
        string Add_PhanQuyen(Cls_PhanQuyen pq);
        //-------------------------------------------------------NGƯỜI DÙNG-----------------------------------------//
        [OperationContract]
        string Add_NguoiDung(Cls_NguoiDung nd);
        //-------------------------------------------------------KĨ LUẬT-----------------------------------------//
        [OperationContract]
        string Add_KiLuat(Cls_KiLuat kl);
        //-------------------------------------------------------CHI TIẾT KĨ LUẬT-----------------------------------------//
        [OperationContract]
        string Add_CTKiLuat(Cls_CTKiLuat ctkl);
        //-------------------------------------------------------KHEN THƯỞNG-----------------------------------------//
        [OperationContract]
        string Add_KhenThuong(Cls_KhenThuong kt);
        //-------------------------------------------------------CHI TIẾT KHEN THƯỞNG-----------------------------------------//
        [OperationContract]
        string Add_CTKhenThuong(Cls_CTKhenThuong ctkt);
        //-------------------------------------------------------CHUYỂN CÔNG TÁC-----------------------------------------//
        [OperationContract]
        string Add_ChuyenCongTac(Cls_ChuyenCongTac cct);
        //-------------------------------------------------------ĐĂNG NHẬP-----------------------------------------//
        [OperationContract]
        DataSet ktDangNhap(Check_Login cl);
    }
}
