using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtra_nhom1.DAL.Entity
{
    class DS_Chitiet
    {
        public string TenNhom { get; set; }
        public string Tengoi { get; set; }
        public string Diachi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public static List<DS_Chitiet> GetListFromFile(string pathData, string tenNhom)
        {
            var arrayLines = File.ReadAllLines(pathData);
            List<DS_Chitiet> ketQua = new List<DS_Chitiet>();
            foreach (var line in arrayLines)
            {
                var lsValue = line.Split(new char[] { '#' });

                var DS_Chitiet = new DS_Chitiet
                {
                    Tengoi = lsValue[1],
                    Diachi = lsValue[2],
                    Email = lsValue[3],
                    SDT = lsValue[4],
                    TenNhom = lsValue[5],
                };
                if (DS_Chitiet.TenNhom == tenNhom)
                    ketQua.Add(DS_Chitiet);
            }
            return ketQua;
        }
    }
}
