using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.WindowsApp.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm(ProductFormModeEnum mode, Product? p)
        {
            InitializeComponent();
            numPrice.Maximum = Decimal.MaxValue;
            numStock.Maximum = Int32.MaxValue;
            cmbCategory.Items.Clear();
            cmbCategory.DataSource=Enum.GetValues(typeof(ProductCategoryEnum));
            cmbCategory.SelectedIndex = 0;

            cmbStatus.Items.Clear();
            cmbStatus.DataSource=Enum.GetValues(typeof(ProductStatusEnum));
            cmbStatus.SelectedIndex = 0;


            if (mode == ProductFormModeEnum.Edit)
            {
                btnSave.Text = "Update";

            }
            else if (mode == ProductFormModeEnum.View)
            {
                btnSave.Visible = false;
            }
            if(mode == ProductFormModeEnum.Edit || mode == ProductFormModeEnum.View)
            {
               
                txtId.Text = p.Id;
                txtName.Text = p.Name;
                cmbCategory.SelectedItem = p.Category;
                cmbStatus.SelectedItem = p.Status;
                numPrice.Value = p.Price;
                numStock.Value = p.Stock;

            }
            
        }
    }
}
