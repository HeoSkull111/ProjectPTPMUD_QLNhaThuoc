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
    public partial class FormThuoc : Form
    {
        public FormThuoc()
        {
            InitializeComponent();
            thuocBUS = new ThuocBUS();
        }
        private ThuocBUS thuocBUS;
        public void LoadDataWithDataReader()
        {
            List<Thuoc> bnList = thuocBUS.getAllThuoc();
            dgvThuoc.DataSource = bnList;
            dgvThuoc.Columns[0].HeaderText = "Mã thuốc";
            dgvThuoc.Columns[1].HeaderText = "Tên thuốc";
            dgvThuoc.Columns[2].HeaderText = "Đơn vị";
            dgvThuoc.Columns[3].HeaderText = "Đơn giá";
            dgvThuoc.Columns[4].HeaderText = "Ngày sản xuất";
            dgvThuoc.Columns[5].HeaderText = "Hạn sử dụng";
            dgvThuoc.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvThuoc.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        private void FormThuoc_Load(object sender, EventArgs e)
        {
            LoadDataWithDataReader();
        }
        private void ResetValue()
        {
            txtMaThuoc.Text = "";
            txtDonVi.Text = "";
            txtTenThuoc.Text = "";
            txtDonGia.Text = "";
            dtNSX.Text = "";
            dtHSD.Text = "";
        }
        private void dgvThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaThuoc.Text = dgvThuoc.CurrentRow.Cells["MaThuoc"].Value.ToString();
            txtDonVi.Text = dgvThuoc.CurrentRow.Cells["DonVi"].Value.ToString();
            txtTenThuoc.Text = dgvThuoc.CurrentRow.Cells["TenThuoc"].Value.ToString();
            txtDonGia.Text = dgvThuoc.CurrentRow.Cells["DonGia"].Value.ToString();
            dtNSX.Text = dgvThuoc.CurrentRow.Cells["NSX"].Value.ToString();
            dtHSD.Text = dgvThuoc.CurrentRow.Cells["HSD"].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Thuoc thuoc = new Thuoc
            {
                MaThuoc = txtMaThuoc.Text,
                DonVi = txtDonVi.Text,
                TenThuoc = txtTenThuoc.Text,
                DonGia = Int32.Parse(txtDonGia.Text),
                NSX = DateTime.Parse(dtNSX.Text),
                HSD = DateTime.Parse(dtHSD.Text),
            };
            thuocBUS.AddThuoc(thuoc);
            LoadDataWithDataReader();
            ResetValue();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            thuocBUS.DeleteThuoc(txtMaThuoc.Text); 
            LoadDataWithDataReader();
            ResetValue() ;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Thuoc thuoc = new Thuoc
            {
                MaThuoc = txtMaThuoc.Text,
                DonVi = txtDonVi.Text,
                TenThuoc = txtTenThuoc.Text,
                DonGia = Int32.Parse(txtDonGia.Text),
                NSX = DateTime.Parse(dtNSX.Text),
                HSD = DateTime.Parse(dtHSD.Text),
            };
            thuocBUS.UpdateThuoc(thuoc);
            LoadDataWithDataReader();
            ResetValue();
        }
    }
}
