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
    public partial class frmPipeLine : Office2007Form
    {
        public frmPipeLine()
        {
            InitializeComponent();
        }

        public bool _isNew = true;
        public int _id;

        private void LoadPipLine()
        {
            using (var db = new HalabchiDB())
            {
                dgvPipeLine.DataSource = db.PipeLines.ToList();
                txtPipeLineName.Text = "";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (_isNew)
            {
                if (txtPipeLineName.Text != null)
                {
                    using (var db = new HalabchiDB())
                    {
                        bool exist = db.PipeLines.Where(u => u.PipeLineName == txtPipeLineName.Text).Any();
                        if (exist == false)
                        {
                            PipeLine Pipe = new PipeLine()
                            {
                                PipeLineName = txtPipeLineName.Text
                            };
                            db.PipeLines.Add(Pipe);
                            db.SaveChanges();
                            FarsiMessageBox.MessageBox.Show("موفقیت", "خط جدید با موفقیت ثبت شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                            LoadPipLine();
                        }
                        else
                        {
                            FarsiMessageBox.MessageBox.Show("خطا", "نام خط تکراری است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                        }
                    }
                }
                else
                {
                    FarsiMessageBox.MessageBox.Show("خطا", "نام خط وارد نشده است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                }
            }
            else
            {
                using (var db = new HalabchiDB())
                {
                    var Pipe = db.PipeLines.Where(u => u.ID == _id).FirstOrDefault();
                    Pipe.PipeLineName = txtPipeLineName.Text;
                    db.SaveChanges();
                    FarsiMessageBox.MessageBox.Show("موفقیت", "خط با موفقیت ویرایش شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                    LoadPipLine();
                    _isNew = true;
                }
            }
        }

        private void dgvPipeLine_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _isNew = false;
            _id = int.Parse(dgvPipeLine.CurrentRow.Cells[0].Value.ToString());
            txtPipeLineName.Text = dgvPipeLine.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
