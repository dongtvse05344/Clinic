namespace Clinic
{
    partial class PrescriptionLogDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbChuanDoan = new System.Windows.Forms.Label();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.dgvPrescriptionLogDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptionLogDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuẩn đoán : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ghi chú : ";
            // 
            // lbChuanDoan
            // 
            this.lbChuanDoan.AutoSize = true;
            this.lbChuanDoan.Location = new System.Drawing.Point(114, 33);
            this.lbChuanDoan.Name = "lbChuanDoan";
            this.lbChuanDoan.Size = new System.Drawing.Size(35, 13);
            this.lbChuanDoan.TabIndex = 2;
            this.lbChuanDoan.Text = "label3";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(117, 64);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(35, 13);
            this.lbGhiChu.TabIndex = 3;
            this.lbGhiChu.Text = "label4";
            // 
            // dgvPrescriptionLogDetail
            // 
            this.dgvPrescriptionLogDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescriptionLogDetail.Location = new System.Drawing.Point(32, 98);
            this.dgvPrescriptionLogDetail.Name = "dgvPrescriptionLogDetail";
            this.dgvPrescriptionLogDetail.Size = new System.Drawing.Size(541, 194);
            this.dgvPrescriptionLogDetail.TabIndex = 4;
            // 
            // PrescriptionLogDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 366);
            this.Controls.Add(this.dgvPrescriptionLogDetail);
            this.Controls.Add(this.lbGhiChu);
            this.Controls.Add(this.lbChuanDoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrescriptionLogDetail";
            this.Text = "PrescriptionLogDetail";
            this.Load += new System.EventHandler(this.PrescriptionLogDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptionLogDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbChuanDoan;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.DataGridView dgvPrescriptionLogDetail;
    }
}