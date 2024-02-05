using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;
using RA.Business.Constants;
using RA.Business.ManagerService.Abstracts;
using RA.Business.ManagerService.Concretes;
using RA.DataAccess.Concrete;
using RA.DataAccess.Repositories.Abstracts;
using RA.DataAccess.Repositories.Concretes;
using RA.Entities.Entity;
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
    public partial class AppUserForm : Form
    {
        private readonly IAppUserService _appUserService;
        private readonly IEmployeeService _employeeService;

        public AppUserForm(IServiceProvider serviceProvider)
        {
            _appUserService = serviceProvider.GetRequiredService<IAppUserService>();
            _employeeService = serviceProvider.GetRequiredService<IEmployeeService>();
            InitializeComponent();
        }

        private void AppUserForm_Load(object sender, EventArgs e)
        {
            ComboUserNameList();
            ComboFirstNameList();
            DgwSettings();
            AppUserList();
        }

        private void ComboUserNameList()
        {
            comboUserName.DisplayMember = ComboBoxMember.UserName;
            comboUserName.ValueMember = ComboBoxMember.ID;

            comboUserName.DataSource = _appUserService.GetAllComboBox();
        }
        private void ComboFirstNameList()
        {
            comboEmployeeFirstName.DisplayMember = ComboBoxMember.FirstName;
            comboEmployeeFirstName.ValueMember = ComboBoxMember.ID;

            comboEmployeeFirstName.DataSource = _employeeService.GetByAllComboBox();
        }

        private void comboEmployeeFirstName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var getEmployee = _employeeService.GetByFirstName(comboEmployeeFirstName.Text);
            if (getEmployee != null)
            {
                comboEmployeeLastName.DisplayMember = ComboBoxMember.LastName;
                comboEmployeeLastName.ValueMember = ComboBoxMember.ID;

                comboEmployeeLastName.DataSource = getEmployee;
            }
        }

        private void AppUserList()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            var getUserList = _appUserService.GetAll();
            if(getUserList != null )
            {
                foreach (var item in getUserList)
                {
                    dataGridView1.Rows.Add(item.ID, item.UserName, _employeeService.GetById(item.ID).FirstName, item.IsActive, item.CreatedDate, item.UpdatedDate);
                }
            }
            
        }

        private void DgwSettings()
        {
            dataGridView1.ColumnCount = 6;

            dataGridView1.Columns[0].HeaderText = ColumnHeaders.ID;
            dataGridView1.Columns[1].HeaderText = ColumnHeaders.UserName;
            dataGridView1.Columns[2].HeaderText = ColumnHeaders.FistName;
            dataGridView1.Columns[3].HeaderText = ColumnHeaders.IsActive;
            dataGridView1.Columns[4].HeaderText = ColumnHeaders.CreatedDate;
            dataGridView1.Columns[5].HeaderText = ColumnHeaders.UpdatedDate;
        }


        private void DgwClick()
        {
            comboUserName.SelectedValue = dataGridView1.SelectedCells[0].Value;
        }

        private void comboUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var getUser = _appUserService.GetById((int)comboUserName.SelectedValue);
            if (getUser != null)
            {
                lblID.Text = getUser.ID.ToString();
                txtUserName.Text = getUser.UserName;
                comboEmployeeFirstName.SelectedValue = getUser.ID;
                comboEmployeeLastName.SelectedValue = getUser.ID;
                checkStatu.Checked = (bool)getUser.IsActive;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DgwClick();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgwClick();
            bttnDelete_Click(sender, e);
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text) && comboEmployeeFirstName.SelectedValue != null &&
                comboEmployeeLastName.SelectedValue != null)
            {
                if(_appUserService.GetByUserName(txtUserName.Text) != null)
                {
                    if(comboEmployeeFirstName.SelectedValue.ToString() == comboEmployeeLastName.SelectedValue.ToString() && _appUserService.GetByEmployeeId((int)comboEmployeeFirstName.SelectedValue))
                    {
                        _appUserService.Add(new Entities.Entity.AppUser
                        {
                            UserName = txtUserName.Text,
                            Password = txtPassword.Text,
                            IsActive = checkStatu.Checked,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now
                        });
                        ComboUserNameList();
                        AppUserList();
                    }
                    else
                    {
                        MessageBox.Show(Messages.EmployeeIdError);
                    }    
                }
                else
                {
                    MessageBox.Show(Messages.UserNameError);
                }
            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            var getUser = _appUserService.GetById((int)comboUserName.SelectedValue);
            if(getUser != null)
            {
                if(!string.IsNullOrEmpty(txtPassword.Text))
                {
                    getUser.Password = txtPassword.Text;
                }
                else if(getUser.Password != txtPassword.Text && !string.IsNullOrEmpty(txtUserName.Text))
                {
                    getUser.Password = txtPassword.Text;
                }

                if(getUser.ID != (int)comboEmployeeLastName.SelectedValue)
                {
                    if(_appUserService.GetByEmployeeId((int)comboEmployeeLastName.SelectedValue) == false)
                    {
                        getUser.ID = (int)comboEmployeeLastName.SelectedValue;
                    }
                    else
                    {
                        MessageBox.Show(Messages.EmployeeIdError);
                    }
                }

                getUser.IsActive = checkStatu.Checked;
                getUser.UpdatedDate = DateTime.Now;
                _appUserService.Update(getUser);
                ComboUserNameList();
                AppUserList();
            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            var getUser = _appUserService.GetById((int)comboUserName.SelectedValue);
            if(getUser != null)
            {
                _appUserService.Delete(getUser.ID);
                ComboUserNameList();
                AppUserList();
            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }
    }
}
