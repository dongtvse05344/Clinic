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
            this.lbAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptionLogDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuẩn đoán : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ghi chú : ";
            // 
            // lbChuanDoan
            // 
            this.lbChuanDoan.AutoSize = true;
            this.lbChuanDoan.Location = new System.Drawing.Point(152, 41);
            this.lbChuanDoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChuanDoan.Name = "lbChuanDoan";
            this.lbChuanDoan.Size = new System.Drawing.Size(46, 17);
            this.lbChuanDoan.TabIndex = 2;
            this.lbChuanDoan.Text = "label3";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(156, 79);
            this.lbGhiChu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(46, 17);
            this.lbGhiChu.TabIndex = 3;
            this.lbGhiChu.Text = "label4";
            // 
            // dgvPrescriptionLogDetail
            // 
            this.dgvPrescriptionLogDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescriptionLogDetail.Location = new System.Drawing.Point(43, 121);
            this.dgvPrescriptionLogDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPrescriptionLogDetail.Name = "dgvPrescriptionLogDetail";
            this.dgvPrescriptionLogDetail.Size = new System.Drawing.Size(721, 239);
            this.dgvPrescriptionLogDetail.TabIndex = 4;
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(543, 399);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(80, 17);
            this.lbAmount.TabIndex = 5;
            this.lbAmount.Text = "Tổng tiền : ";
            // 
            // PrescriptionLogDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.dgvPrescriptionLogDetail);
            this.Controls.Add(this.lbGhiChu);
            this.Controls.Add(this.lbChuanDoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label lbAmount;
    }
}