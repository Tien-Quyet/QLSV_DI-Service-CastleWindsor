using QLSV.Models;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace QLSV.Interfaces.IServices
{
    internal interface ISinhVienService
    {
        List<SinhVien> GetAll();
        SinhVien NhapSV();
        void showListSV();
        void detailSV();
        
    }
}
