namespace App.WindowsApp.Forms
{
    partial class CustomerPicker
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
            tlpCustomerPicker = new TableLayoutPanel();
            flpSearchBar = new FlowLayoutPanel();
            lblSearchText = new Label();
            txtSearchQuery = new TextBox();
            flpButtons = new FlowLayoutPanel();
            btnSelect = new Button();
            btnCancel = new Button();
            lsCustomers = new ListBox();
            tlpCustomerPicker.SuspendLayout();
            flpSearchBar.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCustomerPicker
            // 
            tlpCustomerPicker.ColumnCount = 1;
            tlpCustomerPicker.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCustomerPicker.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpCustomerPicker.Controls.Add(flpSearchBar, 0, 0);
            tlpCustomerPicker.Controls.Add(flpButtons, 0, 2);
            tlpCustomerPicker.Controls.Add(lsCustomers, 0, 1);
            tlpCustomerPicker.Dock = DockStyle.Fill;
            tlpCustomerPicker.Location = new Point(0, 0);
            tlpCustomerPicker.Name = "tlpCustomerPicker";
            tlpCustomerPicker.RowCount = 3;
            tlpCustomerPicker.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpCustomerPicker.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tlpCustomerPicker.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpCustomerPicker.Size = new Size(800, 450);
            tlpCustomerPicker.TabIndex = 0;
            // 
            // flpSearchBar
            // 
            flpSearchBar.BackColor = Color.White;
            flpSearchBar.Controls.Add(lblSearchText);
            flpSearchBar.Controls.Add(txtSearchQuery);
            flpSearchBar.Dock = DockStyle.Fill;
            flpSearchBar.Location = new Point(3, 3);
            flpSearchBar.Name = "flpSearchBar";
            flpSearchBar.Size = new Size(794, 39);
            flpSearchBar.TabIndex = 0;
            // 
            // lblSearchText
            // 
            lblSearchText.AutoSize = true;
            lblSearchText.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchText.Location = new Point(3, 0);
            lblSearchText.Name = "lblSearchText";
            lblSearchText.Size = new Size(112, 23);
            lblSearchText.TabIndex = 0;
            lblSearchText.Text = "Search Query";
            // 
            // txtSearchQuery
            // 
            txtSearchQuery.Location = new Point(121, 3);
            txtSearchQuery.Name = "txtSearchQuery";
            txtSearchQuery.Size = new Size(385, 27);
            txtSearchQuery.TabIndex = 1;
            txtSearchQuery.TextChanged += txtSearchQuery_TextChanged;
            // 
            // flpButtons
            // 
            flpButtons.BackColor = Color.White;
            flpButtons.Controls.Add(btnSelect);
            flpButtons.Controls.Add(btnCancel);
            flpButtons.Dock = DockStyle.Fill;
            flpButtons.FlowDirection = FlowDirection.RightToLeft;
            flpButtons.Location = new Point(3, 408);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(794, 39);
            flpButtons.TabIndex = 1;
            // 
            // btnSelect
            // 
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Segoe UI", 10.2F);
            btnSelect.Image = Properties.Resources.plus;
            btnSelect.Location = new Point(697, 3);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(94, 29);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Select";
            btnSelect.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.2F);
            btnCancel.Image = Properties.Resources.cancel;
            btnCancel.Location = new Point(597, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lsCustomers
            // 
            lsCustomers.Dock = DockStyle.Fill;
            lsCustomers.FormattingEnabled = true;
            lsCustomers.Location = new Point(3, 48);
            lsCustomers.Name = "lsCustomers";
            lsCustomers.Size = new Size(794, 354);
            lsCustomers.TabIndex = 2;
            lsCustomers.DoubleClick += lsCustomers_DoubleClick;
            // 
            // CustomerPicker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpCustomerPicker);
            Name = "CustomerPicker";
            Text = "CustomerPicker";
            tlpCustomerPicker.ResumeLayout(false);
            flpSearchBar.ResumeLayout(false);
            flpSearchBar.PerformLayout();
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCustomerPicker;
        private FlowLayoutPanel flpSearchBar;
        private FlowLayoutPanel flpButtons;
        private Label lblSearchText;
        private TextBox txtSearchQuery;
        private Button btnSelect;
        private Button btnCancel;
        private ListBox lsCustomers;
    }
}