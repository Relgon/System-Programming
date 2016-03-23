﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class DialogForm : Form
    {
        private Form parent;
        public delegate void Callback();
        public event Callback OKButtonClick;

        public DialogForm(Form parent,string message)
        {
            InitializeComponent();
            this.parent = parent;
            this.TextMessage.Text = message;
            parent.BringToFront();

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
           /* parent.BringToFront();
            parent.TopMost = true;*/
            OKButtonClick();
            Close();
    
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            parent.BringToFront();
            parent.TopMost = true;
            Close();
      
        }
    }
}