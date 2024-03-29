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

namespace Re2_Fwp
{
    /// <summary>
    /// End.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class End : Page
    {
        public End()
        {
            InitializeComponent();
        }

        private void btnGOMain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Start'Page.xaml", UriKind.Relative));
        }

        private void btnRestart_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SStage1.xaml", UriKind.Relative));
        }
    }
}
