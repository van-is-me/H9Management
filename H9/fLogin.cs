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
    public partial class fLogin : Form
    {
        public static User _user = new User();
        public fLogin()
        {
            InitializeComponent();
        }

        #region methods Login
        void login()
        {
            string username = txbUserName.Text.Trim();
            string password = txbPassword.Text;

            if (username == "")
            {
                MessageBox.Show("Tên đăng nhập không thể để trống, Vui Lòng nhập tên đăng nhập", "Thông báo");
            }
            else if (password == "")
            {
                MessageBox.Show("Mật khẩu không thể để trống, Vui Lòng nhập mật khẩu", "Thông báo");
            }
            else
            {
                var repo = new RepositoryBase<User>();
                var user = repo.GetAll().Where(p => p.UserName == username && p.PassWord == password).FirstOrDefault();
                if (user != null)
                {
                    _user = user;

                    fService f = new fService(user);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu ", "Thông báo");
                }
            }
        }

        #endregion

        #region events Login
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }
        #endregion

    }
}
