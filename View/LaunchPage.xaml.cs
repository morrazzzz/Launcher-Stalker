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
using Microsoft.Win32;

namespace CoPLauncher.View
{
    /// <summary>
    /// Логика взаимодействия для LaunchPage.xaml
    /// </summary>
    public partial class LaunchPage : Page
    {
        bool close_launcher = false;

        public LaunchPage()
        {
            InitializeComponent();
        }

        private void LaunchGameBtn_Click(object sender, RoutedEventArgs e)
        {
            if (close_launcher == true)
                Application.Current.Shutdown();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            close_launcher = true;
        }
    }
}
