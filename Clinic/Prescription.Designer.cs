namespace Clinic
{
    partial class Prescription
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
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.featureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kêĐơnThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(13, 38);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(54, 17);
            this.lblDoctor.TabIndex = 0;
            this.lblDoctor.Text = "Bác sĩ :";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(13, 65);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(85, 17);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Bệnh nhân :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.featureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // featureToolStripMenuItem
            // 
            this.featureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kêĐơnThuốcToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.featureToolStripMenuItem.Name = "featureToolStripMenuItem";
            this.featureToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.featureToolStripMenuItem.Text = "Tính năng";
            // 
            // kêĐơnThuốcToolStripMenuItem
            // 
            this.kêĐơnThuốcToolStripMenuItem.Name = "kêĐơnThuốcToolStripMenuItem";
            this.kêĐơnThuốcToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kêĐơnThuốcToolStripMenuItem.Text = "Kê đơn thuốc";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Prescription";
            this.Text = "Prescription";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem featureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kêĐơnThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}