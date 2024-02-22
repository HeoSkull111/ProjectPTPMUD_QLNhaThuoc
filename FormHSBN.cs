using Project.BUS;
using Project.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FormHSBN : Form
    {
        public FormHSBN()
        {
            InitializeComponent();
            benhNhanBus = new BenhNhanBUS();
        }
        private BenhNhanBUS benhNhanBus;
        private void FormHSBN_Load(object sender, EventArgs e)
        {
            LoadDataWithDataReader();
        }
        public void LoadDataWithDataReader()
        {
            List<BenhNhan> bnList = benhNhanBus.getAllBenhNhan();
            dgvListBN.DataSource = bnList;
            dgvListBN.Columns[0].HeaderText = "Mã bệnh nhân";
            dgvListBN.Columns[1].HeaderText = "Họ tên";
            dgvListBN.Columns[2].HeaderText = "Giới tính";
            dgvListBN.Columns[3].HeaderText = "Địa chỉ";
            dgvListBN.Columns[4].HeaderText = "Ngày sinh";
            dgvListBN.Columns[5].HeaderText = "Số điện thoại";
            dgvListBN.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvListBN.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        public void ResetValue()
        {
            txtDiachi.Text = "";
            txtHoten.Text = "";
            txtMabn.Text = "";
            txtSdt.Text = "";
            dtNgaysinh.Text = "";
            cmbGioitinh.SelectedIndex = 0;
        }

        private void dgvListBN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDiachi.Text = dgvListBN.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtHoten.Text = dgvListBN.CurrentRow.Cells["HoTen"].Value.ToString();
            txtMabn.Text = dgvListBN.CurrentRow.Cells["MaBn"].Value.ToString();
            txtSdt.Text = dgvListBN.CurrentRow.Cells["SDT"].Value.ToString();
            dtNgaysinh.Text = dgvListBN.CurrentRow.Cells["NgaySinh"].Value.ToString();
            cmbGioitinh.Text = dgvListBN.CurrentRow.Cells["GioiTinh"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BenhNhan bn = new BenhNhan
            {
                MaBN = txtMabn.Text,
                HoTen = txtHoten.Text,
                GioiTinh = cmbGioitinh.Text,
                NgaySinh = DateTime.Parse(dtNgaysinh.Text),
                DiaChi = txtDiachi.Text,
                SDT = txtSdt.Text,
            };
            benhNhanBus.AddHSBN(bn);
            LoadDataWithDataReader();
            ResetValue();
        }

        private void btntEdit_Click(object sender, EventArgs e)
        {
            BenhNhan bn = new BenhNhan
            {
                MaBN = txtMabn.Text,
                HoTen = txtHoten.Text,
                GioiTinh = cmbGioitinh.Text,
                NgaySinh = DateTime.Parse(dtNgaysinh.Text),
                DiaChi = txtDiachi.Text,
                SDT = txtSdt.Text,
            };
            benhNhanBus.UpdateHSBN(bn);
            LoadDataWithDataReader();
            ResetValue();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            benhNhanBus.DeleteHSBN(txtMabn.Text);
            LoadDataWithDataReader();
            ResetValue();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}