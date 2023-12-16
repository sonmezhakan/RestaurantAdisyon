using RA.Business.Constants;
using RA.Business.ManagerService.Abstracts;
using RA.Business.ManagerService.Concretes;
using RA.DataAccess.Repositories.Concretes;
using RA.Entities.Entity;
using RA.WinFormUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RA.WinFormUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        AppUserManager appUserManager = new AppUserManager(new AppUserRepository());

        private void checkBeniHatirla_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBeniHatirla.Checked && !string.IsNullOrEmpty(txtUserName.Text))
            {
                UserNameSave(txtUserName.Text);
            }
            else
            {
                UserNameSave("");
            }

        }

        private void UserNameSave(string userName)
        {
            Settings.Default.UserName = userName;
            Settings.Default.Save();
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                if (appUserManager.GetByUserName(txtUserName.Text) != null)
                {
                    if (appUserManager.GetByLogin(txtUserName.Text, txtPassword.Text) == true)
                    {
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        MainForm.userId = appUserManager.GetByUserNameReturnId(txtUserName.Text);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(Messages.LoginError);
                    }
                }
                else
                {
                    MessageBox.Show(Messages.LoginError);
                }

            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Settings.Default.UserName))
            {
                txtUserName.Text = Settings.Default.UserName;
                checkBeniHatirla.Checked = true;
            }
        }
    }
}
