﻿namespace Project
{
    partial class FormHSBN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbSex = new System.Windows.Forms.GroupBox();
            this.cmbGioitinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListBN = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.btnDel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btntEdit = new System.Windows.Forms.Button();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMabn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSex.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBN)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSex
            // 
            this.cmbSex.Controls.Add(this.cmbGioitinh);
            this.cmbSex.Controls.Add(this.label7);
            this.cmbSex.Controls.Add(this.groupBox2);
            this.cmbSex.Controls.Add(this.btnCancel);
            this.cmbSex.Controls.Add(this.dtNgaysinh);
            this.cmbSex.Controls.Add(this.btnDel);
            this.cmbSex.Controls.Add(this.label5);
            this.cmbSex.Controls.Add(this.btntEdit);
            this.cmbSex.Controls.Add(this.txtDiachi);
            this.cmbSex.Controls.Add(this.btnAdd);
            this.cmbSex.Controls.Add(this.label6);
            this.cmbSex.Controls.Add(this.txtSdt);
            this.cmbSex.Controls.Add(this.label4);
            this.cmbSex.Controls.Add(this.txtHoten);
            this.cmbSex.Controls.Add(this.label3);
            this.cmbSex.Controls.Add(this.txtMabn);
            this.cmbSex.Controls.Add(this.label2);
            this.cmbSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSex.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSex.ForeColor = System.Drawing.Color.Blue;
            this.cmbSex.Location = new System.Drawing.Point(0, 0);
            this.cmbSex.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Padding = new System.Windows.Forms.Padding(2);
            this.cmbSex.Size = new System.Drawing.Size(951, 495);
            this.cmbSex.TabIndex = 2;
            this.cmbSex.TabStop = false;
            this.cmbSex.Text = "Thông Tin Bệnh Nhân";
            // 
            // cmbGioitinh
            // 
            this.cmbGioitinh.FormattingEnabled = true;
            this.cmbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioitinh.Location = new System.Drawing.Point(106, 119);
            this.cmbGioitinh.Name = "cmbGioitinh";
            this.cmbGioitinh.Size = new System.Drawing.Size(127, 29);
            this.cmbGioitinh.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Giới Tính:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvListBN);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(10, 274);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(941, 189);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Bệnh Nhân";
            // 
            // dgvListBN
            // 
            this.dgvListBN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListBN.Location = new System.Drawing.Point(2, 24);
            this.dgvListBN.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListBN.Name = "dgvListBN";
            this.dgvListBN.Size = new System.Drawing.Size(937, 163);
            this.dgvListBN.TabIndex = 0;
            this.dgvListBN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListBN_CellContentClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(631, 207);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 46);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtNgaysinh.CalendarTitleForeColor = System.Drawing.Color.Blue;
            this.dtNgaysinh.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaysinh.Location = new System.Drawing.Point(705, 50);
            this.dtNgaysinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(225, 26);
            this.dtNgaysinh.TabIndex = 11;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(502, 207);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(94, 46);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày Sinh:";
            // 
            // btntEdit
            // 
            this.btntEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btntEdit.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntEdit.Location = new System.Drawing.Point(380, 207);
            this.btntEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btntEdit.Name = "btntEdit";
            this.btntEdit.Size = new System.Drawing.Size(94, 46);
            this.btntEdit.TabIndex = 4;
            this.btntEdit.Text = "Sửa";
            this.btntEdit.UseVisualStyleBackColor = true;
            this.btntEdit.Click += new System.EventHandler(this.btntEdit_Click);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiachi.Location = new System.Drawing.Point(353, 119);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(213, 29);
            this.txtDiachi.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(257, 207);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 46);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Địa Chỉ:";
            // 
            // txtSdt
            // 
            this.txtSdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSdt.Location = new System.Drawing.Point(705, 119);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(2);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(225, 29);
            this.txtSdt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số Điện Thoại:";
            // 
            // txtHoten
            // 
            this.txtHoten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoten.Location = new System.Drawing.Point(353, 42);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(213, 29);
            this.txtHoten.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên:";
            // 
            // txtMabn
            // 
            this.txtMabn.Location = new System.Drawing.Point(78, 45);
            this.txtMabn.Margin = new System.Windows.Forms.Padding(2);
            this.txtMabn.Name = "txtMabn";
            this.txtMabn.Size = new System.Drawing.Size(155, 29);
            this.txtMabn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã BN:";
            // 
            // FormHSBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 495);
            this.Controls.Add(this.cmbSex);
            this.Name = "FormHSBN";
            this.Text = "FormHSBN";
            this.Load += new System.EventHandler(this.FormHSBN_Load);
            this.cmbSex.ResumeLayout(false);
            this.cmbSex.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cmbSex;
        private System.Windows.Forms.ComboBox cmbGioitinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListBN;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtNgaysinh;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btntEdit;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMabn;
        private System.Windows.Forms.Label label2;
    }
}