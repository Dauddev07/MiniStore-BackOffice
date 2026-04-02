namespace App.WindowsApp.Views
{
    partial class CustomerView
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tsCommands = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbView = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            tsSeprator = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblCount = new Label();
            pnlCustomersData = new Panel();
            dgvCustomers = new DataGridView();
            colid = new DataGridViewTextBoxColumn();
            colname = new DataGridViewTextBoxColumn();
            colphone = new DataGridViewTextBoxColumn();
            colemail = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tsCommands.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlCustomersData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tsCommands, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlCustomersData, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 10.2F);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82F));
            tableLayoutPanel1.Size = new Size(828, 512);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tsCommands
            // 
            tsCommands.BackColor = Color.White;
            tsCommands.ImageScalingSize = new Size(20, 20);
            tsCommands.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbView, tsbDelete, tsSeprator, tsbRefresh });
            tsCommands.Location = new Point(0, 0);
            tsCommands.Name = "tsCommands";
            tsCommands.Size = new Size(828, 27);
            tsCommands.TabIndex = 0;
            tsCommands.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            tsbAdd.Image = Properties.Resources.plus;
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(61, 24);
            tsbAdd.Text = "Add";
            tsbAdd.Click += tsbAdd_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.Image = Properties.Resources.database_edit;
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(59, 24);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsbView
            // 
            tsbView.Image = Properties.Resources.eye;
            tsbView.ImageTransparentColor = Color.Magenta;
            tsbView.Name = "tsbView";
            tsbView.Size = new Size(65, 24);
            tsbView.Text = "View";
            tsbView.Click += tsbView_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.Image = Properties.Resources.trash;
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(77, 24);
            tsbDelete.Text = "Delete";
            tsbDelete.Click += tsbDelete_Click;
            // 
            // tsSeprator
            // 
            tsSeprator.Name = "tsSeprator";
            tsSeprator.Size = new Size(6, 27);
            // 
            // tsbRefresh
            // 
            tsbRefresh.Image = Properties.Resources.refresh;
            tsbRefresh.ImageTransparentColor = Color.Magenta;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Size = new Size(82, 24);
            tsbRefresh.Text = "Refresh";
            tsbRefresh.Click += tsbRefresh_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(lblSearch);
            flowLayoutPanel1.Controls.Add(txtSearch);
            flowLayoutPanel1.Controls.Add(lblCount);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 43);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(822, 45);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.2F);
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(61, 23);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(70, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(339, 30);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 10.2F);
            lblCount.Location = new Point(415, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(70, 23);
            lblCount.TabIndex = 3;
            lblCount.Text = "Count:0";
            // 
            // pnlCustomersData
            // 
            pnlCustomersData.Controls.Add(dgvCustomers);
            pnlCustomersData.Dock = DockStyle.Fill;
            pnlCustomersData.Location = new Point(3, 94);
            pnlCustomersData.Name = "pnlCustomersData";
            pnlCustomersData.Size = new Size(822, 415);
            pnlCustomersData.TabIndex = 2;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { colid, colname, colphone, colemail, colAddress });
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.Location = new Point(0, 0);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(822, 415);
            dgvCustomers.TabIndex = 0;
            // 
            // colid
            // 
            colid.DataPropertyName = "Id";
            colid.HeaderText = "ID";
            colid.MinimumWidth = 6;
            colid.Name = "colid";
            colid.ReadOnly = true;
            // 
            // colname
            // 
            colname.DataPropertyName = "Name";
            colname.HeaderText = "Name";
            colname.MinimumWidth = 6;
            colname.Name = "colname";
            colname.ReadOnly = true;
            // 
            // colphone
            // 
            colphone.DataPropertyName = "Phone";
            colphone.HeaderText = "Phone";
            colphone.MinimumWidth = 6;
            colphone.Name = "colphone";
            colphone.ReadOnly = true;
            // 
            // colemail
            // 
            colemail.DataPropertyName = "Email";
            colemail.HeaderText = "Email";
            colemail.MinimumWidth = 6;
            colemail.Name = "colemail";
            colemail.ReadOnly = true;
            // 
            // colAddress
            // 
            colAddress.DataPropertyName = "Address";
            colAddress.HeaderText = "Address";
            colAddress.MinimumWidth = 6;
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CustomerView";
            Size = new Size(828, 512);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tsCommands.ResumeLayout(false);
            tsCommands.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            pnlCustomersData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ToolStrip tsCommands;
        private ToolStripButton tsbAdd;
        private ToolStripButton tsbEdit;
        private ToolStripButton tsbView;
        private ToolStripButton tsbDelete;
        private ToolStripSeparator tsSeprator;
        private ToolStripButton tsbRefresh;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblCount;
        private Panel pnlCustomersData;
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn colid;
        private DataGridViewTextBoxColumn colname;
        private DataGridViewTextBoxColumn colphone;
        private DataGridViewTextBoxColumn colemail;
        private DataGridViewTextBoxColumn colAddress;
    }
}
