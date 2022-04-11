using QLSV.Models;
using System.Collections.Generic;

namespace QLSV.Interfaces.IData
{
    internal interface ISinhVienData
    {
        void Add(SinhVien sinhvien);

        List<SinhVien> GetAll();
    }
}
