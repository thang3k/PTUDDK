using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        QuanlySV qlsv;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private SinhVien GetSinhVien()
        {
            SinhVien sv=new SinhVien();
            bool phai = false;
            sv.mssv = this.msktbMSSV.Text;
            sv.hoten=this.txtHoten.Text;
            sv.email=this.txtEmail.Text;
            sv.Diachi=this.txtDiachi.Text;
            sv.email=this.txtEmail.Text;
            sv.ngaySinh = this.dtpNgsinh.Value;
            sv.Lop = this.cbLop.Text;
            sv.sdt=this.msktbSDT.Text;
            sv.Hinh=this.txtHinh.Text;
            if(rbNam.Checked)
                phai = true;
            sv.Phai = phai;
            return sv;
        }
        private void ThemSV(SinhVien sv)
        {
            ListViewItem listView =new ListViewItem(sv.mssv);
            listView.SubItems.Add(sv.hoten);
            listView.SubItems.Add(sv.email);
            listView.SubItems.Add(sv.Diachi);
            listView.SubItems.Add(sv.ngaySinh.ToShortTimeString());
            string gt = "Nữ";
            if (sv.Phai)
                gt = "Nam";
            listView.SubItems.Add(gt);
            listView.SubItems.Add(sv.Lop);
            listView.SubItems.Add(sv.sdt);
            listView.SubItems.Add(sv.Hinh);
            this.lvDSSV.Items.Add(listView);
        }
       private  void LoadListView()
        {
            this.lvDSSV.Items.Clear();
            foreach (SinhVien sv in qlsv.da)
            {

            }
        }
    }
}
