using System;
using System.Collections.Generic;
using System.Text;
using QLSV.Models;
using QLSV.Data;
using QLSV.Interfaces.IServices;
using QLSV.Interfaces.IData;

namespace QLSV.Services
{

    internal class BangDiemService : IBangDiemService
    {
        private readonly IBangDiemData _bangdiemData;

        public BangDiemService(IBangDiemData bangdiemData)
        {
            _bangdiemData = bangdiemData;
        }
        public List<BangDiem> GetAll()
        {
            return _bangdiemData.GetAll();
        }

        //Nhập điểm
        public BangDiem NhapDiem()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            BangDiem bd = new BangDiem();

            Console.WriteLine("Nhập mã sinh viên:");
            bd.MaSV = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập tên sinh viên:");
            bd.TenSV = Console.ReadLine();
            Console.WriteLine("Nhập tên môn học:");
            bd.TenMH = Console.ReadLine();
            Console.WriteLine("Nhập điểm quá trình:");
            bd.DiemQT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập điểm thành phần:");
            bd.DiemTP = Convert.ToDouble(Console.ReadLine());

            _bangdiemData.Add(bd);

            return bd;
        }


        //Hiển thị điểm
        public void ShowDiem()
        {
            Console.WriteLine("{0, -20} {1, -20} {2, -10} {3, -10}", "Tên SV", "Môn học", "Điểm QT", "Điểm TP");
            foreach (BangDiem d in _bangdiemData.GetAll())
            {
                Console.WriteLine("{0, -20} {1, -20} {2, -10} {3, -10}", d.TenSV, d.TenMH, d.DiemQT, d.DiemTP);
            }
        }


        //Tính điểm trung bình
        public void TinhDTB(BangDiem bd)
        {
            _bangdiemData.GetAll();
            foreach (BangDiem d in _bangdiemData.GetAll())
            {
                d.DTK = (d.DiemQT + d.DiemTP) / 2;
                //Console.WriteLine("{0}", d.DTK);

                _bangdiemData.Add(d);
            }

        }

        // Hiển thị kết quả Đạt/Trượt
        public void XepLoai(BangDiem bd)
        {
            Console.WriteLine("{0, -5} {1, -20} {2, -20} {3, -10} {4, -10} {5, -10} {6, -10}", "ID", "Tên", "Môn học", "Điểm QT", "Điểm TP", "DTK", "Xếp loại");

            
            foreach (BangDiem d in _bangdiemData.GetAll())
            {

                if (d.DTK >= 4)
                {
                    d.HocLuc = "Đạt";
                }
                else
                {
                    d.HocLuc = "Trượt";
                }

                Console.WriteLine("{0, -5} {1, -20} {2, -20} {3, -10} {4, -10} {5, -10} {6, -10}", d.MaSV, d.TenSV, d.TenMH, d.DiemQT, d.DiemTP, d.DTK, d.HocLuc);
                _bangdiemData.Add(d);
            }
        }
    }
}

