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
    public partial class FormPhieuKhamBenh : Form
    {
        public FormPhieuKhamBenh()
        {
            InitializeComponent();
            pkbBUS = new PhieuKhamBenhBUS();
        }
        private PhieuKhamBenhBUS pkbBUS;
        private void FormPhieuKhamBenh_Load(object sender, EventArgs e)
        {
            LoadDataWithDataReader();
        }
        public void LoadDataWithDataReader()
        {
            List<PhieuKhamBenh> pkbList = pkbBUS.getAllPKB();
            dgvListPK.DataSource = pkbList;
            dgvListPK.Columns[0].HeaderText = "Mã Phiếu Khám Bệnh";
            dgvListPK.Columns[1].HeaderText = "Mã Bệnh Nhân";
            dgvListPK.Columns[2].HeaderText = "Ngày Khám";
            dgvListPK.Columns[3].HeaderText = "STT";
            dgvListPK.Columns[4].HeaderText = "Triệu Chứng";
            dgvListPK.Columns[5].HeaderText = "Chuẩn Đoán";
            dgvListPK.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvListPK.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        private void ResetValue()
        {
            txtchuandoan.Text = "";
            txtmapk.Text = "";
            txtstt.Text = "";
            txttrieuchung.Text = "";
            dtngaykham.Text = "";
            txtmaBN.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PhieuKhamBenh phieuKB = new PhieuKhamBenh
            {
                MaPK = txtmapk.Text,
                MaBN = txtmaBN.Text,
                NgayKham = DateTime.Parse(dtngaykham.Text),
                STT = Int32.Parse(txtstt.Text),
                TrieuChung = txttrieuchung.Text,
                ChuanDoan = txtchuandoan.Text,
            };
            pkbBUS.AddPKB(phieuKB);
            LoadDataWithDataReader();
            ResetValue();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            PhieuKhamBenh phieuKB = new PhieuKhamBenh
            {
                NgayKham = DateTime.Parse(dtngaykham.Text),
                STT = Int32.Parse(txtstt.Text),
                TrieuChung = txttrieuchung.Text,
                ChuanDoan = txtchuandoan.Text,
            };
            pkbBUS.UpdatePKB(phieuKB);
            LoadDataWithDataReader();
            ResetValue();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            pkbBUS.DeletePKB(txtmapk.Text);
            LoadDataWithDataReader();
            ResetValue();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListPK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtchuandoan.Text = dgvListPK.CurrentRow.Cells["ChuanDoan"].Value.ToString();
            txtmapk.Text = dgvListPK.CurrentRow.Cells["MaPK"].Value.ToString();
            txtstt.Text = dgvListPK.CurrentRow.Cells["STT"].Value.ToString();
            txttrieuchung.Text = dgvListPK.CurrentRow.Cells["TrieuChung"].Value.ToString();
            dtngaykham.Text = dgvListPK.CurrentRow.Cells["NgayKham"].Value.ToString();
            txtmaBN.Text = dgvListPK.CurrentRow.Cells["MaBN"].Value.ToString();
        }
    }
}
