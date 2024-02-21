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
    public partial class FormChiTietHD : Form
    {
        public FormChiTietHD()
        {
            InitializeComponent();
            cthdBUS = new ChiTietHoaDonBUS();
        }
        private ChiTietHoaDonBUS cthdBUS;
        private void FormChiTietHD_Load(object sender, EventArgs e)
        {
            LoadDataWithDataReader();
        }
        public void LoadDataWithDataReader()
        {
            List<ChiTietHD> List = cthdBUS.getAllCTHD();
            //dgvListPK.DataSource = List;
            //dgvListPK.Columns[0].HeaderText = "Mã Phiếu Khám Bệnh";
            //dgvListPK.Columns[1].HeaderText = "Mã Bệnh Nhân";
            //dgvListPK.Columns[2].HeaderText = "Ngày Khám";
            //dgvListPK.Columns[3].HeaderText = "STT";
            //dgvListPK.Columns[4].HeaderText = "Triệu Chứng";
            //dgvListPK.Columns[5].HeaderText = "Chuẩn Đoán";
            //dgvListPK.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            //dgvListPK.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
    }
}
