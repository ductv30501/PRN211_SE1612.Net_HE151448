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

namespace Assignemtn2_SaleManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            FStoreContext context = new FStoreContext();

            LoadDataForDGV();
        }

        private void LoadDataForDGV()
        {
            using (FStoreContext context = new FStoreContext())
            {
                var members = context.Members;
                var orders = context.Orders;
                var details = context.OrderDetails;
                var products = context.Products;

                var recordJoin = (from m in members
                                  join o in orders on m.MemberId equals o.MemberId
                                  select new 
                                  {
                                      memberID = m.MemberId,
                                      password = m.Password,
                                      memberName = m.Email,
                                      Company = m.CompanyName,
                                      City = m.City,
                                      Country = m.Country,
                                      o.OrderDate,
                                      o.RequiredDate,
                                      o.ShippedDate,
                                      o.Freight

                                  }).ToList();
                //dataGridView1.DataSource = recordJoin;

                var memberRecord = (from m in members
                                    select new
                                    {
                                        memberID = m.MemberId,
                                        password = m.Password,
                                        Email = m.Email,
                                        CompanyName = m.Email,
                                        City = m.City,
                                        Country = m.Country
                                    }).ToList();
                dataGridView1.DataSource = memberRecord;
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) 
            {
                return;
            }
            int Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            using(FStoreContext context = new FStoreContext())
            {
                List<OrderDetail> list = context.OrderDetails.Where(x => x.OrderId == Id).ToList();
                context.OrderDetails.RemoveRange(list);
                Order order = context.Orders.First(x => x.OrderId == Id);
                context.Orders.Remove(order);
                context.SaveChanges();
                LoadDataForDGV();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("No data");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure to delete this member?", "Confirm", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                //get member ID
                int memberID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                using (FStoreContext context = new FStoreContext())
                {
                    Member m = context.Members.First(x => x.MemberId == memberID);
                    List<Order> orders = context.Orders.Where(x => x.MemberId == memberID).ToList();
                    foreach (Order order in orders)
                    {
                        int orderID = order.OrderId;
                        List<OrderDetail> details = context.OrderDetails.Where(x => x.OrderId == orderID).ToList();
                        context.OrderDetails.RemoveRange(details);
                    }
                    context.Orders.RemoveRange(orders);

                    context.Members.Remove(m);
                    context.SaveChanges();
                    LoadDataForDGV();
                }
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCompany.Text = string.Empty;
            txtCountry.Text = string.Empty;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to insert a new member?", "Confirm", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Member m = new Member();

                m.MemberId = Convert.ToInt32(txtID.Text);
                m.Email = txtEmail.Text;
                m.CompanyName = txtCompany.Text;
                m.Password = txtPassword.Text;
                m.City = txtCity.Text;
                m.Country = txtCountry.Text;

                using (FStoreContext context = new FStoreContext())
                {
                    context.Members.Add(m);
                    context.SaveChanges();
                    
                }
                LoadDataForDGV();
            }
            

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            

            DialogResult result = MessageBox.Show("Are you sure to update this member?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if(dataGridView1.CurrentRow.Index != -1)
                {
                    int memberID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    using(FStoreContext context = new FStoreContext())
                    {
                        Member m = context.Members.First(x => x.MemberId == memberID);
                        //m.MemberId = Convert.ToInt32(txtID.Text);
                        m.Password = txtPassword.Text;
                        m.Email = txtEmail.Text;
                        m.CompanyName = txtCompany.Text;
                        m.City = txtCity.Text;
                        m.Country = txtCountry.Text;
                        context.SaveChanges();
                        
                    }
                    LoadDataForDGV();
                }
                


            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            txtID.Text = row.Cells[0].Value.ToString();
            txtPassword.Text = row.Cells[1].Value.ToString();
            txtEmail.Text = row.Cells[2].Value.ToString();
            txtCompany.Text = row.Cells[3].Value.ToString();
            txtCity.Text = row.Cells[4].Value.ToString();
            txtCountry.Text = row.Cells[5].Value.ToString();
        }
    }
}
