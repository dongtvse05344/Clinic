﻿namespace Clinic
{
    partial class PrescriptionLog
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tínhNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoĐơnThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbAge);
            this.panel1.Controls.Add(this.lbGender);
            this.panel1.Controls.Add(this.lbTel);
            this.panel1.Controls.Add(this.lbAddress);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Location = new System.Drawing.Point(13, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 116);
            this.panel1.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(3, 25);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(85, 17);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Bệnh nhân :";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(3, 69);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(59, 17);
            this.lbAddress.TabIndex = 1;
            this.lbAddress.Text = "Địa chỉ :";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(308, 25);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(103, 17);
            this.lbTel.TabIndex = 2;
            this.lbTel.Text = "Số điện thoại : ";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(548, 25);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(68, 17);
            this.lbGender.TabIndex = 3;
            this.lbGender.Text = "Giới tính :";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(551, 69);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(44, 17);
            this.lbAge.TabIndex = 4;
            this.lbAge.Text = "Tuổi :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tínhNăngToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tínhNăngToolStripMenuItem
            // 
            this.tínhNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoĐơnThuốcToolStripMenuItem,
            this.kháchHàngMớiToolStripMenuItem});
            this.tínhNăngToolStripMenuItem.Name = "tínhNăngToolStripMenuItem";
            this.tínhNăngToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.tínhNăngToolStripMenuItem.Text = "Tính năng";
            // 
            // tạoĐơnThuốcToolStripMenuItem
            // 
            this.tạoĐơnThuốcToolStripMenuItem.Name = "tạoĐơnThuốcToolStripMenuItem";
            this.tạoĐơnThuốcToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.tạoĐơnThuốcToolStripMenuItem.Text = "Tạo đơn thuốc";
            // 
            // kháchHàngMớiToolStripMenuItem
            // 
            this.kháchHàngMớiToolStripMenuItem.Name = "kháchHàngMớiToolStripMenuItem";
            this.kháchHàngMớiToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kháchHàngMớiToolStripMenuItem.Text = "Khách hàng mới";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem1,
            this.thoátToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.đăngXuấtToolStripMenuItem1.Text = "Đăng xuất";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // PrescriptionLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrescriptionLog";
            this.Text = "PrescriptionLog";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tínhNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoĐơnThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}