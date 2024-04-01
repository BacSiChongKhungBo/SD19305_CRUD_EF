using BUS.Repositories;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    // sửa internal class => public class
    public class NhanVienService
    {
        private NhanVienRepository repos;

        public NhanVienService()
        {
            repos = new NhanVienRepository();
        }
        // lấy toàn bộ danh sách nhân viên trong bảng ở DB
        public List<NhanVien> GetNhanViens(string search)
        {
            if(search == null || search == string.Empty) 
            {
                return repos.GetAll();
            }
            return repos.GetAll().FindAll(x => x.MaNv.Contains(search) || x.HoTen.Contains(search));

        }

        //thêm sửa xóa đều trả về string để thông báo bên PRL
        public string ThemNV(NhanVien nv)
        {
            if (repos.Add_NV(nv))
            {
                return "Thêm thành công";
            }
            //nếu ko thành công thì sẽ chạy code ở dưới
            return "Thêm thất bại";
        }

        public string SuaNV(NhanVien nv)
        {
            if (repos.Update_NV(nv))
            {
                return "Cập nhật thành công";
            }
            return "Cập nhật thất bại";
        }

        public string XoaNV(string ma)
        {
            var nv = repos.GetAll().Find(x => x.MaNv == ma);
            if (repos.Remove_NV(nv))
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }

    }
}
