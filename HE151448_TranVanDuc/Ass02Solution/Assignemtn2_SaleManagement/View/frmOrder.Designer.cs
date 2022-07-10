
namespace Assignemtn2_SaleManagement.View
{
    partial class frmOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.timeOrder = new System.Windows.Forms.DateTimePicker();
            this.lbRequireDate = new System.Windows.Forms.Label();
            this.lbShipdate = new System.Windows.Forms.Label();
            this.lbFreight = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.cbMember = new System.Windows.Forms.ComboBox();
            this.timeRequire = new System.Windows.Forms.DateTimePicker();
            this.timeShip = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnInsertOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.masktxtFreight = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderGridView
            // 
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(69, 239);
            this.orderGridView.MultiSelect = false;
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.RowHeadersWidth = 51;
            this.orderGridView.RowTemplate.Height = 29;
            this.orderGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderGridView.Size = new System.Drawing.Size(911, 342);
            this.orderGridView.TabIndex = 0;
            this.orderGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderGridView_CellClick);
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(69, 49);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(66, 20);
            this.lbOrderID.TabIndex = 2;
            this.lbOrderID.Text = "Order ID";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(562, 49);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(83, 20);
            this.lbOrderDate.TabIndex = 3;
            this.lbOrderDate.Text = "Order Date";
            // 
            // timeOrder
            // 
            this.timeOrder.Location = new System.Drawing.Point(673, 44);
            this.timeOrder.Name = "timeOrder";
            this.timeOrder.Size = new System.Drawing.Size(307, 27);
            this.timeOrder.TabIndex = 4;
            // 
            // lbRequireDate
            // 
            this.lbRequireDate.AutoSize = true;
            this.lbRequireDate.Location = new System.Drawing.Point(562, 88);
            this.lbRequireDate.Name = "lbRequireDate";
            this.lbRequireDate.Size = new System.Drawing.Size(96, 20);
            this.lbRequireDate.TabIndex = 5;
            this.lbRequireDate.Text = "Require Date";
            // 
            // lbShipdate
            // 
            this.lbShipdate.AutoSize = true;
            this.lbShipdate.Location = new System.Drawing.Point(562, 138);
            this.lbShipdate.Name = "lbShipdate";
            this.lbShipdate.Size = new System.Drawing.Size(74, 20);
            this.lbShipdate.TabIndex = 6;
            this.lbShipdate.Text = "Ship Date";
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(69, 88);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(55, 20);
            this.lbFreight.TabIndex = 7;
            this.lbFreight.Text = "Freight";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(69, 138);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(65, 20);
            this.lbMemberID.TabIndex = 8;
            this.lbMemberID.Text = "Member";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(141, 42);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(329, 27);
            this.txtOrderID.TabIndex = 9;
            // 
            // cbMember
            // 
            this.cbMember.FormattingEnabled = true;
            this.cbMember.Location = new System.Drawing.Point(140, 130);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(330, 28);
            this.cbMember.TabIndex = 11;
            // 
            // timeRequire
            // 
            this.timeRequire.Location = new System.Drawing.Point(673, 83);
            this.timeRequire.Name = "timeRequire";
            this.timeRequire.Size = new System.Drawing.Size(307, 27);
            this.timeRequire.TabIndex = 12;
            // 
            // timeShip
            // 
            this.timeShip.Location = new System.Drawing.Point(673, 128);
            this.timeShip.Name = "timeShip";
            this.timeShip.Size = new System.Drawing.Size(307, 27);
            this.timeShip.TabIndex = 13;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(69, 204);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(119, 29);
            this.btnDeleteOrder.TabIndex = 14;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnInsertOrder
            // 
            this.btnInsertOrder.Location = new System.Drawing.Point(562, 204);
            this.btnInsertOrder.Name = "btnInsertOrder";
            this.btnInsertOrder.Size = new System.Drawing.Size(108, 29);
            this.btnInsertOrder.TabIndex = 15;
            this.btnInsertOrder.Text = "Insert Order";
            this.btnInsertOrder.UseVisualStyleBackColor = true;
            this.btnInsertOrder.Click += new System.EventHandler(this.btnInsertOrder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(722, 204);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(108, 29);
            this.btnUpdateOrder.TabIndex = 16;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(876, 204);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(104, 29);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // masktxtFreight
            // 
            this.masktxtFreight.ForeColor = System.Drawing.Color.Black;
            this.masktxtFreight.Location = new System.Drawing.Point(141, 85);
            this.masktxtFreight.Mask = "00000000";
            this.masktxtFreight.Name = "masktxtFreight";
            this.masktxtFreight.Size = new System.Drawing.Size(329, 27);
            this.masktxtFreight.TabIndex = 18;
            this.masktxtFreight.ValidatingType = typeof(int);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 591);
            this.Controls.Add(this.masktxtFreight);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnInsertOrder);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.timeShip);
            this.Controls.Add(this.timeRequire);
            this.Controls.Add(this.cbMember);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.lbShipdate);
            this.Controls.Add(this.lbRequireDate);
            this.Controls.Add(this.timeOrder);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.orderGridView);
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.DateTimePicker timeOrder;
        private System.Windows.Forms.Label lbRequireDate;
        private System.Windows.Forms.Label lbShipdate;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.ComboBox cbMember;
        private System.Windows.Forms.DateTimePicker timeRequire;
        private System.Windows.Forms.DateTimePicker timeShip;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnInsertOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.MaskedTextBox masktxtFreight;
    }
}