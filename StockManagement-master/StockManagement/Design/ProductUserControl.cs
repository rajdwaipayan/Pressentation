using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagement.Model;
using StockManagement.Manager;


namespace StockManagement.Design
{
    public partial class ProductUserControl : UserControl
    {
        ProductManager _productManager = new ProductManager();
        CategoryManager _categoryManager = new CategoryManager();

        public ProductUserControl()
        {
            InitializeComponent();
        }

        private void ProductUserControl_Load(object sender, EventArgs e)
        {
            categoryComboBox.DataSource = _categoryManager.Display();
            comboBox1.DataSource = _categoryManager.Display();
            //gunaComboBox1.DataSource = _categoryManager.Display();
        }
    }
}
