using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace HalabchiCRM
{
    public partial class frmAddProduct : Office2007Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }
        bool _itemSelect = false;
        int _id;
        private void Clear()
        {
            txtProductName.Text = txtProductCode.Text = txtProductCount.Text = "";
            cmbxUnit.SelectedIndex = 0;
            txtProductName.SelectAll();
            txtProductName.Focus();
            _itemSelect = false;
        }

        private void LoadStorage()
        {
            using (var db = new HalabchiDB())
            {
                var item = from i in db.Storages select i.StorageName;
                cmbxSelectStorage.DataSource = item.ToList();
                if (item != null)
                    cmbxSelectStorage.SelectedIndex = 0;
            }
        }
        private void Search(string ProductName)
        {

        }
    }
}
