﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ChamDiem.Presentation
{
    public partial class frmEditBox : DevExpress.XtraEditors.XtraForm
    {
        public static string content = "";
        public frmEditBox()
        {
            InitializeComponent();
        }
        public frmEditBox(string title)
        {
            InitializeComponent();
            this.Text = title;
        }

        private void _btnOK_Click(object sender, EventArgs e)
        {
            content = _txtContent.Text;
            this.Close();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            content = "";
            this.Close();
        }
    }
}