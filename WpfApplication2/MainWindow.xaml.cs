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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double s = 0;
            if (Int32.Parse(txbn.Text) <= 0)
                MessageBox.Show("Hay Nhap Lai");
            else
            {
                for (int i = 1; i <= Int32.Parse(txbn.Text); i++)
                    s += (double)1 / i;
             
                MessageBox.Show("S = " + s.ToString());
            }
        }
    }
}
