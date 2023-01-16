using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class fService : Form
    {
        private User _user = null;
        public fService()
        {
            InitializeComponent();
            if (!_user.Role.Trim().Equals("Admin"))
            {
                quảnLíToolStripMenuItem.Enabled = false;
            }
            loadCustomer();
            loadCategory();
            loadMainEmp();
            loadSubEmp();
            btnAddService.Enabled = false;
            btnCheckOut.Enabled = false;
            btnDeleteService.Enabled = false;
        }

        public fService(User user)
        {

            InitializeComponent();
            this._user = user;
            if (!_user.Role.Trim().Equals("Admin"))
            {
                quảnLíToolStripMenuItem.Enabled = false;
            }
            loadCustomer();
            loadCategory();
            loadMainEmp();
            loadSubEmp();
            btnAddService.Enabled = false;
            btnCheckOut.Enabled = false;
            btnDeleteService.Enabled = false;
        }

        #region methods Service
        public void loadCustomer()
        {
            var repo = new RepositoryBase<Customer>();
            var listCustomer = repo.GetAll().Select(p => new { p.CusId, p.CusName, p.Phone, Value = (bool)p.Status ? "Đang sử dụng dịch vụ" : "Chưa sử dụng dịch vụ" }).OrderByDescending(p => p.CusId).ToList();
            dtgvCustomer.DataSource = listCustomer;
            dtgvCustomer.Columns[0].HeaderText = "ID";
            dtgvCustomer.Columns[1].HeaderText = "Họ Và Tên";
            dtgvCustomer.Columns[2].HeaderText = "Số Điện Thoại";
            dtgvCustomer.Columns[3].HeaderText = "Trạng Thái";
            dtgvCustomer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvCustomer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvCustomer.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvCustomer.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        void loadCategory()
        {
            var repo = new RepositoryBase<Category>();
            var list = repo.GetAll().Select(p => p).ToList();
            cbCategory.DataSource = list;
            cbCategory.DisplayMember = "cateName";
        }
        void loadMainEmp()
        {
            var repo = new RepositoryBase<User>();
            var list = repo.GetAll().Select(p => p).ToList();
            cbMainEmp.DataSource = list;
            cbMainEmp.DisplayMember = "userName";
            cbMainEmp.ValueMember = "userName";
        }

        void loadSubEmp()
        {
            var repo = new RepositoryBase<User>();
            var list = repo.GetAll().Select(p => p).ToList();
            cbSubEmp.DataSource = list;
            cbSubEmp.ValueMember = "userName";
            cbSubEmp.DisplayMember = "userName";
        }

        void loadServiceListByCategoryID(int cateID)
        {
            var repo = new RepositoryBase<Service>();
            var list = repo.GetAll().Where(p => p.CateId == cateID).ToList();
            cbService.DataSource = list;
            cbService.DisplayMember = "serName";
        }

        int getOrderIDByCustomerID(int id)
        {
            var repo2 = new RepositoryBase<Order>();
            var text = repo2.GetAll().Where(p => p.CusId == id && Convert.ToInt32(p.Status) == 0).ToList();
            if (text.Count > 0)
            {
                return text.First().OrId;
            }
            return -1;
        }

        int getMaxIdOrder()
        {
            var repo2 = new RepositoryBase<Order>();
            var text = repo2.GetAll().Select(p => p).ToList();
            int orID = 0;
            foreach (var item in text)
            {
                orID = item.OrId;
            }
            return orID;
        }
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            var repo2 = new RepositoryBase<OrderDetail>();
            var text = repo2.GetAll2().Include(p => p.Or).Include(p => p.Ser).Where(p => p.Or.CusId == id).ToList();
            double totalPrice = 0;
            foreach (var item in text)
            {
                ListViewItem lsvItem = new ListViewItem(item.Ser.SerName.ToString());
                lsvItem.SubItems.Add(item.Ser.Price.ToString());
                lsvItem.SubItems.Add(item.Quantity.ToString());
                lsvItem.SubItems.Add(item.Discount.ToString());
                lsvItem.SubItems.Add(((item.Quantity * item.Ser.Price) / 100 * (100 - item.Discount)).ToString());
                lsvItem.SubItems.Add(item.OrDeId.ToString());
                totalPrice += (item.Quantity * item.Ser.Price) / 100 * (100 - item.Discount);
                lsvBill.Items.Add(lsvItem);
                lsvItem.SubItems[1].Text = String.Format("{0:0,0}", item.Ser.Price);
                lsvItem.SubItems[4].Text = String.Format("{0:0,0}", ((item.Quantity * item.Ser.Price) / 100 * (100 - item.Discount)));
            }
            txbTotalPrice.Text = String.Format("{0:0,0 vnđ}", totalPrice);
        }
        #endregion

        #region events Service
        public static int cusID;
        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAddCustomer f = new fAddCustomer(_user);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMyAccount f = new fMyAccount(_user);
            this.Hide();
            f.ShowDialog();
            var repo = new RepositoryBase<User>();
            var newUser = repo.GetAll().Where(p => p.UserName.Equals(_user.UserName)).FirstOrDefault();
            this._user = newUser;
            this.Show();
        }
        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void quảnLíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.CateId;
            loadServiceListByCategoryID(id);
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            var CustomerRepo = new RepositoryBase<Customer>();
            var listCustomer = CustomerRepo.GetAll().Select(p => new { p.CusId, p.CusName, p.Phone, Value = (bool)p.Status ? "Đang sử dụng dịch vụ" : "Chưa sử dụng dịch vụ" }).Where(e => e.CusName.Contains(txbSearchCustomer.Text)).OrderByDescending(p => p.CusId).ToList();
            dtgvCustomer.DataSource = listCustomer;
            dtgvCustomer.Columns[0].HeaderText = "ID";
            dtgvCustomer.Columns[1].HeaderText = "Họ Và Tên";
            dtgvCustomer.Columns[2].HeaderText = "Số Điện Thoại";
            dtgvCustomer.Columns[3].HeaderText = "Trạng Thái";
            dtgvCustomer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvCustomer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvCustomer.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvCustomer.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txbSearchCustomer.Text = "";
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            var repo1 = new RepositoryBase<Order>();
            var repo2 = new RepositoryBase<OrderDetail>();
            var repo3 = new RepositoryBase<Customer>();
            int orderId = getOrderIDByCustomerID(cusID);
            var customer = repo3.GetAll().Where(p => p.CusId == cusID).FirstOrDefault();
            int serID = (cbService.SelectedItem as Service).SerId;
            int quantity = (int)nmQuantity.Value;
            int discount = (int)nmDiscount.Value;
            var mainEmp = cbMainEmp.SelectedValue.ToString();
            var subEmp = cbSubEmp.SelectedValue.ToString();
            DateTime date = DateTime.Now;
            if (orderId == -1)
            {
                if (quantity > 0)
                {
                    Order order = new Order();
                    order.UserName = _user.UserName.ToString();
                    order.CusId = cusID;
                    order.DateCheckIn = date;
                    order.MainEmp = mainEmp;
                    order.SubEmp = subEmp;
                    repo1.Create(order);
                    if (customer != null)
                    {
                        OrderDetail orderDetail = new OrderDetail();
                        orderDetail.OrId = getMaxIdOrder();
                        orderDetail.SerId = serID;
                        orderDetail.Quantity = quantity;
                        orderDetail.Discount = discount;
                        repo2.Create(orderDetail);
                        customer.Status = Convert.ToBoolean("True");
                        repo3.Update(customer);
                    }
                }
                else
                {

                }
            }
            else
            {
                var text = repo2.GetAll().Where(p => p.OrId == orderId && p.SerId == serID).FirstOrDefault();
                if (text != null)
                {
                    OrderDetail orderDetail2 = new OrderDetail();

                    if (quantity + text.Quantity > 0)
                    {
                        text.Quantity = quantity + text.Quantity;
                        repo2.Update(text);
                    }
                    else
                    {
                        var text3 = repo2.GetAll().Where(p => p.OrId == orderId && p.SerId == serID).FirstOrDefault();
                        repo2.Delete(text3);
                    }
                }
                else
                {
                    if (customer != null)
                    {
                        OrderDetail orderDetail3 = new OrderDetail();
                        orderDetail3.OrId = getMaxIdOrder();
                        orderDetail3.SerId = serID;
                        orderDetail3.Quantity = quantity;
                        orderDetail3.Discount = discount;
                        repo2.Create(orderDetail3);
                    }
                }
            }
            btnCheckOut.Enabled = true;
            ShowBill(cusID);
            loadCustomer();
        }

        private void dtgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var rowSelected = this.dtgvCustomer.Rows[e.RowIndex];
                cusID = (int)rowSelected.Cells["cusID"].Value;
                txbShowCustomer.Text = rowSelected.Cells["cusName"].Value.ToString();
                var repo3 = new RepositoryBase<Customer>();
                var customer = repo3.GetAll().Where(p => p.CusId == cusID).FirstOrDefault();
                if(customer.Status == Convert.ToBoolean("True"))
                {
                    btnCheckOut.Enabled = true;
                }
                else
                {
                    btnCheckOut.Enabled = false;
                }
                btnAddService.Enabled = true;
                ShowBill(cusID);
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var repo1 = new RepositoryBase<Order>();
            var repo2 = new RepositoryBase<OrderDetail>();
            var repo3 = new RepositoryBase<Customer>();
            int orderId = getOrderIDByCustomerID(cusID);
            var customer = repo3.GetAll().Where(p => p.CusId == cusID).FirstOrDefault();
            DateTime date = DateTime.Now;
            var text = repo1.GetAll().Where(p => p.OrId == orderId).FirstOrDefault();
            if (text != null)
            {
                OrderDetail orderDetail2 = new OrderDetail();
                if (MessageBox.Show("Bạn có muốn thanh toán hóa đơn không ? ", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    text.Status = Convert.ToBoolean("True");
                    text.DateCheckOut = date;
                    var text2 = repo2.GetAll2().Include(p => p.Or).Include(p => p.Ser).Where(p => p.OrId == orderId).ToList();
                    double total = 0;
                    foreach (var item in text2)
                    {
                        total += (item.Quantity * item.Ser.Price) / 100 * (100 - item.Discount);

                    }
                    text.Total = Convert.ToInt32(total);
                    //text.Discount = discount;
                    repo1.Update(text);
                    customer.Status = Convert.ToBoolean("False");
                    repo3.Update(customer);
                }
                else
                {
                    return;
                }
            }
            var text3 = repo2.GetAll().Where(p => p.OrId == orderId).ToList();
            foreach (var item in text3)
            {
                repo2.Delete(item);

            }
            btnCheckOut.Enabled = false;
            ShowBill(cusID);
            loadCustomer();
        }
        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count >= 0)
            {
                for(int i = 0; i < lsvBill.SelectedItems.Count; i++)
                {
                    txbServiceToDelete.Text = lsvBill.SelectedItems[i].SubItems[0].Text;
                    txbDeleteOrderID.Text = lsvBill.SelectedItems[i].SubItems[5].Text;
                    btnDeleteService.Enabled = true;
                }
                

            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            var OrderDelete = txbDeleteOrderID.Text;
            var repo = new RepositoryBase<OrderDetail>();
            var text = repo.GetAll().Where(e => e.OrDeId.ToString().Equals(OrderDelete)).FirstOrDefault();
            if (text != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa dịch vụ này ra khỏi bill không? ", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    repo.Delete(text);
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK);
                    txbServiceToDelete.Text = "";
                    txbDeleteOrderID.Text = "";
                    btnDeleteService.Enabled = false;                   
                    ShowBill(cusID);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                    txbServiceToDelete.Text = "";
                    txbDeleteOrderID.Text = "";
                    btnDeleteService.Enabled = false;
                }
            }
        }

        #endregion

    }
}
