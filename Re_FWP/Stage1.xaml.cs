using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Re_FWP
{
    /// <summary>
    /// Stage1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Stage1 : Page
    {
        public Stage1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Stage2.xaml", UriKind.Relative));
        }

        
    }
}
