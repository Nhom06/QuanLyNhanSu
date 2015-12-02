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
        //-------------------------------------------------------TRÌNH ĐỘ-----------------------------------------//
        [OperationContract]
        string Add_TrinhDo(Cls_TrinhDo td);
        //-------------------------------------------------------CT TRÌNH ĐỘ-----------------------------------------//
        [OperationContract]
        string Add_CTTrinhDo(Cls_CTTrinhDo cttd);
        //-------------------------------------------------------NGOẠI NGỮ-----------------------------------------//
        [OperationContract]
        string Add_NgoaiNgu(Cls_NgoaiNgu nn);
        //-------------------------------------------------------CHI TIẾT NGOẠI NGỮ-----------------------------------------//
        [OperationContract]
        string Add_CTNgoaiNgu(Cls_CTNgoaiNgu ctnn);
        //-------------------------------------------------------PHÒNG BAN-----------------------------------------//
        [OperationContract]
        string Add_PhongBan(Cls_PhongBan pb);
        //-------------------------------------------------------TÔN GIÁO-----------------------------------------//
        [OperationContract]
        string Add_TonGiao(Cls_TonGiao tg);
        //-------------------------------------------------------DÂN TỘC-----------------------------------------//
        [OperationContract]
        string Add_DanToc(Cls_DanToc dt);
        //-------------------------------------------------------CHỨC VỤ-----------------------------------------//
        [OperationContract]
        string Add_ChucVu(Cls_ChucVu cv);
        //-------------------------------------------------------THAI SẢN-----------------------------------------//
        [OperationContract]
        string Add_ThaiSan(Cls_ThaiSan ts);
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
        //[OperationContract]
        /*bool ktDangNhap(Check_Login cl);*/
    }
}
