using System.Collections.Generic;
using QLSV.Models;

namespace QLSV.Interfaces.IServices
{
    internal interface IMonHocService
    {
        List<MonHoc> GetAll();
        MonHoc Input();
        void showMH();
    }
}
