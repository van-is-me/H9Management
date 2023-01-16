using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H9
{
    public partial class fAddCustomer : Form
    {
        private User _user = new User();
        fService obj = (fService)Application.OpenForms["fService"];
        public fAddCustomer()
        {
            InitializeComponent();
            loadCustomer();
        }
        public fAddCustomer(User _user)
        {
            InitializeComponent();
            loadCustomer();
        }

        #region methods AddCustomer
        void loadCustomer()
        {
            var repo = new RepositoryBase<Customer>();
            var listCustomer = repo.GetAll().Select(p => new { p.CusId, p.CusName, p.Phone }).OrderByDescending(p => p.CusId).ToList();
            dtgvAddCustomer.DataSource = listCustomer;
            dtgvAddCustomer.Columns[0].HeaderText = "ID";
            dtgvAddCustomer.Columns[1].HeaderText = "Họ và tên";
            dtgvAddCustomer.Columns[2].HeaderText = "Số điện thoại";
            dtgvAddCustomer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvAddCustomer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvAddCustomer.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        bool CheckNull()
        {
            if (txbCustomerName.Text.Trim() == "" || txbCustomerPhone.Text.Trim() == "")
            {
                MessageBox.Show("Tất cả đầu vào đều không được để trống, vui lòng nhập đầy đủ", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        void ResetFormCus()
        {
            txbCustomerName.Text = "";
            txbCustomerPhone.Text = "";
        }
        #endregion

        #region event AddCustomer
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!CheckNull())
            {
                return;
            }
            var repo = new RepositoryBase<Customer>();
            var customer = repo.GetAll().Where(p => p.CusName.Trim().Equals(txbCustomerName.Text.Trim())).FirstOrDefault();
            if (customer != null)
            {
                MessageBox.Show("Tên khách hàng đã tồn tại vui lòng nhập tên khác", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                var cusName = txbCustomerName.Text;
                var phoneNumber = txbCustomerPhone.Text;
                var cusRepo = new RepositoryBase<Customer>();
                var customer1 = new Customer();
                customer1.CusName = cusName;
                customer1.Phone = phoneNumber;
                cusRepo.Create(customer1);
                var listCustomer = cusRepo.GetAll().Select(p => new { p.CusId, p.CusName, p.Phone }).OrderByDescending(p => p.CusId).ToList();
                dtgvAddCustomer.DataSource = listCustomer;
                obj.loadCustomer();
                dtgvAddCustomer.Update();
                MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK);
                dtgvAddCustomer.Refresh();
                ResetFormCus();
            }
        }

        private void fAddCustomer_Load(object sender, EventArgs e)
        {
            loadCustomer();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            else
            {
                this.Close();
            }
        }
        #endregion     
    }
}
