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
    }
}
