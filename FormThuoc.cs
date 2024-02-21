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
        private void FormThuoc_Load(object sender, EventArgs e)
        {
            LoadDataWithDataReader();
        }
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
            dgvThuoc.Columns[0].Width = 100;
            dgvThuoc.Columns[1].Width = 200;
            dgvThuoc.Columns[2].Width = 200;
            dgvThuoc.Columns[3].Width = 200;
            dgvThuoc.Columns[4].Width = 300;
            dgvThuoc.Columns[5].Width = 300;
            dgvThuoc.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvThuoc.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
    }
}
