using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using QLSV.Models;
using QLSV.Interfaces.IData;

namespace QLSV.Data
{
    internal class SinhVienFileData : ISinhVienData
    {
        private string _folderPath;
        private string _filePath;

        public SinhVienFileData()
        {
            _folderPath = Path.Combine(Directory.GetCurrentDirectory(), "FileData");
            _filePath = Path.Combine(_folderPath, "SinhVien.json");
        }

        //ghi file Sinhvien.json
        public void Add(SinhVien sinhVien)
        {
            if (!Directory.Exists(_folderPath))
                Directory.CreateDirectory(_folderPath);
            File.AppendAllLines(_filePath, new[] { JsonConvert.SerializeObject(sinhVien) });
        }


        //lấy từ file SinhVien.txt
        public List<SinhVien> GetAll()
        {
            List<SinhVien> list_sv = new List<SinhVien>();
            if (File.Exists(_filePath))
            {
                var SinhVenStr = File.ReadAllLines(_filePath);
                foreach (var item in SinhVenStr)
                {
                    list_sv.Add(JsonConvert.DeserializeObject<SinhVien>(item));
                }
            }

            return list_sv;
        }
    }
}
