﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZTPProject
{
    /// <summary>
    /// Interaction logic for WynikiPage.xaml
    /// </summary>
    public partial class WynikiPage : Page
    {
        public WynikiPage()
        {
            InitializeComponent();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new MenuPage());
        }
    }
}