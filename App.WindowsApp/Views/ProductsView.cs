using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using App.WindowsApp.Forms;

namespace App.WindowsApp.Views
{
    public partial class ProductsView : UserControl
    {
        IProductService service;
        BindingSource _dgvbindingSource = new BindingSource();
        public ProductsView(IProductService _service)
        {
            service = _service;
            InitializeComponent();
            dgvProducts.DataSource = _dgvbindingSource;
        }

        private void ProductsView_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("--ALL--");
            cmbCategory.Items.AddRange(Enum.GetNames(typeof(ProductCategoryEnum)));
            cmbCategory.SelectedIndex = 0;

            cmbStockStatus.Items.Clear();
            cmbStockStatus.Items.Add("--ALL--");
            cmbStockStatus.Items.AddRange(Enum.GetNames(typeof(ProductStatusEnum)));
            cmbStockStatus.SelectedIndex = 0;

            if (service == null)
                return;
            service.GetAll();
            _dgvbindingSource.DataSource = service.GetAll();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm(ProductFormModeEnum.Add,null,service);
            prodForm.ShowDialog();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
           
            Product?  selectedProduct=_dgvbindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct,service);
                prodForm.ShowDialog();
            }
        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.View, selectedProduct,service);
                prodForm.ShowDialog();
            }
        }
    }
}
