using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using QLSV.Models;
using QLSV.Interfaces.IData;

namespace QLSV.Data
{
    internal class SinhVienDKMHFileData : ISinhVienDKMHData
    {
        private string _folderPath;
        private string _filePath;

        public SinhVienDKMHFileData()
        {
            _folderPath = Path.Combine(Directory.GetCurrentDirectory(), "FileData");
            _filePath = Path.Combine(_folderPath, "SinhVienDKMH.json");
        }

        //ghi file SinhvienDKMH.json
        public void Add(SinhVienDKMH svDKMH)
        {
            if (!Directory.Exists(_folderPath))
                Directory.CreateDirectory(_folderPath);
            File.AppendAllLines(_filePath, new[] { JsonConvert.SerializeObject(svDKMH) });
        }


        //lấy từ file SinhVien.txt
        public List<SinhVienDKMH> GetAll()
        {
            List<SinhVienDKMH> list_svDKMH = new List<SinhVienDKMH>();
            if (File.Exists(_filePath))
            {
                var svDKMHStr = File.ReadAllLines(_filePath);
                foreach (var item in svDKMHStr)
                {
                    list_svDKMH.Add(JsonConvert.DeserializeObject<SinhVienDKMH>(item));
                }
            }

            return list_svDKMH;
        }
    }
}
