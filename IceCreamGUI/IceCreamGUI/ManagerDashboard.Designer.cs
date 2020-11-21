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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnPrintSchedule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnPrintInventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(934, 264);
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
            // 
            // btnViewItem
            // 
            this.btnViewItem.Location = new System.Drawing.Point(174, 12);
            this.btnViewItem.Name = "btnViewItem";
            this.btnViewItem.Size = new System.Drawing.Size(156, 56);
            this.btnViewItem.TabIndex = 2;
            this.btnViewItem.Text = "View Inventory";
            this.btnViewItem.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(174, 195);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(156, 53);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(336, 195);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(156, 53);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 195);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 53);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(498, 195);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(156, 53);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send Changes";
            this.btnSend.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Edit Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Edit Day:";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(669, 55);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(219, 20);
            this.txtDay.TabIndex = 12;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(669, 12);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(219, 20);
            this.txtTime.TabIndex = 13;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(781, 524);
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
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(958, 586);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintSchedule);
            this.Controls.Add(this.btnPrintInventory);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnViewItem);
            this.Controls.Add(this.btnViewEmp);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManagerDashboard";
            this.Text = "ManagerDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnViewEmp;
        private System.Windows.Forms.Button btnViewItem;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnPrintSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnPrintInventory;
    }
}