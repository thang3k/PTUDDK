using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lab4
{
    public delegate int SoSanh(object sv1, object sv2);
    internal class QuanlySV
    {
        public List<SinhVien> qlsv = new List<SinhVien>();
        public SinhVien this[int index]
        {
            get { return qlsv[index]; }
            set { qlsv[index] = value; }
        }
        public void Them(SinhVien sv)
        {
            this.qlsv.Add(sv);
        }
        public void Xoa(SinhVien sv)
        {
            this.qlsv.Remove(sv);
        }
        public void DocFile()
        {
            string filename = " ", t;
            string[] s;
            SinhVien sv;
            StreamReader sr=new StreamReader(new FileStream(filename, FileMode.Open));
            while((t=sr.ReadLine()) != null)
            {
                s = t.Split('*');
                sv=new SinhVien();
                sv.mssv = s[0];
                sv.hoten = s[1];
                sv.email = s[2];
               sv.Diachi = s[3];
                sv.ngaySinh =DateTime.ParseExact( s[4],"dd/MM/yyyy",CultureInfo.InvariantCulture);
                sv.Phai = false;
                if (s[5]=="1")
                {
                    sv.Phai = true;
                }
                else sv.Phai = false;
                sv.sdt = s[6];
                sv.Hinh = s[7];
                this.Them(sv);
            }
        }

    }
}
