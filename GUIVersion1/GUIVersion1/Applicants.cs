﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIVersion1
{
    public partial class Applicants : Form
    {
        public Applicants()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Applicants App1 = new Applicants();
            this.Close();
        }
    }
}
