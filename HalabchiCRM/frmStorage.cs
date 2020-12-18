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
    public partial class frmStorage : Office2007Form
    {
        public frmStorage()
        {
            InitializeComponent();
        }
        private void LoadStorage()
        {
            using (var db = new HalabchiDB())
            {
                dgvStorage.DataSource = db.Storages.ToList();
            }
        }
        private void frmStorage_Load(object sender, EventArgs e)
        {
            LoadStorage();
        }

        private void btnSaveStorage_Click(object sender, EventArgs e)
        {
            if (txtStorageName.Text != "")
            {
                using (var db = new HalabchiDB())
                {
                    bool exist = db.Storages.Where(u => u.StorageName == txtStorageName.Text).Any();
                    if (!exist)
                    {
                        Storage stor = new Storage()
                        {
                            StorageName = txtStorageName.Text
                        };
                        db.Storages.Add(stor);
                        db.SaveChanges();
                        FarsiMessageBox.MessageBox.Show("موفقیت", "انبار جدید با موفقیت ثبت شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                        LoadStorage();
                        txtStorageName.Text = "";
                        txtStorageName.SelectAll();
                        txtStorageName.Focus();
                    }
                    else
                    {
                        FarsiMessageBox.MessageBox.Show("اخطار", "نام انبار تکراری است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                        txtStorageName.SelectAll();
                        txtStorageName.Focus();
                    }
                }
            }
            else
            {
                FarsiMessageBox.MessageBox.Show("اخطار", "لطفا نام انبار را وارد کنید", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                txtStorageName.SelectAll();
                txtStorageName.Focus();
            }
        }
    }
}
