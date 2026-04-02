
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.WindowsApp.Views;
using App.Core.Services;


namespace App.WindowsApp.Forms
{
    public partial class MainForm : Form
    {
        InMemoryProductService _productService = new InMemoryProductService();
        InMemoryCustomerService _customerService = new InMemoryCustomerService();
        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();
        //private IProductService _productService;
        public MainForm()
        {
            InitializeComponent();
            //_productService = new InMemoryProductService();
        }

        private void flpNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //this.pnlContent.Controls.Clear();
            //this.pnlContent.Controls.Add(new DashboardViews());
            ShowView(() => new DashboardViews());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            //SetActiveNavButton(btnProducts);
            //this.pnlContent.Controls.Clear();
            //var view = new ProductsView(_productService);
            //view.Dock = DockStyle.Fill;
            //this.pnlContent.Controls.Add(view);
            ShowView(() => new ProductsView(_productService));
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ShowView(() => new CustomerView(_customerService));
        }

        private void ShowView<T>(Func<T> factory) where T : UserControl
        {
            var key = typeof(T);
            if (!_views.TryGetValue(key, out var view))
            {
                view = factory();
                view.Dock = DockStyle.Fill;
                _views[key] = view;
            }
            if (!pnlContent.Controls.Contains(view))
            {
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(view);
            }
            view.BringToFront();

        }
    }
}
