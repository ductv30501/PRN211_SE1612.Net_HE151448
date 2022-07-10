using Assignemtn2_SaleManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignemtn2_SaleManagement.View
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            FStoreContext context = new FStoreContext();
            cbMember.DisplayMember = "Email";
            cbMember.ValueMember = "MemberId";
            cbMember.DataSource = context.Members.ToList();
            LoadDataForDGV();
        }
        //load data for
        private void LoadDataForDGV()
        {
            using(FStoreContext context = new FStoreContext())
            {
                var members = context.Members;
                var orders = context.Orders;

                var records = (from o in orders
                               join m in members on o.MemberId equals m.MemberId
                               select new
                               {
                                   OrderID = o.OrderId,
                                   OrderDate = o.OrderDate,
                                   RequireDate = o.RequiredDate,
                                   ShipDate = o.ShippedDate,
                                   Freight = o.Freight,
                                   MemberID = m.MemberId,
                                   MemberEmail = m.Email
                               }).ToList();
                orderGridView.DataSource = records;
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure delete this order?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int OrderID = Convert.ToInt32(orderGridView.SelectedRows[0].Cells[0].Value);
                using(FStoreContext context = new FStoreContext())
                {
                    Order o = context.Orders.First(x => x.OrderId == OrderID);
                    List<OrderDetail> details = context.OrderDetails.Where(x => x.OrderId == OrderID).ToList();
                    context.OrderDetails.RemoveRange(details);
                    context.Orders.Remove(o);
                    context.SaveChanges();
                    LoadDataForDGV();
                }
            }
            
        }

        private void btnInsertOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure insert a new order?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Order o = new Order();
                o.OrderId = Convert.ToInt32(txtOrderID.Text);
                o.MemberId = Convert.ToInt32(cbMember.SelectedValue);
                //MessageBox.Show(cbMember.ValueMember);
                o.OrderDate = timeOrder.Value;
                o.RequiredDate = timeRequire.Value;
                o.ShippedDate = timeShip.Value;
                o.Freight = Convert.ToInt32(masktxtFreight.Text);

                using(FStoreContext context = new FStoreContext())
                {
                    context.Orders.Add(o);
                    context.SaveChanges();
                    
                }
                LoadDataForDGV();
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to update this Order?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (orderGridView.CurrentRow.Index != -1)
                {
                    int orderID = Convert.ToInt32(orderGridView.CurrentRow.Cells[0].Value);
                    using (FStoreContext context = new FStoreContext())
                    {
                        Order o = context.Orders.First(x => x.OrderId == orderID);
                        o.OrderId = Convert.ToInt32(txtOrderID.Text);
                        o.MemberId = Convert.ToInt32(cbMember.SelectedValue);
                        //MessageBox.Show(cbMember.ValueMember);
                        o.OrderDate = timeOrder.Value;
                        o.RequiredDate = timeRequire.Value;
                        o.ShippedDate = timeShip.Value;
                        o.Freight = Convert.ToInt32(masktxtFreight.Text);
                        context.SaveChanges();
                    }
                    LoadDataForDGV();
                }



            }
        }

        private void orderGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = orderGridView.SelectedRows[0];
            txtOrderID.Text = row.Cells[0].Value.ToString();
            timeOrder.Value = Convert.ToDateTime(row.Cells[1].Value.ToString());
            timeRequire.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
            timeShip.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
            masktxtFreight.Text = row.Cells[4].Value.ToString();
            cbMember.SelectedValue = Convert.ToInt32(row.Cells[5].Value.ToString());



        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtOrderID.Text = string.Empty;
            timeOrder.CustomFormat = " ";
            timeOrder.Format = DateTimePickerFormat.Custom;

            timeRequire.CustomFormat = " ";
            timeRequire.Format = DateTimePickerFormat.Custom;

            timeShip.CustomFormat = " ";
            timeShip.Format = DateTimePickerFormat.Custom;

            masktxtFreight.Text = string.Empty;
            cbMember.Text = string.Empty;
        }
    }
}
