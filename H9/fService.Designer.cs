namespace H9
{
    partial class fService
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
            this.memuTSAdmin = new System.Windows.Forms.MenuStrip();
            this.quảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgvCustomer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSearchCustomer = new System.Windows.Forms.TextBox();
            this.txbShowCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label7 = new System.Windows.Forms.Label();
            this.txbServiceToDelete = new System.Windows.Forms.TextBox();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txbDeleteOrderID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbMainEmp = new System.Windows.Forms.ComboBox();
            this.cbSubEmp = new System.Windows.Forms.ComboBox();
            this.memuTSAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // memuTSAdmin
            // 
            this.memuTSAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.memuTSAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíToolStripMenuItem,
            this.thêmKháchHàngToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.memuTSAdmin.Location = new System.Drawing.Point(0, 0);
            this.memuTSAdmin.Name = "memuTSAdmin";
            this.memuTSAdmin.Size = new System.Drawing.Size(1379, 28);
            this.memuTSAdmin.TabIndex = 0;
            this.memuTSAdmin.Text = "menuStrip1";
            // 
            // quảnLíToolStripMenuItem
            // 
            this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.quảnLíToolStripMenuItem.Text = "Quản lí";
            this.quảnLíToolStripMenuItem.Click += new System.EventHandler(this.quảnLíToolStripMenuItem_Click);
            // 
            // thêmKháchHàngToolStripMenuItem
            // 
            this.thêmKháchHàngToolStripMenuItem.Name = "thêmKháchHàngToolStripMenuItem";
            this.thêmKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.thêmKháchHàngToolStripMenuItem.Text = "Thêm khách hàng";
            this.thêmKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.thêmKháchHàngToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // dtgvCustomer
            // 
            this.dtgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomer.Location = new System.Drawing.Point(12, 209);
            this.dtgvCustomer.Name = "dtgvCustomer";
            this.dtgvCustomer.RowHeadersWidth = 51;
            this.dtgvCustomer.RowTemplate.Height = 29;
            this.dtgvCustomer.Size = new System.Drawing.Size(657, 460);
            this.dtgvCustomer.TabIndex = 1;
            this.dtgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCustomer_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm tên khách hàng:";
            // 
            // txbSearchCustomer
            // 
            this.txbSearchCustomer.Location = new System.Drawing.Point(195, 63);
            this.txbSearchCustomer.Name = "txbSearchCustomer";
            this.txbSearchCustomer.Size = new System.Drawing.Size(364, 27);
            this.txbSearchCustomer.TabIndex = 3;
            // 
            // txbShowCustomer
            // 
            this.txbShowCustomer.ForeColor = System.Drawing.Color.Red;
            this.txbShowCustomer.Location = new System.Drawing.Point(12, 166);
            this.txbShowCustomer.Name = "txbShowCustomer";
            this.txbShowCustomer.ReadOnly = true;
            this.txbShowCustomer.Size = new System.Drawing.Size(657, 27);
            this.txbShowCustomer.TabIndex = 4;
            this.txbShowCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Khách hàng sử dụng dich vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(690, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Danh mục dịch vụ:";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(826, 63);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(541, 28);
            this.cbCategory.TabIndex = 7;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(690, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên dịch vụ:";
            // 
            // cbService
            // 
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(826, 100);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(541, 28);
            this.cbService.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(690, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Giảm giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(690, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số lượng:";
            // 
            // nmQuantity
            // 
            this.nmQuantity.Location = new System.Drawing.Point(826, 135);
            this.nmQuantity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(280, 27);
            this.nmQuantity.TabIndex = 13;
            this.nmQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(826, 171);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(280, 27);
            this.nmDiscount.TabIndex = 14;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchCustomer.Location = new System.Drawing.Point(575, 62);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(94, 29);
            this.btnSearchCustomer.TabIndex = 15;
            this.btnSearchCustomer.Text = "Tìm kiếm";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddService.Location = new System.Drawing.Point(1112, 135);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(255, 131);
            this.btnAddService.TabIndex = 16;
            this.btnAddService.Text = "Thêm dịch vụ";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // lsvBill
            // 
            this.lsvBill.BackColor = System.Drawing.Color.White;
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(690, 274);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(677, 249);
            this.lsvBill.TabIndex = 17;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.lsvBill_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên dịch vụ";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đơn giá";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giảm giá (%)";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thành tiền";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 113;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID order";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(690, 565);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tên dịch vụ muốn xóa:";
            // 
            // txbServiceToDelete
            // 
            this.txbServiceToDelete.Location = new System.Drawing.Point(889, 562);
            this.txbServiceToDelete.Name = "txbServiceToDelete";
            this.txbServiceToDelete.ReadOnly = true;
            this.txbServiceToDelete.Size = new System.Drawing.Size(378, 27);
            this.txbServiceToDelete.TabIndex = 19;
            this.txbServiceToDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteService.Location = new System.Drawing.Point(1273, 532);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(94, 59);
            this.btnDeleteService.TabIndex = 20;
            this.btnDeleteService.Text = "Xóa";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(690, 608);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tổng tiền cần thanh toán:";
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Location = new System.Drawing.Point(889, 605);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(478, 27);
            this.txbTotalPrice.TabIndex = 22;
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckOut.Location = new System.Drawing.Point(690, 640);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(677, 29);
            this.btnCheckOut.TabIndex = 23;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txbDeleteOrderID
            // 
            this.txbDeleteOrderID.Location = new System.Drawing.Point(889, 529);
            this.txbDeleteOrderID.Name = "txbDeleteOrderID";
            this.txbDeleteOrderID.ReadOnly = true;
            this.txbDeleteOrderID.Size = new System.Drawing.Size(378, 27);
            this.txbDeleteOrderID.TabIndex = 24;
            this.txbDeleteOrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(690, 532);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Mã Order muốn xóa:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(690, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Thợ chính:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(690, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Thợ phụ:";
            // 
            // cbMainEmp
            // 
            this.cbMainEmp.FormattingEnabled = true;
            this.cbMainEmp.Location = new System.Drawing.Point(826, 206);
            this.cbMainEmp.Name = "cbMainEmp";
            this.cbMainEmp.Size = new System.Drawing.Size(280, 28);
            this.cbMainEmp.TabIndex = 28;
            // 
            // cbSubEmp
            // 
            this.cbSubEmp.FormattingEnabled = true;
            this.cbSubEmp.Location = new System.Drawing.Point(826, 238);
            this.cbSubEmp.Name = "cbSubEmp";
            this.cbSubEmp.Size = new System.Drawing.Size(280, 28);
            this.cbSubEmp.TabIndex = 29;
            // 
            // fService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 681);
            this.Controls.Add(this.cbSubEmp);
            this.Controls.Add(this.cbMainEmp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbDeleteOrderID);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.txbTotalPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.txbServiceToDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lsvBill);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.nmDiscount);
            this.Controls.Add(this.nmQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbService);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbShowCustomer);
            this.Controls.Add(this.txbSearchCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvCustomer);
            this.Controls.Add(this.memuTSAdmin);
            this.MainMenuStrip = this.memuTSAdmin;
            this.MaximizeBox = false;
            this.Name = "fService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dịch vụ";
            this.memuTSAdmin.ResumeLayout(false);
            this.memuTSAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip memuTSAdmin;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgvCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSearchCustomer;
        private System.Windows.Forms.TextBox txbShowCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbServiceToDelete;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txbDeleteOrderID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbMainEmp;
        private System.Windows.Forms.ComboBox cbSubEmp;
    }
}