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
    internal class MonHocFileData : IMonHocData
    {
        private string _folderPath;
        private string _filePath;

        public MonHocFileData()
        {
            _folderPath = Path.Combine(Directory.GetCurrentDirectory(), "FileData");
            _filePath = Path.Combine(_folderPath, "MonHoc.json");
        }

        //ghi file MonHoc.json
        public void Add(MonHoc monhoc)
        {
            if (!Directory.Exists(_folderPath))
                Directory.CreateDirectory(_folderPath);
            File.AppendAllLines(_filePath, new[] { JsonConvert.SerializeObject(monhoc) });
        }


        //lấy từ file MonHoc.json
        public List<MonHoc> GetAll()
        {
            List<MonHoc> list_mh = new List<MonHoc>();
            if (File.Exists(_filePath))
            {
                var MonHocStr = File.ReadAllLines(_filePath);
                foreach (var item in MonHocStr)
                {
                    list_mh.Add(JsonConvert.DeserializeObject<MonHoc>(item));
                }
            }

            return list_mh;
        }
    }
}
