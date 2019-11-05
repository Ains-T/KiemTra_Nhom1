using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtra_nhom1.DAL.Entity
{
    class DS_DanhBa
    {
        public string TenNhom
        {
            get;
            set;
        }

        public static List<DS_DanhBa> GetListFromFile(string pathData)
        {
            var arrayLines = File.ReadAllLines(pathData);
            List<DS_DanhBa> hienthi = new List<DS_DanhBa>();
            foreach (var line in arrayLines)
            {
                var lsValue = line.Split(new char[] { '#' });
                var nhom = new DS_DanhBa
                {
                    TenNhom = lsValue[1],
                };
                hienthi.Add(nhom);
            }
            return hienthi;
        }
    }
}
