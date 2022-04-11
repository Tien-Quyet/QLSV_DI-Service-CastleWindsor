using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.Models;
namespace QLSV.Interfaces.IData
{
    internal interface IMonHocData
    {
        void Add(MonHoc monHoc);

        List<MonHoc> GetAll();
    }
}
