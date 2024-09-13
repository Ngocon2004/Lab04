using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212363
{
    public class SinhVien
    {
        public string Maso {  get; set; }
        public string HoTen {  get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email {  get; set; }
        public string DiaChi { get; set; }
        public string Phai { get; set;}
        public string SoDT { get; set;}
        public string Lop { get; set;}
        public string Hinh { get; set;}
        public SinhVien(string maso, string hoTen, DateTime ngaySinh, string email, string diaChi, string phai, string soDT, string lop, string hinh)
        {
            Maso = maso;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            Email = email;
            DiaChi = diaChi;
            Phai = phai;
            SoDT = soDT;
            Lop = lop;
            Hinh = hinh;
        }
    }
}
