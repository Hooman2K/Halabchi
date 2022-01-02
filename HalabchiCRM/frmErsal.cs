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
using System.Globalization;

namespace HalabchiCRM
{
    public partial class frmErsal : Office2007Form
    {
        public frmErsal()
        {
            InitializeComponent();
        }

        public string _ContractID;

        string _idGharardad;
        string _idMahsol;

        float _ersalshode = 0;
        float _mandeh = 0;

        DateTime _dt;

        public void LoadContract(string contractID)
        {
            using (var db = new HalabchiDB())
            {
                var item = db.Types.Where(u => u.ContractID == _ContractID).ToList();

                dgvContract.DataSource = item;
            }
        }

        private string PersianCalenders()
        {
            string date = "";
            _dt = DateTime.Now;
            lblDate.Text = _dt.Year + "/" + _dt.Month + "/" + _dt.Day;
            PersianCalendar PC = new PersianCalendar();
            _dt = DateTime.Parse(lblDate.Text);
            lblDate.Text = PC.GetYear(_dt).ToString("0000") + "/" + PC.GetMonth(_dt).ToString("00") + "/" + PC.GetDayOfMonth(_dt).ToString("00");
            date = lblDate.Text;
            return date;
        }

        private void txtErsali_KeyPress(object sender, KeyPressEventArgs e)
        {
            AppInfo info = new AppInfo();
            info.JustNumber(sender, e);
        }

        private void txtContractDate_DoubleClick(object sender, EventArgs e)
        {
            txtContractDate.Text = PersianCalenders();
        }

        private void frmErsal_Load(object sender, EventArgs e)
        {
            LoadContract(_ContractID);
        }

        private void dgvContract_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _idGharardad = dgvContract.CurrentRow.Cells[2].Value.ToString();
            _idMahsol = dgvContract.CurrentRow.Cells[4].Value.ToString();

            using (var db = new HalabchiDB())
            {
                var mande_ersal = db.Ersalis.Where(u => u.ContractID == _idGharardad && u.ProductCode == _idMahsol).ToList();

                var meghdarAval = db.Types.Where(u => u.ContractID == _idGharardad && u.ProductCode == _idMahsol).FirstOrDefault();

                if (mande_ersal.Count != 0)
                {
                    foreach (var i in mande_ersal)
                    {
                        _ersalshode += float.Parse(i.MeghdareErsal);
                        _mandeh = float.Parse(i.Mandeh);
                    }
                    txtErsalShode.Text = _ersalshode.ToString();
                    txtMande.Text = _mandeh.ToString();
                }
                else
                {
                    txtErsalShode.Text = _ersalshode.ToString();
                    txtMande.Text = meghdarAval.ProductUnit;
                }
            }
        }
        private void Clear()
        {
            txtErsali.Text = txtContractDate.Text = "";
            txtErsalShode.Text = txtMande.Text = "---";
            _idGharardad = "";
            _idMahsol = "";

            _ersalshode = 0;
            _mandeh = 0;

            txtErsali.Select();
            txtErsali.Focus();
        }

        private void btnErsal_Click(object sender, EventArgs e)
        {
            float mandeh = 0;

            if (dgvContract.SelectedCells.Count > 0)
            {
                using (var db = new HalabchiDB())
                {

                    var mande_ersal = db.Ersalis.Where(u => u.ContractID == _idGharardad && u.ProductCode == _idMahsol).ToList();

                    var meghdarAval = db.Types.Where(u => u.ContractID == _idGharardad && u.ProductCode == _idMahsol).FirstOrDefault();

                    if (mande_ersal.Count != 0)
                    {
                        foreach (var i in mande_ersal)
                        {
                            mandeh = float.Parse((float.Parse(i.Mandeh) - (float.Parse(txtErsali.Text))).ToString());
                        }
                    }
                    else
                    {
                        mandeh = float.Parse((float.Parse(txtMande.Text) - float.Parse(txtErsali.Text)).ToString());
                    }


                    Ersali ersali = new Ersali()
                    {
                        CustomerID = dgvContract.CurrentRow.Cells[1].Value.ToString(),
                        ContractID = dgvContract.CurrentRow.Cells[2].Value.ToString(),
                        ProductCode = dgvContract.CurrentRow.Cells[4].Value.ToString(),
                        ProductName = dgvContract.CurrentRow.Cells[5].Value.ToString(),
                        TarikhErsal = txtContractDate.Text,
                        MeghdareErsal = txtErsali.Text,
                        Mandeh = mandeh.ToString()
                    };

                    db.Ersalis.Add(ersali);
                    db.SaveChanges();

                    Clear();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}