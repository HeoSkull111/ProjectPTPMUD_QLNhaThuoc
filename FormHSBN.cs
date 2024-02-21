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
            dgvListBN.Columns[0].Width = 100;
            dgvListBN.Columns[1].Width = 200;
            dgvListBN.Columns[2].Width = 200;
            dgvListBN.Columns[3].Width = 75;
            dgvListBN.Columns[4].Width = 100;
            dgvListBN.Columns[5].Width = 300;
            dgvListBN.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvListBN.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
    }

}