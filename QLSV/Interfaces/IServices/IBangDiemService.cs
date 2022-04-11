using QLSV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Interfaces.IServices
{
    internal interface IBangDiemService
    {
        List<BangDiem> GetAll();
        BangDiem NhapDiem();
        void ShowDiem();
        void TinhDTB(BangDiem bd);
        void XepLoai(BangDiem bd);


    }
}
