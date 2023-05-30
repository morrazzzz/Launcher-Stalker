using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;
namespace CoPLauncher.View
{
    /// <summary>
    /// Логика взаимодействия для LaunchPage.xaml
    /// </summary>
    public partial class LaunchPage : Page
    {
        bool close_launcher = false;
        int mode_stalker_start = 0;

        public LaunchPage()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void LaunchGameBtn_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBox_close_launcher.IsChecked == true)
                close_launcher = true;
            else
                close_launcher = false;

            string path = null;
            bool fileExitsPath = false;
            if (mode_stalker_start == 1)
            {
                path = @"bin\xr_3da.exe";
                fileExitsPath = File.Exists(path);
                if (fileExitsPath)
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(path) { UseShellExecute = true });
                else
                    MessageBox.Show($"Файл не найден: {path}. Проверьте наличие файла.", "Файл не найден", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (mode_stalker_start == 2)
            {
                path = @"bin\xrEngine.exe";
                fileExitsPath = File.Exists(path);
                if (fileExitsPath)
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(path) { UseShellExecute = true });
                else
                    MessageBox.Show($"Файл не найден: {path}. Проверьте наличие файла.", "Файл не найден", MessageBoxButton.OK, MessageBoxImage.Error);
            }    
            else if (mode_stalker_start == 3)
            {
                path = @"bin\xrEngine.exe";
                fileExitsPath = File.Exists(path);
                if (fileExitsPath)
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(path) { UseShellExecute = true });
                else
                    MessageBox.Show($"Файл не найден: {path}. Проверьте наличие файла.", "Файл не найден", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
                MessageBox.Show($"Режим не выбран.", "Режим не выбран", MessageBoxButton.OK, MessageBoxImage.Error);

           if (close_launcher)
                Application.Current.Shutdown();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectionItem = ComboBox_mode_Stalker.SelectedIndex;

            if (selectionItem == 0)
                mode_stalker_start = 1;
            else if (selectionItem == 1)
                mode_stalker_start = 2;  
            else if (selectionItem == 2)
                mode_stalker_start = 3;
        }
    }
}
