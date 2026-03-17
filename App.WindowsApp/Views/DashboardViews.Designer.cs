namespace App.WindowsApp.Views
{
    partial class DashboardViews
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblDashboard = new TableLayoutPanel();
            flpKpi = new FlowLayoutPanel();
            pnlSales = new Panel();
            lblSalesV = new Label();
            lblSalesT = new Label();
            pnlOrders = new Panel();
            lblOrdersV = new Label();
            lblOrdersT = new Label();
            pnlRevenue = new Panel();
            lblRevenueV = new Label();
            lblRevenueT = new Label();
            pnlLowStock = new Panel();
            lvLowStock = new ListView();
            colProduct = new ColumnHeader();
            colStock = new ColumnHeader();
            lblLowStock = new Label();
            pnlRecentOrders = new Panel();
            lvRecentOrders = new ListView();
            colOrderId = new ColumnHeader();
            colCustomer = new ColumnHeader();
            colTotal = new ColumnHeader();
            colStatus = new ColumnHeader();
            lblRecentOrders = new Label();
            tblDashboard.SuspendLayout();
            flpKpi.SuspendLayout();
            pnlSales.SuspendLayout();
            pnlOrders.SuspendLayout();
            pnlRevenue.SuspendLayout();
            pnlLowStock.SuspendLayout();
            pnlRecentOrders.SuspendLayout();
            SuspendLayout();
            // 
            // tblDashboard
            // 
            tblDashboard.ColumnCount = 1;
            tblDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tblDashboard.Controls.Add(flpKpi, 0, 0);
            tblDashboard.Controls.Add(pnlLowStock, 0, 1);
            tblDashboard.Controls.Add(pnlRecentOrders, 0, 2);
            tblDashboard.Dock = DockStyle.Fill;
            tblDashboard.Location = new Point(0, 0);
            tblDashboard.Margin = new Padding(3, 4, 3, 4);
            tblDashboard.Name = "tblDashboard";
            tblDashboard.RowCount = 3;
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.Size = new Size(987, 1038);
            tblDashboard.TabIndex = 0;
            // 
            // flpKpi
            // 
            flpKpi.Controls.Add(pnlSales);
            flpKpi.Controls.Add(pnlOrders);
            flpKpi.Controls.Add(pnlRevenue);
            flpKpi.Dock = DockStyle.Fill;
            flpKpi.Location = new Point(3, 4);
            flpKpi.Margin = new Padding(3, 4, 3, 4);
            flpKpi.Name = "flpKpi";
            flpKpi.Size = new Size(981, 142);
            flpKpi.TabIndex = 0;
            // 
            // pnlSales
            // 
            pnlSales.Controls.Add(lblSalesV);
            pnlSales.Controls.Add(lblSalesT);
            pnlSales.Location = new Point(3, 4);
            pnlSales.Margin = new Padding(3, 4, 3, 4);
            pnlSales.Name = "pnlSales";
            pnlSales.Size = new Size(200, 125);
            pnlSales.TabIndex = 0;
            // 
            // lblSalesV
            // 
            lblSalesV.AutoSize = true;
            lblSalesV.Location = new Point(112, 25);
            lblSalesV.Name = "lblSalesV";
            lblSalesV.Size = new Size(33, 20);
            lblSalesV.TabIndex = 1;
            lblSalesV.Text = "163";
            // 
            // lblSalesT
            // 
            lblSalesT.AutoSize = true;
            lblSalesT.Location = new Point(25, 25);
            lblSalesT.Name = "lblSalesT";
            lblSalesT.Size = new Size(43, 20);
            lblSalesT.TabIndex = 0;
            lblSalesT.Text = "Sales";
            // 
            // pnlOrders
            // 
            pnlOrders.Controls.Add(lblOrdersV);
            pnlOrders.Controls.Add(lblOrdersT);
            pnlOrders.Location = new Point(209, 4);
            pnlOrders.Margin = new Padding(3, 4, 3, 4);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new Size(200, 125);
            pnlOrders.TabIndex = 1;
            // 
            // lblOrdersV
            // 
            lblOrdersV.AutoSize = true;
            lblOrdersV.Location = new Point(128, 25);
            lblOrdersV.Name = "lblOrdersV";
            lblOrdersV.Size = new Size(25, 20);
            lblOrdersV.TabIndex = 1;
            lblOrdersV.Text = "33";
            // 
            // lblOrdersT
            // 
            lblOrdersT.AutoSize = true;
            lblOrdersT.Location = new Point(18, 25);
            lblOrdersT.Name = "lblOrdersT";
            lblOrdersT.Size = new Size(53, 20);
            lblOrdersT.TabIndex = 0;
            lblOrdersT.Text = "Orders";
            lblOrdersT.Click += lblOrdersT_Click;
            // 
            // pnlRevenue
            // 
            pnlRevenue.Controls.Add(lblRevenueV);
            pnlRevenue.Controls.Add(lblRevenueT);
            pnlRevenue.Location = new Point(415, 4);
            pnlRevenue.Margin = new Padding(3, 4, 3, 4);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new Size(200, 125);
            pnlRevenue.TabIndex = 2;
            // 
            // lblRevenueV
            // 
            lblRevenueV.AutoSize = true;
            lblRevenueV.Location = new Point(122, 25);
            lblRevenueV.Name = "lblRevenueV";
            lblRevenueV.Size = new Size(82, 20);
            lblRevenueV.TabIndex = 1;
            lblRevenueV.Text = "37,356 PKR";
            lblRevenueV.Click += lblRevenueV_Click;
            // 
            // lblRevenueT
            // 
            lblRevenueT.AutoSize = true;
            lblRevenueT.Location = new Point(25, 25);
            lblRevenueT.Name = "lblRevenueT";
            lblRevenueT.Size = new Size(65, 20);
            lblRevenueT.TabIndex = 0;
            lblRevenueT.Text = "Revenue";
            // 
            // pnlLowStock
            // 
            pnlLowStock.Controls.Add(lvLowStock);
            pnlLowStock.Controls.Add(lblLowStock);
            pnlLowStock.Dock = DockStyle.Fill;
            pnlLowStock.Location = new Point(3, 154);
            pnlLowStock.Margin = new Padding(3, 4, 3, 4);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Size = new Size(981, 436);
            pnlLowStock.TabIndex = 1;
            // 
            // lvLowStock
            // 
            lvLowStock.BackColor = Color.White;
            lvLowStock.Columns.AddRange(new ColumnHeader[] { colProduct, colStock });
            lvLowStock.Location = new Point(13, 26);
            lvLowStock.Margin = new Padding(4, 3, 4, 3);
            lvLowStock.Name = "lvLowStock";
            lvLowStock.Size = new Size(940, 218);
            lvLowStock.TabIndex = 1;
            lvLowStock.UseCompatibleStateImageBehavior = false;
            lvLowStock.View = View.Details;
            lvLowStock.SelectedIndexChanged += lvLowStock_SelectedIndexChanged;
            // 
            // colProduct
            // 
            colProduct.Text = "Products";
            // 
            // colStock
            // 
            colStock.Text = "Stock";
            colStock.Width = 65;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Dock = DockStyle.Top;
            lblLowStock.Location = new Point(0, 0);
            lblLowStock.Margin = new Padding(4, 3, 4, 3);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(76, 20);
            lblLowStock.TabIndex = 0;
            lblLowStock.Text = "Low Stock";
            // 
            // pnlRecentOrders
            // 
            pnlRecentOrders.Controls.Add(lvRecentOrders);
            pnlRecentOrders.Controls.Add(lblRecentOrders);
            pnlRecentOrders.Dock = DockStyle.Fill;
            pnlRecentOrders.Location = new Point(3, 598);
            pnlRecentOrders.Margin = new Padding(3, 4, 3, 4);
            pnlRecentOrders.Name = "pnlRecentOrders";
            pnlRecentOrders.Size = new Size(981, 436);
            pnlRecentOrders.TabIndex = 2;
            // 
            // lvRecentOrders
            // 
            lvRecentOrders.Columns.AddRange(new ColumnHeader[] { colOrderId, colCustomer, colTotal, colStatus });
            lvRecentOrders.Location = new Point(13, 24);
            lvRecentOrders.Margin = new Padding(3, 4, 3, 4);
            lvRecentOrders.Name = "lvRecentOrders";
            lvRecentOrders.Size = new Size(940, 163);
            lvRecentOrders.TabIndex = 1;
            lvRecentOrders.UseCompatibleStateImageBehavior = false;
            lvRecentOrders.View = View.Details;
            // 
            // colOrderId
            // 
            colOrderId.Text = "Order Id";
            // 
            // colCustomer
            // 
            colCustomer.Text = "Customer";
            // 
            // colTotal
            // 
            colTotal.Text = "Total";
            // 
            // colStatus
            // 
            colStatus.Text = "Status";
            // 
            // lblRecentOrders
            // 
            lblRecentOrders.AutoSize = true;
            lblRecentOrders.Dock = DockStyle.Top;
            lblRecentOrders.Location = new Point(0, 0);
            lblRecentOrders.Name = "lblRecentOrders";
            lblRecentOrders.Size = new Size(102, 20);
            lblRecentOrders.TabIndex = 0;
            lblRecentOrders.Text = "Recent Orders";
            lblRecentOrders.Click += label2_Click;
            // 
            // DashboardViews
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblDashboard);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardViews";
            Size = new Size(987, 1038);
            tblDashboard.ResumeLayout(false);
            flpKpi.ResumeLayout(false);
            pnlSales.ResumeLayout(false);
            pnlSales.PerformLayout();
            pnlOrders.ResumeLayout(false);
            pnlOrders.PerformLayout();
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            pnlRecentOrders.ResumeLayout(false);
            pnlRecentOrders.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.FlowLayoutPanel flpKpi;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Label lblSalesV;
        private System.Windows.Forms.Label lblSalesT;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Label lblOrdersV;
        private System.Windows.Forms.Label lblOrdersT;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Label lblRevenueV;
        private System.Windows.Forms.Label lblRevenueT;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Panel pnlRecentOrders;
        private System.Windows.Forms.ListView lvLowStock;
        private System.Windows.Forms.ColumnHeader colProduct;
        private System.Windows.Forms.ColumnHeader colStock;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.ListView lvRecentOrders;
        private System.Windows.Forms.Label lblRecentOrders;
        private System.Windows.Forms.ColumnHeader colOrderId;
        private System.Windows.Forms.ColumnHeader colCustomer;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.ColumnHeader colStatus;
    }
}
