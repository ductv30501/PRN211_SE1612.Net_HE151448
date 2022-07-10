
namespace Assignemtn2_SaleManagement.View
{
    partial class frmDetails
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
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbProduc = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.cboOrderID = new System.Windows.Forms.ComboBox();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.maskUnitPrice = new System.Windows.Forms.MaskedTextBox();
            this.maskQuantity = new System.Windows.Forms.MaskedTextBox();
            this.maskDiscount = new System.Windows.Forms.MaskedTextBox();
            this.bntInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.detailsGridView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(63, 62);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(66, 20);
            this.lbOrderID.TabIndex = 0;
            this.lbOrderID.Text = "Order ID";
            // 
            // lbProduc
            // 
            this.lbProduc.AutoSize = true;
            this.lbProduc.Location = new System.Drawing.Point(63, 102);
            this.lbProduc.Name = "lbProduc";
            this.lbProduc.Size = new System.Drawing.Size(60, 20);
            this.lbProduc.TabIndex = 1;
            this.lbProduc.Text = "Product";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(626, 62);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(72, 20);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Unit Price";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(626, 116);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(65, 20);
            this.lbQuantity.TabIndex = 3;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(626, 164);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(67, 20);
            this.lbDiscount.TabIndex = 4;
            this.lbDiscount.Text = "Discount";
            // 
            // cboOrderID
            // 
            this.cboOrderID.FormattingEnabled = true;
            this.cboOrderID.Location = new System.Drawing.Point(141, 59);
            this.cboOrderID.Name = "cboOrderID";
            this.cboOrderID.Size = new System.Drawing.Size(320, 28);
            this.cboOrderID.TabIndex = 5;
            // 
            // cboProduct
            // 
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(141, 102);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(320, 28);
            this.cboProduct.TabIndex = 6;
            // 
            // maskUnitPrice
            // 
            this.maskUnitPrice.Location = new System.Drawing.Point(721, 55);
            this.maskUnitPrice.Mask = "0000.00";
            this.maskUnitPrice.Name = "maskUnitPrice";
            this.maskUnitPrice.Size = new System.Drawing.Size(339, 27);
            this.maskUnitPrice.TabIndex = 7;
            this.maskUnitPrice.ValidatingType = typeof(int);
            // 
            // maskQuantity
            // 
            this.maskQuantity.Location = new System.Drawing.Point(721, 109);
            this.maskQuantity.Mask = "00";
            this.maskQuantity.Name = "maskQuantity";
            this.maskQuantity.Size = new System.Drawing.Size(339, 27);
            this.maskQuantity.TabIndex = 8;
            this.maskQuantity.ValidatingType = typeof(int);
            // 
            // maskDiscount
            // 
            this.maskDiscount.Location = new System.Drawing.Point(721, 157);
            this.maskDiscount.Mask = "00.00";
            this.maskDiscount.Name = "maskDiscount";
            this.maskDiscount.Size = new System.Drawing.Size(339, 27);
            this.maskDiscount.TabIndex = 9;
            // 
            // bntInsert
            // 
            this.bntInsert.Location = new System.Drawing.Point(141, 155);
            this.bntInsert.Name = "bntInsert";
            this.bntInsert.Size = new System.Drawing.Size(94, 29);
            this.bntInsert.TabIndex = 10;
            this.bntInsert.Text = "Add Detail";
            this.bntInsert.UseVisualStyleBackColor = true;
            this.bntInsert.Click += new System.EventHandler(this.bntInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(255, 156);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit Detail";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(367, 155);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 29);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // detailsGridView
            // 
            this.detailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsGridView.Location = new System.Drawing.Point(63, 252);
            this.detailsGridView.MultiSelect = false;
            this.detailsGridView.Name = "detailsGridView";
            this.detailsGridView.RowHeadersWidth = 51;
            this.detailsGridView.RowTemplate.Height = 29;
            this.detailsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detailsGridView.Size = new System.Drawing.Size(997, 347);
            this.detailsGridView.TabIndex = 13;
            this.detailsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detailsGridView_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(63, 217);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 611);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.detailsGridView);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.bntInsert);
            this.Controls.Add(this.maskDiscount);
            this.Controls.Add(this.maskQuantity);
            this.Controls.Add(this.maskUnitPrice);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.cboOrderID);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbProduc);
            this.Controls.Add(this.lbOrderID);
            this.Name = "frmDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetails";
            this.Load += new System.EventHandler(this.frmDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detailsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbProduc;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.ComboBox cboOrderID;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.MaskedTextBox maskUnitPrice;
        private System.Windows.Forms.MaskedTextBox maskQuantity;
        private System.Windows.Forms.MaskedTextBox maskDiscount;
        private System.Windows.Forms.Button bntInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView detailsGridView;
        private System.Windows.Forms.Button btnDelete;
    }
}