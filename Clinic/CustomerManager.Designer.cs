namespace Clinic
{
    partial class CustomerManager
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
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.lbDoctor = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(20, 62);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(557, 294);
            this.dgvCustomer.TabIndex = 0;
            // 
            // lbDoctor
            // 
            this.lbDoctor.AutoSize = true;
            this.lbDoctor.Location = new System.Drawing.Point(20, 29);
            this.lbDoctor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDoctor.Name = "lbDoctor";
            this.lbDoctor.Size = new System.Drawing.Size(45, 13);
            this.lbDoctor.TabIndex = 1;
            this.lbDoctor.Text = "Bác sĩ :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(472, 29);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add Customer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CustomerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbDoctor);
            this.Controls.Add(this.dgvCustomer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerManager";
            this.Text = "CustomerManager";
            this.Load += new System.EventHandler(this.CustomerManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Label lbDoctor;
        private System.Windows.Forms.Button btnAdd;
    }
}