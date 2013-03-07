using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SD.LLBLGen.Pro.Examples.WCF.Host
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (WCFServiceHost.StartService())
            {
                _serviceState.Text = "Opened";
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (WCFServiceHost.StopService())
            {
                _serviceState.Text = "Closed";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            WCFServiceHost.StopService();
        }
    }
}