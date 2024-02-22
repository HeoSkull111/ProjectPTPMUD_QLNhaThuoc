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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void txtBoxTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuThuoc_Click(object sender, EventArgs e)
        {
            FormThuoc formThuoc = new FormThuoc();
            formThuoc.ShowDialog();
        }

        private void menuHSBN_Click(object sender, EventArgs e)
        {
            FormHSBN formHSBN = new FormHSBN();
            formHSBN.ShowDialog();
        }

        private void menuPhieuKhamBenh_Click(object sender, EventArgs e)
        {
            FormPhieuKhamBenh formPKB = new FormPhieuKhamBenh();
            formPKB.ShowDialog();
        }

        private void menuToaThuoc_Click(object sender, EventArgs e)
        {
            FormToaThuoc form = new FormToaThuoc();
            form.ShowDialog(); 
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
