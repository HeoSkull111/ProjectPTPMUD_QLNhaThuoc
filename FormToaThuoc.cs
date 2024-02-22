using Project.BUS;
using Project.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project
{
    public partial class FormToaThuoc : Form
    {
        public FormToaThuoc()
        {
            InitializeComponent();
            ctttBUS = new ChiTietToaThuocBUS();
            ttBUS = new ToaThuocBUS();
        }
        private ChiTietToaThuocBUS ctttBUS;
        private ToaThuocBUS ttBUS;
        public void LoadDataWithDataReader()
        {
            List<ChiTietToaThuoc> List1 = ctttBUS.getAllCTTT();
            dgvChiTiet.DataSource = List1;
            dgvChiTiet.Columns[0].HeaderText = "Mã toa";
            dgvChiTiet.Columns[1].HeaderText = "Mã thuốc";
            dgvChiTiet.Columns[2].HeaderText = "Số lượng";
            dgvChiTiet.Columns[3].HeaderText = "Cách dùng";
            dgvToaThuoc.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvToaThuoc.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp

            List<ToaThuoc> List2 = ttBUS.getAllTT();
            dgvToaThuoc.DataSource = List2;
            dgvToaThuoc.Columns[0].HeaderText = "Mã toa";
            dgvToaThuoc.Columns[1].HeaderText = "Mã phiếu khám";
            dgvToaThuoc.Columns[2].HeaderText = "Bác sĩ";
            dgvToaThuoc.Columns[3].HeaderText = "Ngày kê toa";
            dgvToaThuoc.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvToaThuoc.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void FormToaThuoc_Load(object sender, EventArgs e)
        {
            LoadDataWithDataReader();
        }
        private void ResetValueTT()
        {
            txtBacSi.Text = "";
            txtMaPK.Text = "";
            dtNgayKe.Text = "";
            txtMatoa.Text = "";
        }
        private void ResetValueCTTT()
        {
            txtMaToaCT.Text = "";
            txtCD.Text = "";
            txtMaThuoc.Text = "";
            txtSL.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvToaThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBacSi.Text = dgvToaThuoc.CurrentRow.Cells["BacSiKeToa"].Value.ToString();
            txtMaPK.Text = dgvToaThuoc.CurrentRow.Cells["MaPK"].Value.ToString();
            dtNgayKe.Text = dgvToaThuoc.CurrentRow.Cells["NgayKeToa"].Value.ToString();
            txtMatoa.Text = dgvToaThuoc.CurrentRow.Cells["MaToa"].Value.ToString();
        }

        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaToaCT.Text = dgvChiTiet.CurrentRow.Cells["MaToa"].Value.ToString();
            txtCD.Text = dgvChiTiet.CurrentRow.Cells["CachDung"].Value.ToString();
            txtMaThuoc.Text = dgvChiTiet.CurrentRow.Cells["MaThuoc"].Value.ToString();
            txtSL.Text = dgvChiTiet.CurrentRow.Cells["SoLuong"].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            ttBUS.DeleteToaThuoc(txtMatoa.Text);
            LoadDataWithDataReader();
            ResetValueTT();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            ctttBUS.DeleteCTToaThuoc(txtMaToaCT.Text);
            LoadDataWithDataReader();
            ResetValueCTTT();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ToaThuoc tt = new ToaThuoc
            {
                MaPK = txtMaPK.Text,
                MaToa = txtMatoa.Text,
                NgayKeToa = DateTime.Parse(dtNgayKe.Text),
                BacSiKeToa = txtBacSi.Text,
            };
            ttBUS.AddToaThuoc(tt);
            LoadDataWithDataReader();
            ResetValueTT();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChiTietToaThuoc cttt = new ChiTietToaThuoc
            {
                MaToa = txtMaToaCT.Text,
                MaThuoc = txtMaThuoc.Text,
                SoLuong = txtSL.Text,
                CachDung = txtCD.Text,
            };
            ctttBUS.AddCTToaThuoc(cttt);
            LoadDataWithDataReader();
            ResetValueCTTT();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ToaThuoc tt = new ToaThuoc
            {
                MaPK = txtMaPK.Text,
                MaToa = txtMatoa.Text,
                NgayKeToa = DateTime.Parse(dtNgayKe.Text),
                BacSiKeToa = txtBacSi.Text,
            };
            ttBUS.UpdateToaThuoc(tt);
            LoadDataWithDataReader();
            ResetValueTT();
        }

        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            ChiTietToaThuoc cttt = new ChiTietToaThuoc
            {
                MaToa = txtMaToaCT.Text,
                MaThuoc = txtMaThuoc.Text,
                SoLuong = txtSL.Text,
                CachDung = txtCD.Text,
            };
            ctttBUS.UpdateCTToaThuoc(cttt);
            LoadDataWithDataReader();
            ResetValueCTTT();
        }
    }
}
