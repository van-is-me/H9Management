namespace H9
{
    partial class fAdmin
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
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpIncome = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTotalIncome = new System.Windows.Forms.TextBox();
            this.dtgvIncome = new System.Windows.Forms.DataGridView();
            this.btnStatitic = new System.Windows.Forms.Button();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCategory = new System.Windows.Forms.TabPage();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnSearchCategory = new System.Windows.Forms.Button();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.txbCategoryName = new System.Windows.Forms.TextBox();
            this.txbCategoryID = new System.Windows.Forms.TextBox();
            this.txbCategorySearchName = new System.Windows.Forms.TextBox();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnShowCategory = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbService = new System.Windows.Forms.TabPage();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnShowService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.nmServicePrice = new System.Windows.Forms.NumericUpDown();
            this.cbCategoryName = new System.Windows.Forms.ComboBox();
            this.txbServiceName = new System.Windows.Forms.TextBox();
            this.txbServiceID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchService = new System.Windows.Forms.Button();
            this.dtgvService = new System.Windows.Forms.DataGridView();
            this.txbSearchService = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tpCustomer = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnShowCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.txbCustomerPhone = new System.Windows.Forms.TextBox();
            this.txbCustomerName = new System.Windows.Forms.TextBox();
            this.txbCustomerID = new System.Windows.Forms.TextBox();
            this.dtgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txbSearchCustomer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tpEmployee = new System.Windows.Forms.TabPage();
            this.btnShowEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txbRoleEmp = new System.Windows.Forms.TextBox();
            this.txbPasswordEmp = new System.Windows.Forms.TextBox();
            this.txbUserNameEmp = new System.Windows.Forms.TextBox();
            this.btnSearchUserNameEmp = new System.Windows.Forms.Button();
            this.txbSearchUserNameEmp = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtgvEmployee = new System.Windows.Forms.DataGridView();
            this.tcAdmin.SuspendLayout();
            this.tpIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIncome)).BeginInit();
            this.tbCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.tbService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmServicePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvService)).BeginInit();
            this.tpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).BeginInit();
            this.tpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpIncome);
            this.tcAdmin.Controls.Add(this.tbCategory);
            this.tcAdmin.Controls.Add(this.tbService);
            this.tcAdmin.Controls.Add(this.tpCustomer);
            this.tcAdmin.Controls.Add(this.tpEmployee);
            this.tcAdmin.Location = new System.Drawing.Point(12, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1130, 486);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpIncome
            // 
            this.tpIncome.Controls.Add(this.label4);
            this.tpIncome.Controls.Add(this.txbTotalIncome);
            this.tpIncome.Controls.Add(this.dtgvIncome);
            this.tpIncome.Controls.Add(this.btnStatitic);
            this.tpIncome.Controls.Add(this.dtpkToDate);
            this.tpIncome.Controls.Add(this.dtpkFromDate);
            this.tpIncome.Controls.Add(this.label3);
            this.tpIncome.Controls.Add(this.label2);
            this.tpIncome.Controls.Add(this.label1);
            this.tpIncome.Location = new System.Drawing.Point(4, 29);
            this.tpIncome.Name = "tpIncome";
            this.tpIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tpIncome.Size = new System.Drawing.Size(1122, 453);
            this.tpIncome.TabIndex = 0;
            this.tpIncome.Text = "Doanh thu";
            this.tpIncome.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(365, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thống kê";
            // 
            // txbTotalIncome
            // 
            this.txbTotalIncome.Location = new System.Drawing.Point(877, 126);
            this.txbTotalIncome.Name = "txbTotalIncome";
            this.txbTotalIncome.ReadOnly = true;
            this.txbTotalIncome.Size = new System.Drawing.Size(239, 27);
            this.txbTotalIncome.TabIndex = 7;
            this.txbTotalIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtgvIncome
            // 
            this.dtgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvIncome.Location = new System.Drawing.Point(6, 97);
            this.dtgvIncome.Name = "dtgvIncome";
            this.dtgvIncome.RowHeadersWidth = 51;
            this.dtgvIncome.RowTemplate.Height = 29;
            this.dtgvIncome.Size = new System.Drawing.Size(865, 350);
            this.dtgvIncome.TabIndex = 6;
            // 
            // btnStatitic
            // 
            this.btnStatitic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStatitic.Location = new System.Drawing.Point(397, 62);
            this.btnStatitic.Name = "btnStatitic";
            this.btnStatitic.Size = new System.Drawing.Size(94, 29);
            this.btnStatitic.TabIndex = 5;
            this.btnStatitic.Text = "Thống kê";
            this.btnStatitic.UseVisualStyleBackColor = true;
            this.btnStatitic.Click += new System.EventHandler(this.btnStatitic_Click);
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Location = new System.Drawing.Point(621, 64);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(250, 27);
            this.dtpkToDate.TabIndex = 4;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Location = new System.Drawing.Point(114, 64);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(250, 27);
            this.dtpkFromDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày kết thúc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(911, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng doanh thu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày bắt đầu:";
            // 
            // tbCategory
            // 
            this.tbCategory.Controls.Add(this.btnAddCategory);
            this.tbCategory.Controls.Add(this.btnSearchCategory);
            this.tbCategory.Controls.Add(this.dtgvCategory);
            this.tbCategory.Controls.Add(this.txbCategoryName);
            this.tbCategory.Controls.Add(this.txbCategoryID);
            this.tbCategory.Controls.Add(this.txbCategorySearchName);
            this.tbCategory.Controls.Add(this.btnDeleteCategory);
            this.tbCategory.Controls.Add(this.btnUpdateCategory);
            this.tbCategory.Controls.Add(this.btnShowCategory);
            this.tbCategory.Controls.Add(this.label7);
            this.tbCategory.Controls.Add(this.label6);
            this.tbCategory.Controls.Add(this.label5);
            this.tbCategory.Location = new System.Drawing.Point(4, 29);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tbCategory.Size = new System.Drawing.Size(1122, 453);
            this.tbCategory.TabIndex = 1;
            this.tbCategory.Text = "Danh mục";
            this.tbCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCategory.Location = new System.Drawing.Point(627, 140);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(94, 73);
            this.btnAddCategory.TabIndex = 13;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchCategory.Location = new System.Drawing.Point(525, 15);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(94, 29);
            this.btnSearchCategory.TabIndex = 12;
            this.btnSearchCategory.Text = "Tìm kiếm";
            this.btnSearchCategory.UseVisualStyleBackColor = true;
            this.btnSearchCategory.Click += new System.EventHandler(this.btnSearchCategory_Click);
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Location = new System.Drawing.Point(6, 51);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.RowHeadersWidth = 51;
            this.dtgvCategory.RowTemplate.Height = 29;
            this.dtgvCategory.Size = new System.Drawing.Size(613, 396);
            this.dtgvCategory.TabIndex = 11;
            this.dtgvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCategory_CellContentClick);
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.Location = new System.Drawing.Point(735, 94);
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.Size = new System.Drawing.Size(381, 27);
            this.txbCategoryName.TabIndex = 10;
            // 
            // txbCategoryID
            // 
            this.txbCategoryID.Location = new System.Drawing.Point(735, 50);
            this.txbCategoryID.Name = "txbCategoryID";
            this.txbCategoryID.ReadOnly = true;
            this.txbCategoryID.Size = new System.Drawing.Size(381, 27);
            this.txbCategoryID.TabIndex = 9;
            // 
            // txbCategorySearchName
            // 
            this.txbCategorySearchName.Location = new System.Drawing.Point(203, 16);
            this.txbCategorySearchName.Name = "txbCategorySearchName";
            this.txbCategorySearchName.Size = new System.Drawing.Size(316, 27);
            this.txbCategorySearchName.TabIndex = 8;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCategory.Location = new System.Drawing.Point(758, 140);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(94, 73);
            this.btnDeleteCategory.TabIndex = 7;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateCategory.Location = new System.Drawing.Point(891, 140);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(94, 73);
            this.btnUpdateCategory.TabIndex = 6;
            this.btnUpdateCategory.Text = "Sửa";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnShowCategory
            // 
            this.btnShowCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowCategory.Location = new System.Drawing.Point(1022, 140);
            this.btnShowCategory.Name = "btnShowCategory";
            this.btnShowCategory.Size = new System.Drawing.Size(94, 73);
            this.btnShowCategory.TabIndex = 5;
            this.btnShowCategory.Text = "Xem";
            this.btnShowCategory.UseVisualStyleBackColor = true;
            this.btnShowCategory.Click += new System.EventHandler(this.btnShowCategory_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(625, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tên danh mục:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID danh mục:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm kiếm theo tên:";
            // 
            // tbService
            // 
            this.tbService.Controls.Add(this.btnUpdateService);
            this.tbService.Controls.Add(this.btnShowService);
            this.tbService.Controls.Add(this.btnDeleteService);
            this.tbService.Controls.Add(this.btnAddService);
            this.tbService.Controls.Add(this.label12);
            this.tbService.Controls.Add(this.nmServicePrice);
            this.tbService.Controls.Add(this.cbCategoryName);
            this.tbService.Controls.Add(this.txbServiceName);
            this.tbService.Controls.Add(this.txbServiceID);
            this.tbService.Controls.Add(this.label11);
            this.tbService.Controls.Add(this.label10);
            this.tbService.Controls.Add(this.label9);
            this.tbService.Controls.Add(this.btnSearchService);
            this.tbService.Controls.Add(this.dtgvService);
            this.tbService.Controls.Add(this.txbSearchService);
            this.tbService.Controls.Add(this.label8);
            this.tbService.Location = new System.Drawing.Point(4, 29);
            this.tbService.Name = "tbService";
            this.tbService.Padding = new System.Windows.Forms.Padding(3);
            this.tbService.Size = new System.Drawing.Size(1122, 453);
            this.tbService.TabIndex = 2;
            this.tbService.Text = "Dịch vụ";
            this.tbService.UseVisualStyleBackColor = true;
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateService.Location = new System.Drawing.Point(890, 229);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(94, 73);
            this.btnUpdateService.TabIndex = 25;
            this.btnUpdateService.Text = "Sửa";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // btnShowService
            // 
            this.btnShowService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowService.Location = new System.Drawing.Point(1022, 229);
            this.btnShowService.Name = "btnShowService";
            this.btnShowService.Size = new System.Drawing.Size(94, 73);
            this.btnShowService.TabIndex = 24;
            this.btnShowService.Text = "Xem";
            this.btnShowService.UseVisualStyleBackColor = true;
            this.btnShowService.Click += new System.EventHandler(this.btnShowService_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteService.Location = new System.Drawing.Point(758, 229);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(94, 73);
            this.btnDeleteService.TabIndex = 23;
            this.btnDeleteService.Text = "Xóa";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddService.Location = new System.Drawing.Point(625, 229);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(94, 73);
            this.btnAddService.TabIndex = 22;
            this.btnAddService.Text = "Thêm";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(625, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Giá:";
            // 
            // nmServicePrice
            // 
            this.nmServicePrice.Location = new System.Drawing.Point(735, 181);
            this.nmServicePrice.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.nmServicePrice.Name = "nmServicePrice";
            this.nmServicePrice.Size = new System.Drawing.Size(381, 27);
            this.nmServicePrice.TabIndex = 20;
            // 
            // cbCategoryName
            // 
            this.cbCategoryName.FormattingEnabled = true;
            this.cbCategoryName.Location = new System.Drawing.Point(735, 136);
            this.cbCategoryName.Name = "cbCategoryName";
            this.cbCategoryName.Size = new System.Drawing.Size(381, 28);
            this.cbCategoryName.TabIndex = 19;
            // 
            // txbServiceName
            // 
            this.txbServiceName.Location = new System.Drawing.Point(735, 90);
            this.txbServiceName.Name = "txbServiceName";
            this.txbServiceName.Size = new System.Drawing.Size(381, 27);
            this.txbServiceName.TabIndex = 18;
            // 
            // txbServiceID
            // 
            this.txbServiceID.Location = new System.Drawing.Point(735, 46);
            this.txbServiceID.Name = "txbServiceID";
            this.txbServiceID.ReadOnly = true;
            this.txbServiceID.Size = new System.Drawing.Size(381, 27);
            this.txbServiceID.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(625, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tên danh mục:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(625, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Tên dịch vụ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(625, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "ID dịch vụ:";
            // 
            // btnSearchService
            // 
            this.btnSearchService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchService.Location = new System.Drawing.Point(525, 15);
            this.btnSearchService.Name = "btnSearchService";
            this.btnSearchService.Size = new System.Drawing.Size(94, 29);
            this.btnSearchService.TabIndex = 13;
            this.btnSearchService.Text = "Tìm kiếm";
            this.btnSearchService.UseVisualStyleBackColor = true;
            this.btnSearchService.Click += new System.EventHandler(this.btnSearchService_Click);
            // 
            // dtgvService
            // 
            this.dtgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvService.Location = new System.Drawing.Point(6, 49);
            this.dtgvService.Name = "dtgvService";
            this.dtgvService.RowHeadersWidth = 51;
            this.dtgvService.RowTemplate.Height = 29;
            this.dtgvService.Size = new System.Drawing.Size(613, 396);
            this.dtgvService.TabIndex = 12;
            this.dtgvService.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvService_CellContentClick);
            // 
            // txbSearchService
            // 
            this.txbSearchService.Location = new System.Drawing.Point(203, 16);
            this.txbSearchService.Name = "txbSearchService";
            this.txbSearchService.Size = new System.Drawing.Size(316, 27);
            this.txbSearchService.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(6, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tìm kiếm theo tên:";
            // 
            // tpCustomer
            // 
            this.tpCustomer.Controls.Add(this.label15);
            this.tpCustomer.Controls.Add(this.label16);
            this.tpCustomer.Controls.Add(this.label14);
            this.tpCustomer.Controls.Add(this.btnUpdateCustomer);
            this.tpCustomer.Controls.Add(this.btnShowCustomer);
            this.tpCustomer.Controls.Add(this.btnAddCustomer);
            this.tpCustomer.Controls.Add(this.btnDeleteCustomer);
            this.tpCustomer.Controls.Add(this.txbCustomerPhone);
            this.tpCustomer.Controls.Add(this.txbCustomerName);
            this.tpCustomer.Controls.Add(this.txbCustomerID);
            this.tpCustomer.Controls.Add(this.dtgvCustomer);
            this.tpCustomer.Controls.Add(this.btnSearchCustomer);
            this.tpCustomer.Controls.Add(this.txbSearchCustomer);
            this.tpCustomer.Controls.Add(this.label13);
            this.tpCustomer.Location = new System.Drawing.Point(4, 29);
            this.tpCustomer.Name = "tpCustomer";
            this.tpCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomer.Size = new System.Drawing.Size(1122, 453);
            this.tpCustomer.TabIndex = 3;
            this.tpCustomer.Text = "Khách hàng";
            this.tpCustomer.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(625, 137);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "SĐT khách hàng:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(625, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 20);
            this.label16.TabIndex = 29;
            this.label16.Text = "Tên khách hàng:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(625, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "ID khách hàng:";
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateCustomer.Location = new System.Drawing.Point(889, 183);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(94, 73);
            this.btnUpdateCustomer.TabIndex = 26;
            this.btnUpdateCustomer.Text = "Sửa";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnShowCustomer
            // 
            this.btnShowCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowCustomer.Location = new System.Drawing.Point(1022, 183);
            this.btnShowCustomer.Name = "btnShowCustomer";
            this.btnShowCustomer.Size = new System.Drawing.Size(94, 73);
            this.btnShowCustomer.TabIndex = 25;
            this.btnShowCustomer.Text = "Xem";
            this.btnShowCustomer.UseVisualStyleBackColor = true;
            this.btnShowCustomer.Click += new System.EventHandler(this.btnShowCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCustomer.Location = new System.Drawing.Point(625, 183);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(94, 73);
            this.btnAddCustomer.TabIndex = 24;
            this.btnAddCustomer.Text = "Thêm";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCustomer.Location = new System.Drawing.Point(758, 183);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(94, 73);
            this.btnDeleteCustomer.TabIndex = 23;
            this.btnDeleteCustomer.Text = "Xóa";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // txbCustomerPhone
            // 
            this.txbCustomerPhone.Location = new System.Drawing.Point(749, 134);
            this.txbCustomerPhone.Name = "txbCustomerPhone";
            this.txbCustomerPhone.Size = new System.Drawing.Size(367, 27);
            this.txbCustomerPhone.TabIndex = 21;
            // 
            // txbCustomerName
            // 
            this.txbCustomerName.Location = new System.Drawing.Point(749, 91);
            this.txbCustomerName.Name = "txbCustomerName";
            this.txbCustomerName.Size = new System.Drawing.Size(367, 27);
            this.txbCustomerName.TabIndex = 20;
            // 
            // txbCustomerID
            // 
            this.txbCustomerID.Location = new System.Drawing.Point(749, 49);
            this.txbCustomerID.Name = "txbCustomerID";
            this.txbCustomerID.ReadOnly = true;
            this.txbCustomerID.Size = new System.Drawing.Size(367, 27);
            this.txbCustomerID.TabIndex = 19;
            // 
            // dtgvCustomer
            // 
            this.dtgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomer.Location = new System.Drawing.Point(6, 49);
            this.dtgvCustomer.Name = "dtgvCustomer";
            this.dtgvCustomer.RowHeadersWidth = 51;
            this.dtgvCustomer.RowTemplate.Height = 29;
            this.dtgvCustomer.Size = new System.Drawing.Size(613, 396);
            this.dtgvCustomer.TabIndex = 15;
            this.dtgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCustomer_CellContentClick);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchCustomer.Location = new System.Drawing.Point(525, 15);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(94, 29);
            this.btnSearchCustomer.TabIndex = 14;
            this.btnSearchCustomer.Text = "Tìm kiếm";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // txbSearchCustomer
            // 
            this.txbSearchCustomer.Location = new System.Drawing.Point(203, 16);
            this.txbSearchCustomer.Name = "txbSearchCustomer";
            this.txbSearchCustomer.Size = new System.Drawing.Size(316, 27);
            this.txbSearchCustomer.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(6, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 28);
            this.label13.TabIndex = 2;
            this.label13.Text = "Tìm kiếm theo tên:";
            // 
            // tpEmployee
            // 
            this.tpEmployee.Controls.Add(this.btnShowEmployee);
            this.tpEmployee.Controls.Add(this.btnUpdateEmployee);
            this.tpEmployee.Controls.Add(this.btnDeleteEmployee);
            this.tpEmployee.Controls.Add(this.btnAddEmployee);
            this.tpEmployee.Controls.Add(this.label20);
            this.tpEmployee.Controls.Add(this.label19);
            this.tpEmployee.Controls.Add(this.label18);
            this.tpEmployee.Controls.Add(this.txbRoleEmp);
            this.tpEmployee.Controls.Add(this.txbPasswordEmp);
            this.tpEmployee.Controls.Add(this.txbUserNameEmp);
            this.tpEmployee.Controls.Add(this.btnSearchUserNameEmp);
            this.tpEmployee.Controls.Add(this.txbSearchUserNameEmp);
            this.tpEmployee.Controls.Add(this.label17);
            this.tpEmployee.Controls.Add(this.dtgvEmployee);
            this.tpEmployee.Location = new System.Drawing.Point(4, 29);
            this.tpEmployee.Name = "tpEmployee";
            this.tpEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployee.Size = new System.Drawing.Size(1122, 453);
            this.tpEmployee.TabIndex = 4;
            this.tpEmployee.Text = "Nhân viên";
            this.tpEmployee.UseVisualStyleBackColor = true;
            // 
            // btnShowEmployee
            // 
            this.btnShowEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowEmployee.Location = new System.Drawing.Point(1022, 180);
            this.btnShowEmployee.Name = "btnShowEmployee";
            this.btnShowEmployee.Size = new System.Drawing.Size(94, 73);
            this.btnShowEmployee.TabIndex = 29;
            this.btnShowEmployee.Text = "Xem";
            this.btnShowEmployee.UseVisualStyleBackColor = true;
            this.btnShowEmployee.Click += new System.EventHandler(this.btnShowEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateEmployee.Location = new System.Drawing.Point(888, 180);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(94, 73);
            this.btnUpdateEmployee.TabIndex = 28;
            this.btnUpdateEmployee.Text = "Sửa";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteEmployee.Location = new System.Drawing.Point(755, 180);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(94, 73);
            this.btnDeleteEmployee.TabIndex = 27;
            this.btnDeleteEmployee.Text = "Xóa";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddEmployee.Location = new System.Drawing.Point(625, 180);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(94, 73);
            this.btnAddEmployee.TabIndex = 26;
            this.btnAddEmployee.Text = "Thêm";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(625, 137);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 20);
            this.label20.TabIndex = 25;
            this.label20.Text = "Vai trò:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(625, 93);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 20);
            this.label19.TabIndex = 24;
            this.label19.Text = "Mật khẩu:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(625, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 20);
            this.label18.TabIndex = 23;
            this.label18.Text = "Tên đăng nhập:";
            // 
            // txbRoleEmp
            // 
            this.txbRoleEmp.Location = new System.Drawing.Point(741, 134);
            this.txbRoleEmp.Name = "txbRoleEmp";
            this.txbRoleEmp.Size = new System.Drawing.Size(375, 27);
            this.txbRoleEmp.TabIndex = 22;
            // 
            // txbPasswordEmp
            // 
            this.txbPasswordEmp.Location = new System.Drawing.Point(741, 90);
            this.txbPasswordEmp.Name = "txbPasswordEmp";
            this.txbPasswordEmp.Size = new System.Drawing.Size(375, 27);
            this.txbPasswordEmp.TabIndex = 21;
            // 
            // txbUserNameEmp
            // 
            this.txbUserNameEmp.Location = new System.Drawing.Point(741, 48);
            this.txbUserNameEmp.Name = "txbUserNameEmp";
            this.txbUserNameEmp.Size = new System.Drawing.Size(375, 27);
            this.txbUserNameEmp.TabIndex = 20;
            // 
            // btnSearchUserNameEmp
            // 
            this.btnSearchUserNameEmp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchUserNameEmp.Location = new System.Drawing.Point(525, 16);
            this.btnSearchUserNameEmp.Name = "btnSearchUserNameEmp";
            this.btnSearchUserNameEmp.Size = new System.Drawing.Size(94, 29);
            this.btnSearchUserNameEmp.TabIndex = 19;
            this.btnSearchUserNameEmp.Text = "Tìm kiếm";
            this.btnSearchUserNameEmp.UseVisualStyleBackColor = true;
            this.btnSearchUserNameEmp.Click += new System.EventHandler(this.btnSearchUserNameEmp_Click);
            // 
            // txbSearchUserNameEmp
            // 
            this.txbSearchUserNameEmp.Location = new System.Drawing.Point(203, 16);
            this.txbSearchUserNameEmp.Name = "txbSearchUserNameEmp";
            this.txbSearchUserNameEmp.Size = new System.Drawing.Size(316, 27);
            this.txbSearchUserNameEmp.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(6, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(191, 28);
            this.label17.TabIndex = 17;
            this.label17.Text = "Tìm kiếm theo tên:";
            // 
            // dtgvEmployee
            // 
            this.dtgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmployee.Location = new System.Drawing.Point(6, 51);
            this.dtgvEmployee.Name = "dtgvEmployee";
            this.dtgvEmployee.RowHeadersWidth = 51;
            this.dtgvEmployee.RowTemplate.Height = 29;
            this.dtgvEmployee.Size = new System.Drawing.Size(613, 396);
            this.dtgvEmployee.TabIndex = 16;
            this.dtgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEmployee_CellContentClick);
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 510);
            this.Controls.Add(this.tcAdmin);
            this.MaximizeBox = false;
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí";
            this.tcAdmin.ResumeLayout(false);
            this.tpIncome.ResumeLayout(false);
            this.tpIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIncome)).EndInit();
            this.tbCategory.ResumeLayout(false);
            this.tbCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.tbService.ResumeLayout(false);
            this.tbService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmServicePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvService)).EndInit();
            this.tpCustomer.ResumeLayout(false);
            this.tpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).EndInit();
            this.tpEmployee.ResumeLayout(false);
            this.tpEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpIncome;
        private System.Windows.Forms.TabPage tbCategory;
        private System.Windows.Forms.TabPage tbService;
        private System.Windows.Forms.TabPage tpCustomer;
        private System.Windows.Forms.TabPage tpEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTotalIncome;
        private System.Windows.Forms.DataGridView dtgvIncome;
        private System.Windows.Forms.Button btnStatitic;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchCategory;
        private System.Windows.Forms.DataGridView dtgvCategory;
        private System.Windows.Forms.TextBox txbCategoryName;
        private System.Windows.Forms.TextBox txbCategoryID;
        private System.Windows.Forms.TextBox txbCategorySearchName;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnShowCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Button btnShowService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nmServicePrice;
        private System.Windows.Forms.ComboBox cbCategoryName;
        private System.Windows.Forms.TextBox txbServiceName;
        private System.Windows.Forms.TextBox txbServiceID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearchService;
        private System.Windows.Forms.DataGridView dtgvService;
        private System.Windows.Forms.TextBox txbSearchService;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnShowCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.TextBox txbCustomerPhone;
        private System.Windows.Forms.TextBox txbCustomerName;
        private System.Windows.Forms.TextBox txbCustomerID;
        private System.Windows.Forms.DataGridView dtgvCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txbSearchCustomer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dtgvEmployee;
        private System.Windows.Forms.Button btnShowEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txbRoleEmp;
        private System.Windows.Forms.TextBox txbPasswordEmp;
        private System.Windows.Forms.TextBox txbUserNameEmp;
        private System.Windows.Forms.Button btnSearchUserNameEmp;
        private System.Windows.Forms.TextBox txbSearchUserNameEmp;
        private System.Windows.Forms.Button btnAddCategory;
    }
}