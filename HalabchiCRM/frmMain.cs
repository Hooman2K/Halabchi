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
    public partial class frmMain : Office2007Form
    {
        public frmMain()
        {
            InitializeComponent();
            //using (var db = new HalabchiDB())
            //{
            //    var set = db.Settings.Where(u => u.ID == 1).FirstOrDefault();
            //    switch (set.Theme)
            //    {
            //        case "مشکی": styleManager1.ManagerStyle = eStyle.Office2010Black; cmbxTheme.SelectedIndex = 2; break;
            //        case "خاکستری": styleManager1.ManagerStyle = eStyle.Office2010Silver; cmbxTheme.SelectedIndex = 1; break;
            //        case "آبی": styleManager1.ManagerStyle = eStyle.Office2010Blue; cmbxTheme.SelectedIndex = 0; break;
            //    }
            //}
        }
        int _time=0;
        private void ChangeTheme(string theme)
        {
            switch (theme)
            {
                case "مشکی": styleManager1.ManagerStyle = eStyle.Office2010Black; cmbxTheme.SelectedIndex = 2; break;
                case "خاکستری": styleManager1.ManagerStyle = eStyle.Office2010Silver; cmbxTheme.SelectedIndex = 1; break;
                case "آبی": styleManager1.ManagerStyle = eStyle.Office2010Blue; cmbxTheme.SelectedIndex = 0; break;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                var set = db.Settings.Where(u => u.ID == 1).FirstOrDefault();
                ChangeTheme(set.Theme);
            }
        }

        private void btnSaveTheme_Click(object sender, EventArgs e)
        {

        }

        private void cmbxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTheme(cmbxTheme.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_time < 10)
                _time++;
            else
            {
                timer1.Enabled = false;
                lblWelCome.Visible = false;
            }
        }
    }
}
