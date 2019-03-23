namespace Clinic
{
    partial class DrugManage
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
            this.dgvManageDrug = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iTinhNang = new System.Windows.Forms.ToolStripMenuItem();
            this.iKhachHangMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.iDanhSachKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.iThoat = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageDrug)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvManageDrug
            // 
            this.dgvManageDrug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageDrug.Location = new System.Drawing.Point(7, 65);
            this.dgvManageDrug.Margin = new System.Windows.Forms.Padding(2);
            this.dgvManageDrug.Name = "dgvManageDrug";
            this.dgvManageDrug.RowTemplate.Height = 24;
            this.dgvManageDrug.Size = new System.Drawing.Size(585, 235);
            this.dgvManageDrug.TabIndex = 0;
            this.dgvManageDrug.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageDrug_CellContentClick);
            this.dgvManageDrug.Click += new System.EventHandler(this.dgvManageDrug_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.txtUnitPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSearchName);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(94, 318);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 182);
            this.panel1.TabIndex = 8;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(77, 134);
            this.txtType.Margin = new System.Windows.Forms.Padding(2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(211, 20);
            this.txtType.TabIndex = 5;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(77, 99);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(211, 20);
            this.txtUnitPrice.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "UnitPrice :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(323, 137);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 31);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearchName
            // 
            this.btnSearchName.Location = new System.Drawing.Point(200, 10);
            this.btnSearchName.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(88, 22);
            this.btnSearchName.TabIndex = 6;
            this.btnSearchName.Text = "&SearchName";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(323, 93);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(56, 31);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(323, 49);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(56, 31);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "&Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(323, 6);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(56, 31);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(77, 70);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(211, 20);
            this.txtCode.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 40);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(77, 12);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(119, 20);
            this.txtID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iTinhNang,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "Tính năng";
            // 
            // iTinhNang
            // 
            this.iTinhNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iKhachHangMoi,
            this.iDanhSachKhachhang});
            this.iTinhNang.Name = "iTinhNang";
            this.iTinhNang.Size = new System.Drawing.Size(73, 20);
            this.iTinhNang.Text = "Tính năng";
            // 
            // iKhachHangMoi
            // 
            this.iKhachHangMoi.Name = "iKhachHangMoi";
            this.iKhachHangMoi.Size = new System.Drawing.Size(194, 22);
            this.iKhachHangMoi.Text = "Khách hàng mới";
            this.iKhachHangMoi.Click += new System.EventHandler(this.iKhachHangMoi_Click);
            // 
            // iDanhSachKhachhang
            // 
            this.iDanhSachKhachhang.Name = "iDanhSachKhachhang";
            this.iDanhSachKhachhang.Size = new System.Drawing.Size(194, 22);
            this.iDanhSachKhachhang.Text = "Danh sách khách hàng";
            this.iDanhSachKhachhang.Click += new System.EventHandler(this.iQuanLiKhoThuoc_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDangXuat,
            this.iThoat});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // iDangXuat
            // 
            this.iDangXuat.Name = "iDangXuat";
            this.iDangXuat.Size = new System.Drawing.Size(127, 22);
            this.iDangXuat.Text = "Đăng xuất";
            this.iDangXuat.Click += new System.EventHandler(this.iDangXuat_Click);
            // 
            // iThoat
            // 
            this.iThoat.Name = "iThoat";
            this.iThoat.Size = new System.Drawing.Size(127, 22);
            this.iThoat.Text = "Thoát";
            this.iThoat.Click += new System.EventHandler(this.iThoat_Click);
            // 
            // DrugManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvManageDrug);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DrugManage";
            this.Text = "Manage Drug";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageDrug)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManageDrug;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iTinhNang;
        private System.Windows.Forms.ToolStripMenuItem iKhachHangMoi;
        private System.Windows.Forms.ToolStripMenuItem iDanhSachKhachhang;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDangXuat;
        private System.Windows.Forms.ToolStripMenuItem iThoat;
    }
}

