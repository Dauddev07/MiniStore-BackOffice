using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using App.Core.Contracts;
using App.Core.Models;
using App.WindowsApp.Forms;

namespace App.WindowsApp.Views
{
    public partial class CustomerView : UserControl
    {
        private readonly ICustomerService _customerService;
        private BindingSource _bindingSource = new BindingSource();
        public CustomerView(ICustomerService _service)
        {
            InitializeComponent();
            _customerService = _service;
            dgvCustomers.DataSource = _bindingSource;
        }
        private void LoadCustomers()
        {
            var customers = _customerService.GetAll();
            _bindingSource.DataSource = customers;
            lblCount.Text = $"Total:{customers.Count}";
        }



        private void tsbAdd_Click(object sender, EventArgs e)
        {
            using var form = new CustomerForm(_customerService, CustomerFormModeEnum.Add);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCustomers();
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var selectedCustomer = _bindingSource.Current as Customer;
            if (selectedCustomer != null)
            {
                using var form = new CustomerForm(_customerService, CustomerFormModeEnum.Edit, selectedCustomer);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadCustomers();
                }
            }
        }
        private void tsbView_Click(object sender, EventArgs e)
        {
            var selectedCustomer = _bindingSource.Current as Customer;
            if (selectedCustomer != null)
            {
                using var form = new CustomerForm(_customerService, CustomerFormModeEnum.View, selectedCustomer);
                form.ShowDialog();
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var selectedCustomer = _bindingSource.Current as Customer;
            if (selectedCustomer != null)
            {
                var confirm = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _customerService.Delete(selectedCustomer.Id);
                    LoadCustomers();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        private void ApplyFilters()
        {
            var customers = _customerService.Search(txtSearch.Text);
            _bindingSource.DataSource = customers;
            lblCount.Text = $"Showing:{customers.Count}";
        }
    }
}
