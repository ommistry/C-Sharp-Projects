﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            keyEqualsTo_Click(sender, e);
        }

        private void keyEqualsTo_Click(object sender, EventArgs e)
        {
            compute();
        }

        private int button21_Click(object sender, EventArgs e)
        {
            return 0;
        }

        private int button16_Click(object sender, EventArgs e)
        {
            return 1;
        }

        private void compute()
        {
            float answer;



        }


    }
}
