using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Module
{
    internal class SinhVien
    {
        public string Masv { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public SinhVien()
        {
        }

        public SinhVien(string masv, string name, int age)
        {
            Masv = masv;
            Name = name;
            Age = age;
        }
    }
}
