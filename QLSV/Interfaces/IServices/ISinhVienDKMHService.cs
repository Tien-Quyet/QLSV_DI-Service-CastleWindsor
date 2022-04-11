using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.Models;

namespace QLSV.Interfaces.IServices
{
    internal interface ISinhVienDKMHService
    {
        List<SinhVienDKMH> GetAll();
        void SvDKMH();

    }
}
