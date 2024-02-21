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
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
            hoadonBUS = new HoaDonBUS();
        }
        private HoaDonBUS hoadonBUS;
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            LoadDataWithDataReader();
        }
        public void LoadDataWithDataReader()
        {
            List<HoaDonThuoc> bnList = hoadonBUS.getAllHoaDon();
            dgvHD.DataSource = bnList;
            dgvHD.Columns[0].HeaderText = "Mã hóa đơn";
            dgvHD.Columns[1].HeaderText = "Mã toa";
            dgvHD.Columns[2].HeaderText = "Ngày bán";
            dgvHD.Columns[3].HeaderText = "Tiền thuốc";
            dgvHD.Columns[0].Width = 150;
            dgvHD.Columns[1].Width = 150;
            dgvHD.Columns[2].Width = 150;
            dgvHD.Columns[3].Width = 150;
            dgvHD.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvHD.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
    }
}
