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
            var categories = new List<object> { "--ALL--" };
            categories.AddRange(Enum.GetValues(typeof(ProductCategoryEnum)).Cast<object>());
            cmbCategory.DataSource = categories;
            cmbCategory.SelectedIndex = 0;



            cmbStockStatus.Items.Clear();
            var stockStatus = new List<object> { "--ALL--" };
            stockStatus.AddRange(Enum.GetValues(typeof(ProductStatusEnum)).Cast<object>());
            cmbStockStatus.DataSource = stockStatus;
            cmbStockStatus.SelectedIndex = 0;

            if (service == null)
                return;
            //service.GetAll();
            _dgvbindingSource.DataSource = service.GetAll();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm(ProductFormModeEnum.Add, null, service);
            prodForm.ShowDialog();
            RefreshGrid();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {

            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct, service);
                prodForm.ShowDialog();
                RefreshGrid();
            }
        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.View, selectedProduct, service);
                prodForm.ShowDialog();
            }
        }
        private void RefreshGrid()
        {
            string searchText = txbSearch.Text;

            ProductCategoryEnum?  selectedCategory=null;
            if(cmbCategory.SelectedItem != null)
            {
                if (cmbCategory.SelectedItem.ToString().Equals("--ALL--"))
                {
                    selectedCategory = null;
                }
                else
                {
                    selectedCategory = (ProductCategoryEnum)cmbCategory.SelectedItem;
                }
            }

            ProductStatusEnum? selectedStatus = null;
            if (cmbStockStatus.SelectedItem != null)
            {
                if (cmbStockStatus.SelectedItem.ToString().Equals("--ALL--"))
                {
                    selectedStatus = null;
                }
                else
                {
                    selectedStatus = (ProductStatusEnum)cmbStockStatus.SelectedItem;
                }
            }



            _dgvbindingSource.DataSource = service.Search(searchText, selectedCategory, selectedStatus);
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {

            RefreshGrid();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbStockStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
