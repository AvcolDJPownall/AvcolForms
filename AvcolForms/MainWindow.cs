﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvcolForms
{
    public partial class MainWindow : Form
    {

        private List<Type> AvaliableForms = new List<Type>()
        {
            typeof(PrinterRequestForm)
        };

        public MainWindow()
        {
            InitializeComponent();
            Application.Run(new PrinterRequestForm());
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int index = e.Node.Index;
            //Application.Run(AvaliableForms[index]);

        }

        private void form_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}