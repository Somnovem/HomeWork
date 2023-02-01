﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FruitsWPF
{
    /// <summary>
    /// Interaction logic for Request.xaml
    /// </summary>
    public partial class Request : Window
    {
        public static string requestText = "";
        public static string enter = "";
        public Request()
        {
            InitializeComponent();
            txtAnswer.Focus();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (txtAnswer.Text == "") return;
            DialogResult = true;
        }
    }
}
