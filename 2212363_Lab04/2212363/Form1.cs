using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2212363
{
    public partial class Form1 : Form
    {
        QLSinhVien qlsv;
        public Form1()
        {
            InitializeComponent();
        }
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> cn = new List<string>();
            sv.Maso = this.txtMSSV.Text;
            sv.HoTen = this.txtHoVaTen.Text;
            sv.NgaySinh = this.datNgaySinh.Value;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Lop = this.cboLop.Text;
            sv.Hinh = this.txtHinh.Text;
            if (rdNu.Checked)
                gt = false;
            sv.Phai = false;
            return sv;

        }
 //Lấy thông tin sinh viên từ dòng item của ListView
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.Maso = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);
            sv.DiaChi = lvitem.SubItems[3].Text;
            sv.Lop = lvitem.SubItems[4].Text;
            sv.Phai = false;
            if (lvitem.SubItems[5].Text == "Nam")
                sv.Phai = true;
            List<string> cn = new List<string>();
            sv.Hinh = lvitem.SubItems[7].Text;
            return sv;
        }
       

        private void ThietLapThongTin(SinhVien sv)
        {
            this.txtMSSV.Text = sv.Maso;
            this.txtHoVaTen.Text = sv.HoTen;
            this.datNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cboLop.Text = sv.Lop;
            this.txtHinh.Text = sv.Hinh;
            this.pbHinh.ImageLocation = sv.Hinh;
            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;
        }
            private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bntChonHinh_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
