using App.Core.Contracts;
using App.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.WindowsApp.Forms
{
    public partial class CustomerForm : Form
    {
        public CustomerForm(ICustomerService _customerService, CustomerFormModeEnum mode,Customer customer=null)
        {
            InitializeComponent();
        }
    }
}
