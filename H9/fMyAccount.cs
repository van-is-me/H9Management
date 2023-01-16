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
    public partial class fMyAccount : Form
    {
        private User _user = null;
        public fMyAccount()
        {
            InitializeComponent();
        }

        public fMyAccount(User user)
        {
            InitializeComponent();
            this._user = user;
            txbUserName.Text = _user.UserName.ToString();
        }

        #region methods MyAccount
        private bool CheckNull()
        {
            if (txbPassword.Text == "" || txbRePassword.Text == "" || txbNewPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tất cả các thông tin", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }
        
        void UpdateUser()
        {
            if (!CheckNull())
            {
                return;
            }
            var username = txbUserName.Text;
            var password = txbPassword.Text;
            var newpassword = txbNewPassword.Text;
            var repassword = txbRePassword.Text;

            if (!password.Equals(_user.PassWord))
            {
                MessageBox.Show("Mật khẩu không đúng. Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (!newpassword.Equals(repassword))
            {

                MessageBox.Show("Mật khẩu mới không trùng khớp với nhập lại mật khẩu. Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            var repo = new RepositoryBase<User>();
            User updateUser = new User();
            updateUser.UserName = username;
            updateUser.Role = _user.Role;
            updateUser.PassWord = newpassword;
            repo.Update(updateUser);
            this._user = updateUser;
            txbUserName.Text = _user.UserName.ToString();
            txbPassword.Text = "";
            txbNewPassword.Text = "";
            txbRePassword.Text = "";
            MessageBox.Show("Bạn đã thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
        }
        #endregion

        #region events MyAccount
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateUser();
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
