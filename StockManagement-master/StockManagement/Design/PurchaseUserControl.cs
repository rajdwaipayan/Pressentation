using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.Design
{
    public partial class PurchaseUserControl : UserControl
    {
        public PurchaseUserControl()
        {
            InitializeComponent();
        }

        private void manufacturedDatePicker_ValueChanged(object sender, EventArgs e)
        {
            manufacturedDatePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void manufacturedDatePicker_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                manufacturedDatePicker.CustomFormat = "--/--/----";
        }

        private void expireDatePicker_ValueChanged(object sender, EventArgs e)
        {
            expireDatePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void expireDatePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                expireDatePicker.CustomFormat = "--/--/----";
        }
    }
}
