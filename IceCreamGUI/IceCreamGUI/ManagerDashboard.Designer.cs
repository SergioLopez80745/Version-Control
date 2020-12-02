namespace IceCreamGUI
{
    partial class ManagerDashboard
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
            this.btnViewEmp = new System.Windows.Forms.Button();
            this.btnViewItem = new System.Windows.Forms.Button();
            this.btnRemoveEmp = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.btnPrintSchedule = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnPrintInventory = new System.Windows.Forms.Button();
            this.btnViewSchedule = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateSch = new System.Windows.Forms.Button();
            this.btnAddSch = new System.Windows.Forms.Button();
            this.btnRemoveSch = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(981, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnViewEmp
            // 
            this.btnViewEmp.Location = new System.Drawing.Point(12, 12);
            this.btnViewEmp.Name = "btnViewEmp";
            this.btnViewEmp.Size = new System.Drawing.Size(156, 56);
            this.btnViewEmp.TabIndex = 1;
            this.btnViewEmp.Text = "View Employee";
            this.btnViewEmp.UseVisualStyleBackColor = true;
            this.btnViewEmp.Click += new System.EventHandler(this.btnViewEmp_Click);
            // 
            // btnViewItem
            // 
            this.btnViewItem.Location = new System.Drawing.Point(174, 12);
            this.btnViewItem.Name = "btnViewItem";
            this.btnViewItem.Size = new System.Drawing.Size(156, 56);
            this.btnViewItem.TabIndex = 2;
            this.btnViewItem.Text = "View Inventory";
            this.btnViewItem.UseVisualStyleBackColor = true;
            this.btnViewItem.Click += new System.EventHandler(this.btnViewItem_Click);
            // 
            // btnRemoveEmp
            // 
            this.btnRemoveEmp.Location = new System.Drawing.Point(174, 195);
            this.btnRemoveEmp.Name = "btnRemoveEmp";
            this.btnRemoveEmp.Size = new System.Drawing.Size(156, 53);
            this.btnRemoveEmp.TabIndex = 5;
            this.btnRemoveEmp.Text = "Remove Employee";
            this.btnRemoveEmp.UseVisualStyleBackColor = true;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(12, 195);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(156, 53);
            this.btnAddEmp.TabIndex = 6;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.Location = new System.Drawing.Point(336, 195);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(156, 53);
            this.btnUpdateEmp.TabIndex = 7;
            this.btnUpdateEmp.Text = "Update Employee";
            this.btnUpdateEmp.UseVisualStyleBackColor = true;
            // 
            // btnPrintSchedule
            // 
            this.btnPrintSchedule.Location = new System.Drawing.Point(12, 524);
            this.btnPrintSchedule.Name = "btnPrintSchedule";
            this.btnPrintSchedule.Size = new System.Drawing.Size(165, 50);
            this.btnPrintSchedule.TabIndex = 9;
            this.btnPrintSchedule.Text = "Print Schedule";
            this.btnPrintSchedule.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(828, 524);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(165, 50);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnPrintInventory
            // 
            this.btnPrintInventory.Location = new System.Drawing.Point(183, 524);
            this.btnPrintInventory.Name = "btnPrintInventory";
            this.btnPrintInventory.Size = new System.Drawing.Size(165, 50);
            this.btnPrintInventory.TabIndex = 8;
            this.btnPrintInventory.Text = "Print Inventory";
            this.btnPrintInventory.UseVisualStyleBackColor = true;
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.Location = new System.Drawing.Point(336, 12);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(156, 56);
            this.btnViewSchedule.TabIndex = 16;
            this.btnViewSchedule.Text = "View Schedule";
            this.btnViewSchedule.UseVisualStyleBackColor = true;
            this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(727, 48);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(219, 20);
            this.txtTime.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(671, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Edit Time:";
            // 
            // btnUpdateSch
            // 
            this.btnUpdateSch.Location = new System.Drawing.Point(837, 195);
            this.btnUpdateSch.Name = "btnUpdateSch";
            this.btnUpdateSch.Size = new System.Drawing.Size(156, 53);
            this.btnUpdateSch.TabIndex = 23;
            this.btnUpdateSch.Text = "Update Schedule";
            this.btnUpdateSch.UseVisualStyleBackColor = true;
            // 
            // btnAddSch
            // 
            this.btnAddSch.Location = new System.Drawing.Point(513, 195);
            this.btnAddSch.Name = "btnAddSch";
            this.btnAddSch.Size = new System.Drawing.Size(156, 53);
            this.btnAddSch.TabIndex = 22;
            this.btnAddSch.Text = "Add Schedule";
            this.btnAddSch.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSch
            // 
            this.btnRemoveSch.Location = new System.Drawing.Point(675, 195);
            this.btnRemoveSch.Name = "btnRemoveSch";
            this.btnRemoveSch.Size = new System.Drawing.Size(156, 53);
            this.btnRemoveSch.TabIndex = 21;
            this.btnRemoveSch.Text = "Remove Schedule";
            this.btnRemoveSch.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(80, 84);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(144, 20);
            this.txtId.TabIndex = 24;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(348, 84);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(144, 20);
            this.txtPhone.TabIndex = 25;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(80, 110);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(144, 20);
            this.txtFName.TabIndex = 26;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(348, 110);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(144, 20);
            this.txtLName.TabIndex = 27;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(80, 136);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(144, 20);
            this.txtUserName.TabIndex = 28;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(348, 136);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(144, 20);
            this.txtPassword.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Employee Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "UserName:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Phone #:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Last Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Password:";
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1005, 586);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnUpdateSch);
            this.Controls.Add(this.btnAddSch);
            this.Controls.Add(this.btnRemoveSch);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewSchedule);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnPrintSchedule);
            this.Controls.Add(this.btnPrintInventory);
            this.Controls.Add(this.btnUpdateEmp);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.btnRemoveEmp);
            this.Controls.Add(this.btnViewItem);
            this.Controls.Add(this.btnViewEmp);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManagerDashboard";
            this.Text = "ManagerDashboard";
            this.Load += new System.EventHandler(this.ManagerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnViewEmp;
        private System.Windows.Forms.Button btnViewItem;
        private System.Windows.Forms.Button btnRemoveEmp;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.Button btnPrintSchedule;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnPrintInventory;
        private System.Windows.Forms.Button btnViewSchedule;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateSch;
        private System.Windows.Forms.Button btnAddSch;
        private System.Windows.Forms.Button btnRemoveSch;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}