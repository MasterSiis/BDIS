﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDIS
{
    public partial class FormRaport : Form
    {
        CrystalReport1 raport = new CrystalReport1();
        MainForm main;
        public FormRaport(CrystalReport1 raport, MainForm form)
        {
            this.main = form;
            this.raport = raport;
            InitializeComponent();
            crystalReportViewer1.ReportSource = raport;
        }

       
        private void FormRaport_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.formReportClosed();
        }
    }
}
