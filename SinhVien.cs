using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
   
    internal class SinhVien
    {
     
        public bool Phai { get; set; }
       public  DateTime ngaySinh { get; set; }
        public string Lop { get; set; }
        public  string sdt { get; set; }
        public string email { set; get; }
        public  string Diachi { get; set; }
        public  string Hinh { get; set; }
        public string mssv { get; set; }
        public string hoten { get; set; }
       public SinhVien() { }
       public SinhVien(string ma,string hoten,string email,bool phai,DateTime ngay,string lop,string sdt,string dc,string hinh)
        {
            this.mssv = ma;
            this.hoten = hoten;
            this.email = email;
            this.Phai = phai;
            this.ngaySinh = ngay;
            this.Lop = lop;
            this.sdt = sdt;
            this.Diachi = dc;
            this.Hinh = hinh;
        }
    }
}
