using System;
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
    /// SStage3.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SStage3 : Page
    {
        public SStage3()
        {
            InitializeComponent();
        }

        private void btnNext3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/End.xaml", UriKind.Relative));
        }
    }
}
