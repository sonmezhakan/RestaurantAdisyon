using Microsoft.Extensions.DependencyInjection;
using RA.Business.Constants;
using RA.Business.ManagerService.Abstracts;
using RA.Business.ManagerService.Concretes;
using RA.DataAccess.Repositories.Concretes;
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
        private readonly IOrderService _orderService;
        private readonly IAppUserService _appUserService;
        private readonly ITableService _tableService;
        private readonly IServiceProvider _serviceProvider;

        public OrderForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _tableService = serviceProvider.GetRequiredService<ITableService>();
            _orderService = serviceProvider.GetRequiredService<IOrderService>();
            _appUserService = serviceProvider.GetRequiredService<IAppUserService>();
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            DgwSettings();
            OrderList();
        }
        private void OrderList()
        {
            var getOrder = _orderService.GetAll();
            if (getOrder != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                foreach (var item in getOrder)
                {
                    dataGridView1.Rows.Add(item.ID, _tableService.GetById((int)item.TableId).TableName, item.OrderDate, item.IsActive, item.CreatedDate, item.UpdatedDate, _appUserService.GetById(item.CreatedUserId).UserName);
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
            OrderDetailForm orderDetailForm = new OrderDetailForm(_serviceProvider);
            OrderDetailForm.orderID = (int)dataGridView1.SelectedCells[0].Value;
            orderDetailForm.Show();
        }
    }
}
