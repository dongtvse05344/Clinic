﻿namespace Clinic
{
    partial class Register
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.rdnFemale = new System.Windows.Forms.RadioButton();
            this.rdnMale = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.rdnFemale);
            this.panel1.Controls.Add(this.rdnMale);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 341);
            this.panel1.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(21, 122);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(239, 24);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // rdnFemale
            // 
            this.rdnFemale.AutoSize = true;
            this.rdnFemale.Location = new System.Drawing.Point(161, 75);
            this.rdnFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdnFemale.Name = "rdnFemale";
            this.rdnFemale.Size = new System.Drawing.Size(59, 17);
            this.rdnFemale.TabIndex = 4;
            this.rdnFemale.TabStop = true;
            this.rdnFemale.Text = "Female";
            this.rdnFemale.UseVisualStyleBackColor = true;
            // 
            // rdnMale
            // 
            this.rdnMale.AutoSize = true;
            this.rdnMale.Location = new System.Drawing.Point(85, 75);
            this.rdnMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdnMale.Name = "rdnMale";
            this.rdnMale.Size = new System.Drawing.Size(48, 17);
            this.rdnMale.TabIndex = 3;
            this.rdnMale.TabStop = true;
            this.rdnMale.Text = "Male";
            this.rdnMale.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 39);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 20);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name : ";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 374);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Register";
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdnFemale;
        private System.Windows.Forms.RadioButton rdnMale;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegister;
    }
}