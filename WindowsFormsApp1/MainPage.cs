﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace MajorHW
{    
    public partial class MainPage : Form
    {
        private Login sauce { get; set; }
        public string _Acc { get; set; }
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            Login l = new Login();
            l.ShowDialog();
            _Acc = l.acc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberUpdate m =  new MemberUpdate();
            m._ac = _Acc;
            m.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sells s = new Sells();
            s._ac = _Acc;
            s.ShowDialog();
        }
    }
}
