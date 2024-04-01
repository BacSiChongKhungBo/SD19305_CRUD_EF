using BUS.Services;
using DAL.DomainClass;
using System;

namespace PRL
{
    public partial class Form1 : Form
    {
        private NhanVienService service;
        private string idWhenClick; //biến toàn cục, dùng dc mọi nơi trong class
        public Form1()
        {
            InitializeComponent();
            service = new NhanVienService();
            LoadGrid();
            Setting();
        }

        private void LoadGrid()
        {
            //B1: đếm cột
            dtgView.ColumnCount = 5;
            //B2: tên cột
            dtgView.Columns[0].Name = "Mã NV";
            dtgView.Columns[1].Name = "Họ Tên";
            dtgView.Columns[2].Name = "Ngày Sinh";
            dtgView.Columns[3].Name = "Giới Tính";
            dtgView.Columns[4].Name = "Địa Chỉ";
            //B3: reset dòng mỗi khi hàm chạy
            dtgView.Rows.Clear();
            //B4: Add dữ liệu từ service
            foreach (var nv in service.GetNhanViens(txt_Search.Text))
            {
                dtgView.Rows.Add(nv.MaNv, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.Diachi);
            }
            //nhớ vứt hàm loadgrid vào form
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //B1: lấy hết thông tin trên màn hình
            NhanVien nv = new NhanVien();
            nv.MaNv = txt_MaNV.Text;
            nv.HoTen = txt_HoTen.Text;
            nv.NgaySinh = DateTime.Parse(txt_NgSinh.Text);
            if (rbtn_Nam.Checked == true)
            {
                nv.GioiTinh = "Nam";
            }
            else
            {
                nv.GioiTinh = "Nữ";
            }
            nv.Diachi = cmbx_DiaChi.Text;
            MessageBox.Show(service.ThemNV(nv));
            //Load lại grid sau khi thêm
            LoadGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string ma = txt_MaNV.Text;
            MessageBox.Show(service.XoaNV(idWhenClick));
            LoadGrid();

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_HoTen.Text = "";
            txt_MaNV.Text = String.Empty;
            txt_NgSinh.Clear();
            txt_Search.Clear();
            rbtn_Nam.Checked = true;
            cmbx_DiaChi.SelectedIndex = 0;
        }

        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //tổng quát: khi click vào cell, mục đích là
            //lấy được ID của đối tượng tại dòng của cell đó
            //B1: lấy row
            int rowIndex = e.RowIndex;
            //B2: kiểm tra xem row hợp lệ hay không
            if (rowIndex < 0 || rowIndex >= service.GetNhanViens(txt_Search.Text).Count)
            {
                return; // không tương tác gì nữa
            }
            //B3: lấy ID từ dòng tương ứng 
            idWhenClick = dtgView.Rows[rowIndex].Cells[0].Value.ToString();
            //B4: fill dữ liệu lấy được gán vào màn hình
            Bindata();
        }

        public void Bindata()
        {
            var nv = service.GetNhanViens(txt_Search.Text).Find(x => x.MaNv == idWhenClick);
            txt_HoTen.Text = nv.HoTen;
            txt_MaNV.Text = nv.MaNv;
            txt_NgSinh.Text = nv.NgaySinh.ToString();
            if (nv.GioiTinh == "Nam")
            {
                rbtn_Nam.Checked = true;
            }
            else
            {
                rbtn_Nữ.Checked = true;
            }
            cmbx_DiaChi.Text = nv.Diachi;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Vì tất cả đối tượng đang bị track
            //=>không thể tạo nhân viên mới trùng mã rồi update đc
            //=> đổi gì thì đổi, ko đổi mã
            var clone = service.GetNhanViens(txt_Search.Text).Find(x => x.MaNv == idWhenClick);
            clone.HoTen = txt_HoTen.Text;
            clone.Diachi = cmbx_DiaChi.Text;
            clone.NgaySinh = DateTime.Parse(txt_NgSinh.Text);
            if (rbtn_Nam.Checked)
            {
                clone.GioiTinh = "Nam";
            }
            else
            {
                clone.GioiTinh = "Nữ";
            }
            MessageBox.Show(service.SuaNV(clone));
            LoadGrid(); //update xong load lại dữ liệu
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        public void Setting()
        {
            //set mặc định 1 rbtn được tick sẵn
            rbtn_Nam.Checked = true;
            dtgView.ReadOnly = true;//ko cho edit trong dtgview
            SettingComboBox();
        }

        public void SettingComboBox()
        {
            //ko cho edit combobox
            cmbx_DiaChi.DropDownStyle = ComboBoxStyle.DropDownList;
            //thêm 1 số item cho combobox
            cmbx_DiaChi.Items.Add("HN");
            cmbx_DiaChi.Items.Add("DN");
            cmbx_DiaChi.Items.Add("HP");
            cmbx_DiaChi.Items.Add("HCM");
            //chọn phần tử đầu trong lst làm mặc định
            cmbx_DiaChi.SelectedIndex = 0; 
        }
    }
}
