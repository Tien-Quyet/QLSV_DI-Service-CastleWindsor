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
    internal class BangDiemFileData : IBangDiemData
    {
        private string _folderPath;
        private string _filePath;

        public BangDiemFileData()
        {
            _folderPath = Path.Combine(Directory.GetCurrentDirectory(), "FileData");
            _filePath = Path.Combine(_folderPath, "BangDiem.json");
        }

        //ghi file BangDiem.json
        public void Add(BangDiem bangdiem)
        {
            if (!Directory.Exists(_folderPath))
                Directory.CreateDirectory(_folderPath);
            File.AppendAllLines(_filePath, new[] { JsonConvert.SerializeObject(bangdiem) });
        }


        //lấy từ file BangDiem.txt
        public List<BangDiem> GetAll()
        {
            List<BangDiem> list_bd = new List<BangDiem>();
            if (File.Exists(_filePath))
            {
                var BangDiemStr = File.ReadAllLines(_filePath);
                foreach (var item in BangDiemStr)
                {
                    list_bd.Add(JsonConvert.DeserializeObject<BangDiem>(item));
                }
            }

            return list_bd;
        }
    }
}
