namespace Test
{
    partial class EmployeeTab
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.BtnStartOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(351, 171);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(146, 42);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 112);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(182, 171);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(146, 42);
            this.btnSchedule.TabIndex = 4;
            this.btnSchedule.Text = "View Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            // 
            // BtnStartOrder
            // 
            this.BtnStartOrder.Location = new System.Drawing.Point(12, 171);
            this.BtnStartOrder.Name = "BtnStartOrder";
            this.BtnStartOrder.Size = new System.Drawing.Size(146, 42);
            this.BtnStartOrder.TabIndex = 3;
            this.BtnStartOrder.Text = "Start Order";
            this.BtnStartOrder.UseVisualStyleBackColor = true;
            this.BtnStartOrder.Click += new System.EventHandler(this.BtnStartOrder_Click);
            // 
            // EmployeeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 225);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.BtnStartOrder);
            this.Name = "EmployeeTab";
            this.Text = "EmployeeTab";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button BtnStartOrder;
    }
}