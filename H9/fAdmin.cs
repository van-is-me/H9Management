using Repository.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;

namespace H9
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            loadListBill();
            loadDataCategory();
            loadCategory();
            loadDataService();
            loadDataCustomer();
            loadDataEmployee();          
            btnUpdateCategory.Enabled = false;
            btnDeleteCategory.Enabled = false;
            btnUpdateService.Enabled = false;
            btnDeleteService.Enabled = false;
            btnUpdateCustomer.Enabled = false;
            btnDeleteCustomer.Enabled = false;
            btnUpdateEmployee.Enabled = false;
            btnDeleteEmployee.Enabled = false;
            nmServicePrice.Value = 0;
        }

        #region methods Income
        void loadListBill()
        {
            var OrderRepo = new RepositoryBase<Order>();
            var listBill = OrderRepo.GetAll().Where(e => Convert.ToInt32(e.Status) == 1).Select(e => new { e.OrId, e.UserName, e.CusId, e.DateCheckIn, e.DateCheckOut, e.Total, e.MainEmp, e.SubEmp }).OrderByDescending(e => e.OrId).ToList();
            dtgvIncome.DataSource = listBill;
            int totalPrice = 0;
            dtgvIncome.Columns[5].ToString();
            dtgvIncome.Columns[5].DefaultCellStyle.Format = "0,0 vnđ";
            dtgvIncome.Columns[0].HeaderText = "ID hóa đơn";
            dtgvIncome.Columns[1].HeaderText = "Mã nhân viên";
            dtgvIncome.Columns[2].HeaderText = "ID khách hàng";
            dtgvIncome.Columns[3].HeaderText = "Ngày sử dụng";
            dtgvIncome.Columns[4].HeaderText = "Ngày kết thú";
            dtgvIncome.Columns[5].HeaderText = "Tổng hóa đơn";
            dtgvIncome.Columns[6].HeaderText = "Thợ chính";
            dtgvIncome.Columns[7].HeaderText = "Thợ phụ";
            dtgvIncome.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvIncome.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvIncome.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvIncome.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvIncome.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvIncome.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvIncome.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvIncome.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foreach (var item in listBill)
            {
                totalPrice += Convert.ToInt32(item.Total);
            }
            txbTotalIncome.Text = String.Format("{0:0,0 vnđ}", totalPrice);
        }
        void loadListBill(DateTime checkIn, DateTime checkOut)
        {
            var OrderRepo = new RepositoryBase<Order>();
            var listBill = OrderRepo.GetAll().Where(e => e.DateCheckOut >= checkIn && e.DateCheckOut <= checkOut && Convert.ToInt32(e.Status) == 1).Select(e => new { e.OrId, e.UserName, e.CusId, e.DateCheckIn, e.DateCheckOut, e.Total }).OrderByDescending(e => e.OrId).ToList();
            dtgvIncome.DataSource = listBill;
            int totalPrice = 0;
            dtgvIncome.Columns[5].ToString();
            dtgvIncome.Columns[5].DefaultCellStyle.Format = "0,0 vnđ";
            dtgvIncome.Columns[0].HeaderText = "ID hóa đơn";
            dtgvIncome.Columns[1].HeaderText = "Mã nhân viên";
            dtgvIncome.Columns[2].HeaderText = "ID khách hàng";
            dtgvIncome.Columns[3].HeaderText = "Ngày sử dụng dịch vụ";
            dtgvIncome.Columns[4].HeaderText = "Ngày kết thúc dịch vụ";
            dtgvIncome.Columns[5].HeaderText = "Tổng tiền hóa đơn";
            dtgvIncome.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvIncome.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvIncome.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvIncome.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvIncome.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvIncome.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foreach (var item in listBill)
            {
                totalPrice += Convert.ToInt32(item.Total);
            }
            txbTotalIncome.Text = String.Format("{0:0,0 vnđ}", totalPrice);
        }
        #endregion

        #region events Income
        private void btnStatitic_Click(object sender, EventArgs e)
        {
            loadListBill(dtpkFromDate.Value, dtpkToDate.Value);
        }

        #endregion

        #region methods Category
        void loadDataCategory()
        {
            var CategoryRepo = new RepositoryBase<Category>();
            var listCategory = CategoryRepo.GetAll().Select(e => new { e.CateId, e.CateName }).OrderByDescending(e => e.CateId).ToList();
            dtgvCategory.DataSource = listCategory;
            dtgvCategory.Columns[0].HeaderText = "ID danh mục";
            dtgvCategory.Columns[1].HeaderText = "Tên danh mục";
            dtgvCategory.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvCategory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        void ResetFormCate()
        {
            txbCategoryID.Text = "";
            txbCategoryName.Text = "";
            txbCategorySearchName.Text = "";
            btnDeleteCategory.Enabled = false;
            btnUpdateCategory.Enabled = false;
            btnAddCategory.Enabled = true;
            btnSearchCategory.Enabled = true;
        }

        void searchCate()
        {
            var CategoryRepo = new RepositoryBase<Category>();
            var listCategory = CategoryRepo.GetAll().Select(e => new { e.CateId, e.CateName }).Where(e => e.CateName.Contains(txbCategorySearchName.Text)).OrderByDescending(e => e.CateId).ToList();
            dtgvCategory.DataSource = listCategory;
            ResetFormCate();
        }

        bool CheckNullCategory()
        {
            if (txbCategoryName.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên danh mục", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        void addCate()
        {
            if (!CheckNullCategory())
            {
                return;
            }
            var CateRepo = new RepositoryBase<Category>();
            var category = CateRepo.GetAll().Where(p => p.CateName.Trim().Equals(txbCategoryName.Text.Trim())).FirstOrDefault();
            if (category != null)
            {
                MessageBox.Show("Tên danh mục đã tồn tại vui lòng nhập tên khác", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                var CateName = txbCategoryName.Text.ToString();
                var CategoryRepo = new RepositoryBase<Category>();
                var Category = new Category();
                Category.CateName = CateName;
                CategoryRepo.Create(Category);
                var ListCategory = CategoryRepo.GetAll().Select(e => new { e.CateId, e.CateName }).OrderByDescending(e => e.CateId).ToList();
                dtgvCategory.DataSource = ListCategory;
                ResetFormCate();
            }
        }

        void deleteCate()
        {
            var ID = txbCategoryID.Text;
            var CategoryRepo = new RepositoryBase<Category>();
            var obj = CategoryRepo.GetAll().Where(e => e.CateId.ToString().Equals(ID)).FirstOrDefault();
            if (obj != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CategoryRepo.Delete(obj);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }
            }
            var listCategory = CategoryRepo.GetAll().Select(e => new { e.CateId, e.CateName }).OrderByDescending(e => e.CateId).ToList();
            dtgvCategory.DataSource = listCategory;
            ResetFormCate();
        }

        void editCate()
        {
            if (!CheckNullCategory())
            {
                return;
            }
            var CateRepo = new RepositoryBase<Category>();
            var category = CateRepo.GetAll().Where(p => p.CateName.Trim().Equals(txbCategoryName.Text.Trim())).FirstOrDefault();
            if (category != null)
            {
                MessageBox.Show("Tên danh mục đã tồn tại vui lòng nhập tên khác", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                var CateID = txbCategoryID.Text;
                var CateName = txbCategoryName.Text.Trim();
                var CategoryRepo = new RepositoryBase<Category>();
                var cate = CategoryRepo.GetAll().Where(e => e.CateId.ToString().Equals(CateID)).FirstOrDefault();
                if (cate != null)
                {
                    cate.CateName = CateName;
                    CategoryRepo.Update(cate);
                }
                var listCate = CategoryRepo.GetAll().Select(e => new { e.CateId, e.CateName }).OrderByDescending(e => e.CateId).ToList();
                dtgvCategory.DataSource = listCate;
                ResetFormCate();
            }
        }
        #endregion

        #region events Category
        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            searchCate();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            addCate();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            deleteCate();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            editCate();
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            ResetFormCate();
            loadDataCategory();
        }

        private void dtgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var rowSelected = this.dtgvCategory.Rows[e.RowIndex];
                txbCategoryID.Text = rowSelected.Cells["CateID"].Value.ToString();
                txbCategoryName.Text = rowSelected.Cells["CateName"].Value.ToString();
            }
            btnAddCategory.Enabled = false;
            btnDeleteCategory.Enabled = true;
            btnUpdateCategory.Enabled = true;
            btnSearchCategory.Enabled = true;
            btnShowCategory.Enabled = true;
        }

        #endregion

        #region methods Service
        void loadCategory()
        {
            var repo = new RepositoryBase<Category>();
            var list = repo.GetAll().ToList();
            cbCategoryName.DisplayMember = "CateName";
            cbCategoryName.ValueMember = "CateID";
            cbCategoryName.DataSource = list;
        }
        void loadDataService()
        {
            var ServiceRepo = new RepositoryBase<Service>();
            var listService = ServiceRepo.GetAll().Select(e => new { e.SerId, e.SerName, e.Price, e.CateId }).OrderByDescending(e => e.SerId).ToList();
            dtgvService.DataSource = listService;
            dtgvService.Columns[0].HeaderText = "ID dịch vụ";
            dtgvService.Columns[1].HeaderText = "Tên dịch vụ";
            dtgvService.Columns[2].HeaderText = "Giá dịch vụ";
            dtgvService.Columns[3].HeaderText = "ID danh mục";
            dtgvService.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvService.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvService.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvService.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        void ResetFormService()
        {
            txbServiceID.Text = "";
            txbServiceName.Text = "";
            txbSearchService.Text = "";
            nmServicePrice.Value = 0;
            btnDeleteService.Enabled = false;
            btnUpdateService.Enabled = false;
            btnAddService.Enabled = true;
            btnSearchService.Enabled = true;
        }

        void searchService()
        {
            var ServiceRepo = new RepositoryBase<Service>();
            var listService = ServiceRepo.GetAll().Select(e => new { e.SerId, e.SerName, e.Price, e.CateId }).Where(e => e.SerName.Contains(txbSearchService.Text)).OrderByDescending(e => e.SerId).ToList();
            dtgvService.DataSource = listService;
            ResetFormService();
        }

        bool CheckNullService()
        {
            if (txbServiceName.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        void addService()
        {
            if (!CheckNullService())
            {
                return;
            }
            var SerRepo = new RepositoryBase<Service>();
            var service = SerRepo.GetAll().Where(p => p.SerName.Trim().Equals(txbServiceName.Text.Trim())).FirstOrDefault();
            if (service != null)
            {
                MessageBox.Show("Tên dịch vụ đã tồn tại vui lòng nhập tên khác", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                var ServiceName = txbServiceName.Text.ToString();
                var Price = (int)nmServicePrice.Value;
                var CateID = (int)cbCategoryName.SelectedValue;
                var ServiceRepo = new RepositoryBase<Service>();
                var Service = new Service();
                Service.SerName = ServiceName;
                Service.Price = Price;
                Service.CateId = CateID;
                ServiceRepo.Create(Service);
                var listService = ServiceRepo.GetAll().Select(e => new { e.SerId, e.SerName, e.Price, e.CateId }).OrderByDescending(e => e.SerId).ToList();
                dtgvService.DataSource = listService;
                ResetFormService();
            }
        }

        void deleteService()
        {
            var ID = txbServiceID.Text;
            var ServiceRepo = new RepositoryBase<Service>();
            var obj = ServiceRepo.GetAll().Where(e => e.SerId.ToString().Equals(ID)).FirstOrDefault();
            if (obj != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ServiceRepo.Delete(obj);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }
            }
            var listService = ServiceRepo.GetAll().Select(e => new { e.SerId, e.SerName, e.Price, e.CateId }).OrderByDescending(e => e.SerId).ToList();
            dtgvService.DataSource = listService;
            ResetFormService();
        }

        void editService()
        {
            if (!CheckNullService())
            {
                return;
            }
            var SerID = txbServiceID.Text;
            var SerName = txbServiceName.Text.Trim();
            var Price = int.Parse(nmServicePrice.Value.ToString());
            var CateID = int.Parse(cbCategoryName.SelectedValue.ToString());
            var ServiceRepo = new RepositoryBase<Service>();
            var ser = ServiceRepo.GetAll().Where(e => e.SerId.ToString().Equals(SerID)).FirstOrDefault();
            if (ser != null)
            {
                ser.SerName = SerName;
                ser.CateId = CateID;
                ser.Price = Price;
                ServiceRepo.Update(ser);
            }
            var listSer = ServiceRepo.GetAll().Select(e => new { e.SerId, e.SerName, e.Price, e.CateId }).OrderByDescending(e => e.SerId).ToList();
            dtgvService.DataSource = listSer;
            ResetFormService();
        }
        #endregion

        #region events Service
        private void btnSearchService_Click(object sender, EventArgs e)
        {
            searchService();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            addService();
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            deleteService();
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            editService();
        }

        private void btnShowService_Click(object sender, EventArgs e)
        {
            ResetFormService();
            loadDataService();
        }

        private void dtgvService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var repo = new RepositoryBase<Category>();
                var list = repo.GetAll().ToList();
                cbCategoryName.DisplayMember = "CateName";
                cbCategoryName.ValueMember = "CateID";
                cbCategoryName.DataSource = list;
                var rowSelected = this.dtgvService.Rows[e.RowIndex];
                txbServiceID.Text = rowSelected.Cells["SerID"].Value.ToString();
                txbServiceName.Text = rowSelected.Cells["SerName"].Value.ToString();
                nmServicePrice.Value = Convert.ToInt32(rowSelected.Cells["Price"].Value.ToString());
                cbCategoryName.SelectedValue = rowSelected.Cells["CateID"].Value;
            }
            btnAddService.Enabled = false;
            btnDeleteService.Enabled = true;
            btnUpdateService.Enabled = true;
            btnSearchService.Enabled = true;
            btnShowService.Enabled = true;
        }
        #endregion

        #region methods Customer
        void loadDataCustomer()
        {
            var repo = new RepositoryBase<Customer>();
            var listCustomer = repo.GetAll().Select(p => new { p.CusId, p.CusName, p.Phone }).OrderByDescending(p => p.CusId).ToList();
            dtgvCustomer.DataSource = listCustomer;
            dtgvCustomer.Columns[0].HeaderText = "ID khách hàng";
            dtgvCustomer.Columns[1].HeaderText = "Họ và tên";
            dtgvCustomer.Columns[2].HeaderText = "Số điện thoại";
            dtgvCustomer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvCustomer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvCustomer.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        void ResetFormCustomer()
        {
            txbCustomerID.Text = "";
            txbCustomerName.Text = "";
            txbCustomerPhone.Text = "";
            txbSearchCustomer.Text = "";
            btnDeleteCustomer.Enabled = false;
            btnUpdateCustomer.Enabled = false;
            btnAddCustomer.Enabled = true;
            btnSearchCustomer.Enabled = true;
            btnShowCustomer.Enabled = true;
        }

        void searchCustomer()
        {
            var CustomerRepo = new RepositoryBase<Customer>();
            var listCustomer = CustomerRepo.GetAll().Select(e => new { e.CusId, e.CusName, e.Phone }).Where(e => e.CusName.Contains(txbSearchCustomer.Text)).OrderByDescending(e => e.CusId).ToList();
            dtgvCustomer.DataSource = listCustomer;
            ResetFormCustomer();
        }

        bool CheckNullCustomer()
        {
            if (txbCustomerName.Text.Trim() == "" || txbCustomerPhone.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        void addCustomer()
        {
            if (!CheckNullCustomer())
            {
                return;
            }
            var CusRepo = new RepositoryBase<Customer>();
            var customer = CusRepo.GetAll().Where(p => p.CusName.Trim().Equals(txbCustomerName.Text.Trim())).FirstOrDefault();
            if (customer != null)
            {
                MessageBox.Show("Tên khách hàng đã tồn tại vui lòng nhập tên khác", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                var CusName = txbCustomerName.Text.ToString();
                var CusPhone = txbCustomerPhone.Text.ToString();
                var CustomerRepo = new RepositoryBase<Customer>();
                var Customer = new Customer();
                Customer.CusName = CusName;
                Customer.Phone = CusPhone;
                CustomerRepo.Create(Customer);
                var ListCustomer = CustomerRepo.GetAll().Select(e => new { e.CusId, e.CusName, e.Phone }).OrderByDescending(e => e.CusId).ToList();
                dtgvCustomer.DataSource = ListCustomer;
                ResetFormCustomer();
            }
        }

        void deleteCustomer()
        {
            var ID = txbCustomerID.Text;
            var CustomerRepo = new RepositoryBase<Customer>();
            var obj = CustomerRepo.GetAll().Where(e => e.CusId.ToString().Equals(ID)).FirstOrDefault();
            if (obj != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CustomerRepo.Delete(obj);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }
            }
            var listCustomer = CustomerRepo.GetAll().Select(e => new { e.CusId, e.CusName, e.Phone }).OrderByDescending(e => e.CusId).ToList();
            dtgvCustomer.DataSource = listCustomer;
            ResetFormCustomer();
        }

        void editCustomer()
        {
            if (!CheckNullCustomer())
            {
                return;
            }
            var CusRepo = new RepositoryBase<Customer>();
            var cus = CusRepo.GetAll().Where(p => p.CusName.Trim().Equals(txbCustomerName.Text.Trim())).FirstOrDefault();
            if (cus != null)
            {
                MessageBox.Show("Tên khách hàng đã tồn tại vui lòng nhập tên khác", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                var CusID = txbCustomerID.Text;
                var CusName = txbCustomerName.Text.Trim();
                var CusPhone = txbCustomerPhone.Text.Trim();
                var CustomerRepo = new RepositoryBase<Customer>();
                var customer = CustomerRepo.GetAll().Where(e => e.CusId.ToString().Equals(CusID)).FirstOrDefault();
                if (customer != null)
                {
                    customer.CusName = CusName;
                    customer.Phone = CusPhone;
                    CustomerRepo.Update(customer);
                }
                var listCustomer = CustomerRepo.GetAll().Select(e => new { e.CusId, e.CusName, e.Phone }).OrderByDescending(e => e.CusId).ToList();
                dtgvCustomer.DataSource = listCustomer;
                ResetFormCustomer();
            }
        }
        #endregion

        #region events Customer
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            searchCustomer();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            addCustomer();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            deleteCustomer();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            editCustomer();
        }

        private void btnShowCustomer_Click(object sender, EventArgs e)
        {
            ResetFormCustomer();
            loadDataCustomer();
        }
        private void dtgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var rowSelected = this.dtgvCustomer.Rows[e.RowIndex];
                txbCustomerID.Text = rowSelected.Cells["CusID"].Value.ToString();
                txbCustomerName.Text = rowSelected.Cells["CusName"].Value.ToString();
                txbCustomerPhone.Text = rowSelected.Cells["Phone"].Value.ToString();
            }
            btnAddCustomer.Enabled = false;
            btnDeleteCustomer.Enabled = true;
            btnUpdateCustomer.Enabled = true;
            btnSearchCustomer.Enabled = true;
            btnShowCustomer.Enabled = true;
        }
        #endregion

        #region methods Employee
        void loadDataEmployee()
        {
            var repo = new RepositoryBase<User>();
            var listEmp = repo.GetAll().Select(p => new { p.UserName, p.PassWord, p.Role }).ToList();
            dtgvEmployee.DataSource = listEmp;
            dtgvEmployee.Columns[0].HeaderText = "Tên đăng nhập";
            dtgvEmployee.Columns[1].HeaderText = "Mật khẩu";
            dtgvEmployee.Columns[2].HeaderText = "Vai trò";
            dtgvEmployee.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvEmployee.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvEmployee.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        void ResetFormEmp()
        {
            txbUserNameEmp.Text = "";
            txbPasswordEmp.Text = "";
            txbRoleEmp.Text = "";
            txbSearchUserNameEmp.Text = "";
            btnDeleteEmployee.Enabled = false;
            btnUpdateEmployee.Enabled = false;
            btnAddEmployee.Enabled = true;
            btnSearchUserNameEmp.Enabled = true;
            btnShowEmployee.Enabled = true;
        }

        void searchEmp()
        {
            var EmpRepo = new RepositoryBase<User>();
            var listEmp = EmpRepo.GetAll().Select(e => new { e.UserName, e.PassWord, e.Role }).Where(e => e.UserName.Contains(txbSearchUserNameEmp.Text)).ToList();
            dtgvEmployee.DataSource = listEmp;
            ResetFormEmp();
        }

        bool CheckNullEmp()
        {
            if (txbPasswordEmp.Text == "" || txbRoleEmp.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        void addEmp()
        {
            if (!CheckNullEmp())
            {
                return;
            }
            var EmpRepo = new RepositoryBase<User>();
            var emp = EmpRepo.GetAll().Where(p => p.UserName.Trim().Equals(txbUserNameEmp.Text.Trim())).FirstOrDefault();
            if (emp != null)
            {
                MessageBox.Show("Tên đăng nhập nhân viên đã tồn tại vui lòng nhập tên khác", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                var UserName = txbUserNameEmp.Text.ToString();
                var Password = txbPasswordEmp.Text.ToString();
                var Role = txbRoleEmp.Text.ToString();
                var EmployeeRepo = new RepositoryBase<User>();
                var Emp = new User();
                Emp.UserName = UserName;
                Emp.PassWord = Password;
                Emp.Role = Role;
                EmployeeRepo.Create(Emp);
                var ListEmp = EmployeeRepo.GetAll().Select(e => new { e.UserName, e.PassWord, e.Role }).ToList();
                dtgvEmployee.DataSource = ListEmp;
                ResetFormEmp();
            }
        }

        void deleteEmp()
        {
            var UserName = txbUserNameEmp.Text;
            var EmpRepo = new RepositoryBase<User>();
            var obj = EmpRepo.GetAll().Where(e => e.UserName.ToString().Equals(UserName)).FirstOrDefault();
            if (obj != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    EmpRepo.Delete(obj);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }
            }
            var listEmp = EmpRepo.GetAll().Select(e => new { e.UserName, e.PassWord, e.Role }).ToList();
            dtgvEmployee.DataSource = listEmp;
            txbUserNameEmp.ReadOnly = false;
            ResetFormEmp();
        }

        void editEmp()
        {
            if (!CheckNullEmp())
            {
                return;
            }
            var UserName = txbUserNameEmp.Text;
            var Password = txbPasswordEmp.Text;
            var Role = txbRoleEmp.Text.Trim();
            var empRepo = new RepositoryBase<User>();
            var emp = empRepo.GetAll().Where(e => e.UserName.ToString().Equals(UserName)).FirstOrDefault();
            if (emp != null)
            {
                emp.UserName = UserName;
                emp.PassWord = Password;
                emp.Role = Role;
                empRepo.Update(emp);
            }
            var listEmp = empRepo.GetAll().Select(e => new { e.UserName, e.PassWord, e.Role }).ToList();
            dtgvEmployee.DataSource = listEmp;
            ResetFormEmp();
            txbUserNameEmp.ReadOnly = false;
        }


        #endregion

        #region events Employee
        private void dtgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var rowSelected = this.dtgvEmployee.Rows[e.RowIndex];
                txbUserNameEmp.Text = rowSelected.Cells["UserName"].Value.ToString();
                txbPasswordEmp.Text = rowSelected.Cells["Password"].Value.ToString();
                txbRoleEmp.Text = rowSelected.Cells["Role"].Value.ToString();
            }
            btnAddEmployee.Enabled = false;
            btnDeleteEmployee.Enabled = true;
            btnUpdateEmployee.Enabled = true;
            btnSearchUserNameEmp.Enabled = true;
            btnShowEmployee.Enabled = true;
            txbUserNameEmp.ReadOnly = true;
        }

        private void btnSearchUserNameEmp_Click(object sender, EventArgs e)
        {
            searchEmp();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            addEmp();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            deleteEmp();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            editEmp();
        }

        private void btnShowEmployee_Click(object sender, EventArgs e)
        {
            ResetFormEmp();
            loadDataEmployee();
        }
        #endregion

    }
}
