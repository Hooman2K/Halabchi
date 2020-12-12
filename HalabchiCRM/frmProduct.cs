﻿using System;
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
    public partial class frmProduct : Office2007Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        public bool _isNew = true;
        public int _id;
        private void Clear()
        {
            txtProductName.Text = txtProductCode.Text = "";
            txtProductUnit.Text = "0";
            txtProductCode.SelectAll();
            txtProductCode.Focus();
        }

        private void txtProductUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            AppInfo info = new AppInfo();
            info.JustNumber(sender, e);
        }

        private void brnAddProduct_Click(object sender, EventArgs e)
        {
            if(_isNew)
            {
                if (txtProductCode.Text != "" && txtProductName.Text != "")
                {
                    using (var db = new HalabchiDB())
                    {
                        bool exist = db.Products.Where(u => u.ProductCode == txtProductCode.Text).Any();
                        if (!exist)
                        {
                            Product pr = new Product()
                            {
                                ProductCode = txtProductCode.Text,
                                ProductName = txtProductName.Text,
                                ProductUnit = float.Parse(txtProductUnit.Text)
                            };
                            db.Products.Add(pr);
                            db.SaveChanges();
                            FarsiMessageBox.MessageBox.Show("محصول جدید با موفقیت اضافه شد", "موفقیت", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                            Clear();
                        }
                        else
                        {
                            FarsiMessageBox.MessageBox.Show("کد محصول تکراری است", "خطا", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                            Clear();
                        }
                    }
                }
                else
                {
                    FarsiMessageBox.MessageBox.Show("وارد کردن کد محصول و نام محصول اجباری است", "خطا", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                    txtProductCode.SelectAll();
                    txtProductCode.Focus();
                }
            }
            else
            {
                //کد های ویرایش
            }
        }
    }
}
