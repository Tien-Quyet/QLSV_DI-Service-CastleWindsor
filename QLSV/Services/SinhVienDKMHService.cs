using System;
using System.Text;
using QLSV.Models;
using QLSV.Interfaces.IServices;
using QLSV.Interfaces.IData;
using System.Collections.Generic;

namespace QLSV.Services
{
    internal class SinhVienDKMHService : ISinhVienDKMHService
    {
        private readonly ISinhVienDKMHData _svDKMHData;

        public SinhVienDKMHService(ISinhVienDKMHData sinhvienDKMHData)
        {
            _svDKMHData = sinhvienDKMHData;
        }
        public List<SinhVienDKMH> GetAll()
        {
            return _svDKMHData.GetAll();
        }

        //Hiển thị môn học sinh viên đăng kí
        public void SvDKMH()
        {
            Console.WriteLine("{0, -20} {1, -15}", "Tên SV", "Môn đăng kí");
            foreach (SinhVienDKMH x in _svDKMHData.GetAll())
            {
                Console.WriteLine("{0, -20} {1, -15}", x.TenSV, x.TenMH);
            }
        }
    }
}
