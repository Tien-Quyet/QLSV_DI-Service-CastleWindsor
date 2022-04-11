using System;
using System.Collections.Generic;
using System.Text;
using QLSV.Models;
using QLSV.Interfaces.IServices;
using QLSV.Interfaces.IData;

namespace QLSV.Services
{
    internal class SinhVienService : ISinhVienService
    {
        private readonly ISinhVienData _sinhvienData;
        public SinhVienService(ISinhVienData sinhVienData)
        {
            _sinhvienData = sinhVienData;
        }

        public List<SinhVien> GetAll()
        {
            return _sinhvienData.GetAll();
        }
   


        //Nhập thông tin sinh viên
        public SinhVien NhapSV()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            var sv = new SinhVien();

            Console.WriteLine("Nhập mã sinh viên:");
            sv.MaSV = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập họ tên sinh viên:");
            sv.Ten = Console.ReadLine();
            Console.WriteLine("Nhập giới tính sinh viên:");
            sv.GioiTinh = Console.ReadLine();
            Console.WriteLine("Nhập năm sinh sinh viên:");
            sv.NamSinh = Console.ReadLine();
            Console.WriteLine("Nhập lớp sinh viên:");
            sv.Lop = Console.ReadLine();
            Console.WriteLine("Nhập khóa sinh viên:");
            sv.Khoa = Console.ReadLine();

            _sinhvienData.Add(sv);

            return sv;
        }


        //Hiển thị sinh viên
        public void showListSV()
        {
            
            Console.WriteLine("{0, -5} {1, -20} {2, -10} {3, -10}", "ID", "Tên", "Giới tính", "Lớp");            
            foreach (SinhVien s in _sinhvienData.GetAll())
            {
                Console.WriteLine("{0, -5} {1, -20} {2, -10} {3, -10}", s.MaSV, s.Ten, s.GioiTinh, s.Lop);
            }
        }

        //Hiển thị chi tiết sinh viên
        public void detailSV()
        {
            Console.WriteLine("{0, -5} {1, -20} {2, -10} {3, -10} {4, -10} {5, -10}", "ID", "Tên", "Giới tính", "Năm sinh", "Lớp", "Khóa");
            foreach (SinhVien s in  _sinhvienData.GetAll())
            {
                Console.WriteLine("{0, -5} {1, -20} {2, -10} {3, -10} {4, -10} {5, -10}", s.MaSV, s.Ten, s.GioiTinh, s.NamSinh, s.Lop, s.Khoa);
            }
        }
    }
}
