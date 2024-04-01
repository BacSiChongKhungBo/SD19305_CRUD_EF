using DAL.Context;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Repositories
{
    internal class NhanVienRepository
    {
        private DBContext context;

        public NhanVienRepository()
        {
            context = new DBContext();
        }
        
        // CRUD: CREATE | READ | UPDATE | DELETE
        // 1. READ
        public List<NhanVien> GetAll()
        {
            return context.NhanViens.ToList();
            //vào CSDL, tất cả dữ liệu trong bảng Nhanvien
            //chuyển thành list
        }

        public bool Add_NV(NhanVien nv)
        {
            if(nv == null)
            {
                return false;
            }
            context.NhanViens.Add(nv);
            context.SaveChanges(); // lưu thay đổi ( ko có => DB ko đổi)
            return true;
        }

        public bool Update_NV(NhanVien nv)
        {
            if (nv == null)
            {
                return false;
            }
            context.NhanViens.Update(nv);
            context.SaveChanges(); // lưu thay đổi ( ko có => DB ko đổi)
            return true;
        }

        public bool Remove_NV(NhanVien nv)
        {
            if (nv == null)
            {
                return false;
            }
            context.NhanViens.Remove(nv);
            context.SaveChanges(); // lưu thay đổi ( ko có => DB ko đổi)
            return true;
        }
    }
}
