using System;
using System.Text;
using Castle.Windsor;
using QLSV.Models;
using QLSV.Services;
using QLSV.Interfaces.IServices;
using QLSV.Interfaces.IData;
using System.Collections.Generic;
using Castle.MicroKernel.Registration;
using QLSV.Data;

namespace QLSV
{
    public class Program
    {
        public static void Main(string[] args)
        {

            WindsorContainer container = new WindsorContainer();

            container.Register(Component.For<ISinhVienService>().ImplementedBy<SinhVienService>());
            container.Register(Component.For<ISinhVienData>().ImplementedBy<SinhVienFileData>());
            container.Register(Component.For<IMonHocService>().ImplementedBy<MonHocService>());
            container.Register(Component.For<IMonHocData>().ImplementedBy<MonHocFileData>());
            container.Register(Component.For<IBangDiemService>().ImplementedBy<BangDiemService>());
            container.Register(Component.For<IBangDiemData>().ImplementedBy<BangDiemFileData>());
            container.Register(Component.For<ISinhVienDKMHService>().ImplementedBy<SinhVienDKMHService>());
            container.Register(Component.For<ISinhVienDKMHData>().ImplementedBy<SinhVienDKMHFileData>());


            ISinhVienService sinhvienService = container.Resolve<ISinhVienService>();
            List<SinhVien> sinhvien = sinhvienService.GetAll();

            IMonHocService monhocService = container.Resolve<IMonHocService>();
            List<MonHoc> monhoc = monhocService.GetAll();

            IBangDiemService bangdiemService = container.Resolve<IBangDiemService>();
            List<BangDiem> bangdiem = bangdiemService.GetAll();

            ISinhVienDKMHService sinhvienDKMHService = container.Resolve<ISinhVienDKMHService>();
            List<SinhVienDKMH> DKMH = sinhvienDKMHService.GetAll();

            //SinhVienService svs = new SinhVienService();
            //BangDiemService bds = new BangDiemService();
            //MonHocService mhs = new MonHocService();
            //SinhVienDKMHService svdkmhs = new SinhVienDKMHService();
            BangDiem bd = new BangDiem();

            while (true)
            {
                Console.InputEncoding = Encoding.UTF8;
                Console.OutputEncoding = Encoding.UTF8;
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine("***************************************************");
                Console.WriteLine("**               Chọn chức năng:                 **");
                Console.WriteLine("**                                               **");
                Console.WriteLine("**       1: Nhập thông tin                       **");
                Console.WriteLine("**       2: Danh sách sinh viên                  **");
                Console.WriteLine("**       3: Chi tiết sinh viên                   **");
                Console.WriteLine("**       4: Nhập điểm sinh viên                  **");
                Console.WriteLine("**       5: Xem điểm sinh viên                   **");
                Console.WriteLine("**       6: Xem số môn học sinh viên đăng kí     **");
                Console.WriteLine("**       7: Xem kết quả đỗ/trượt                 **");
                Console.WriteLine("**       8: Hiển thị danh sách môn học           **");
                Console.WriteLine("**       9: Thêm môn học                         **");
                Console.WriteLine("**       10: Hiển thị môn học                    **");
                Console.WriteLine("**       11: Nhập bảng điểm                      **");
                Console.WriteLine("***************************************************");
                Console.ResetColor();

                int x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        sinhvien.Add(sinhvienService.NhapSV());
                        break;

                    case 2:
                        sinhvienService.showListSV();
                        break;

                    case 3:

                        sinhvienService.detailSV();
                        break;

                    case 4:
                        bangdiemService.NhapDiem();
                        break;

                    case 5:
                        bangdiemService.ShowDiem();                       
                        break;

                    case 6:
                         sinhvienDKMHService.SvDKMH();
                       // svdkmhs.svDKMH();
                        break;

                    case 7:
                       // bangdiemService.TinhDTB(bd);
                        bangdiemService.XepLoai(bd);
                       // bds.XepLoai(bd);
                        break;

                    case 8:
                        //var r_d = File.ReadAllText(filePath_mh);
                        //List<MonHoc> lm = JsonConvert.DeserializeObject<List<MonHoc>>(r_d);

                        //foreach (MonHoc mh_print in lm)
                        //{
                        //    Console.WriteLine("{0}\t{1}", mh_print.TenMon, mh_print.SoTiet);

                        //}
                        //Console.WriteLine("\n");
                        break;
                    case 9:
                        //mhs.Input();

                        break;

                    case 10:
                        // mhs.showMH();
                        break;
                    case 11:
                        //Console.OutputEncoding = Encoding.Unicode;
                        //Console.InputEncoding = Encoding.Unicode;

                        ///*BangDiem bd = BangDiemService.NhapDiem();
                        //list_sv.Add(bd);
                        //string js_sv = JsonConvert.SerializeObject(list_sv);
                        //File.WriteAllText(filePath_sv, js_sv);*/
                        break;
                }
            }
        }
    }
}
