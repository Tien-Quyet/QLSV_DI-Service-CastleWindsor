using System;
using System.Text;
using QLSV.Models;
using QLSV.Interfaces.IServices;
using QLSV.Interfaces.IData;
using System.Collections.Generic;

namespace QLSV.Services
{
    internal class MonHocService : IMonHocService
    {

        private readonly IMonHocData _monhocData;
        public MonHocService(IMonHocData monhocData)
        {
            _monhocData = monhocData;
        }

        public List<MonHoc> GetAll()
        {
            return _monhocData.GetAll();
        }

        //Nhập môn học
        public MonHoc Input()
        {
            var mh = new MonHoc();

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Nhập tên môn học:");
            mh.TenMon = Console.ReadLine();
            Console.WriteLine("Nhập số tiết:");
            mh.SoTiet = Convert.ToInt32(Console.ReadLine());

            _monhocData.Add(mh);
            return mh;
        }

        public void showMH()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("{0, -20} {1, -10}", "Môn học", "Số tiết");
            foreach(var mh in _monhocData.GetAll())
            {
                Console.WriteLine("{0, -20} {1, -10}", mh.TenMon, mh.SoTiet);
            }
        }
    }
}
