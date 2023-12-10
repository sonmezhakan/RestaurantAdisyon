using RA.Business.Concrete;
using RA.Business.Constants;
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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        OrderManager orderManager = new OrderManager();
        AppUserManager userManager = new AppUserManager();
        TableManager tableManager = new TableManager();
        private void OrderForm_Load(object sender, EventArgs e)
        {
            DgwSettings();
            OrderList();
        }
        private void OrderList()
        {
            var getOrder = orderManager.GetAll();
            if (getOrder != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                foreach (var item in getOrder)
                {
                    dataGridView1.Rows.Add(item.ID, tableManager.GetById((int)item.TableId).TableName, item.OrderDate, item.IsActive, item.CreatedDate, item.UpdatedDate, userManager.GetById(item.CreatedUserId).UserName);
                }
            }
        }
        private void DgwSettings()
        {
            dataGridView1.ColumnCount = 7;

            dataGridView1.Columns[0].HeaderText = ColumnHeaders.ID;
            dataGridView1.Columns[1].HeaderText = ColumnHeaders.TableName;
            dataGridView1.Columns[2].HeaderText = ColumnHeaders.OrderDate;
            dataGridView1.Columns[3].HeaderText = ColumnHeaders.IsActive;
            dataGridView1.Columns[4].HeaderText = ColumnHeaders.CreatedDate;
            dataGridView1.Columns[5].HeaderText = ColumnHeaders.UpdatedDate;
            dataGridView1.Columns[6].HeaderText = ColumnHeaders.UserName;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            OrderDetailForm orderDetailForm = new OrderDetailForm();
            OrderDetailForm.orderID = (int)dataGridView1.SelectedCells[0].Value;
            orderDetailForm.Show();
        }
    }
}
