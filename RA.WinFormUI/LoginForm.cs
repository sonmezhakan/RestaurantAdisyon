using Microsoft.Extensions.DependencyInjection;
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
        private readonly IAppUserService _appUserService;
        private readonly IServiceProvider _serviceProvider;

        public LoginForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _appUserService = serviceProvider.GetRequiredService<IAppUserService>();
            InitializeComponent();
        }

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
                if (_appUserService.GetByUserName(txtUserName.Text) != null)
                {
                    if (_appUserService.GetByLogin(txtUserName.Text, txtPassword.Text) == true)
                    {
                        MainForm mainForm = new MainForm(_serviceProvider);
                        mainForm.Show();
                        MainForm.userId = _appUserService.GetByUserNameReturnId(txtUserName.Text);
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
