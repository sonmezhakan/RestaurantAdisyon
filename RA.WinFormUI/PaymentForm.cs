using Microsoft.Extensions.DependencyInjection;
using RA.Business.ManagerService.Abstracts;
using RA.Business.ManagerService.Concretes;
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
    public partial class PaymentForm : Form
    {
        private readonly IOrderService _orderService;

        public PaymentForm(IServiceProvider serviceProvider)
        {
            _orderService = serviceProvider.GetRequiredService<IOrderService>();
            InitializeComponent();
        }

        public static decimal totalPrice = 0;

        public static Order getOrder = null;


        private void PaymentForm_Load(object sender, EventArgs e)
        {
            lblTotalPrice.Text = totalPrice.ToString();
        }

        private void bttnOne_Click(object sender, EventArgs e)
        {
            TutarClear();
            lblPrice.Text += "1";

        }

        private void TutarClear()
        {
            if (lblPrice.Text == "0" || lblPrice.Text == "0,00")
            {
                lblPrice.Text = "";
            }
        }

        private void bttnTwo_Click(object sender, EventArgs e)
        {
            TutarClear();
            lblPrice.Text += "2";
        }

        private void bttnThree_Click(object sender, EventArgs e)
        {
            TutarClear();
            lblPrice.Text += "3";
        }

        private void bttnFour_Click(object sender, EventArgs e)
        {
            TutarClear();
            lblPrice.Text += "4";
        }

        private void bttnFive_Click(object sender, EventArgs e)
        {
            TutarClear();
            lblPrice.Text += "5";
        }

        private void bttnSix_Click(object sender, EventArgs e)
        {
            TutarClear();
            lblPrice.Text += "6";
        }

        private void bttnSeven_Click(object sender, EventArgs e)
        {
            TutarClear();
            lblPrice.Text += "7";
        }

        private void bttnEight_Click(object sender, EventArgs e)
        {
            TutarClear();
            lblPrice.Text += "8";
        }

        private void bttnNine_Click(object sender, EventArgs e)
        {
            TutarClear();
            lblPrice.Text += "9";
        }

        private void bttnZero_Click(object sender, EventArgs e)
        {
            TutarClear();
            lblPrice.Text += "0";
        }

        private void bttnVirgul_Click(object sender, EventArgs e)
        {
            TutarClear();
            lblPrice.Text += ",";
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            lblPrice.Text = "0,00";
        }

        private void bttnChampaing_Click(object sender, EventArgs e)
        {
            lblTotalPrice.Text = (decimal.Parse(lblTotalPrice.Text) - decimal.Parse(lblPrice.Text)).ToString();
        }

        private void bttnPayment_Click(object sender, EventArgs e)
        {
            lblTotalPrice.Text = (decimal.Parse(lblTotalPrice.Text) - decimal.Parse(lblPrice.Text)).ToString();
            lblPrice.Text = "0,00";
            if (decimal.Parse(lblTotalPrice.Text) <= 0)
            {
                OrderUpdate(getOrder);
            }
        }

        private void OrderUpdate(Order order)
        {
            order.IsActive = false;
            order.UpdatedDate = DateTime.Now;
            _orderService.Update(order);
        }

        private void bttnPlenty_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblPrice.Text) > 0)
            {
                lblPrice.Text = (decimal.Parse(lblTotalPrice.Text) / decimal.Parse(lblPrice.Text)).ToString(); 
            }
                
        }
    }
}
