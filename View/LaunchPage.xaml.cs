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
        string path;

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

            string keys = TextBox_Keys.Text;
            bool fileExitsPath;

            fileExitsPath = File.Exists(path);
            if (fileExitsPath)
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(path, keys) { UseShellExecute = true });
             else
                if (path != null)
                    MessageBox.Show($"Файл не найден: {path}. Проверьте наличие файла.", "Файл не найден", MessageBoxButton.OK, MessageBoxImage.Error);
                else
                    MessageBox.Show("Пожалуйста, выберете часть сталкера. Сейчас у вас ничего не выбрано!", "Выберете часть сталкера", MessageBoxButton.OK, MessageBoxImage.Information);

            if (close_launcher)
                Application.Current.Shutdown();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectionItem = ComboBox_mode_Stalker.SelectedIndex;

            if (selectionItem == 0)
                path = "bin\\xr_3da.exe";
            else if (selectionItem == 1)
                path = "bin\\xrEngine.exe";
            else if (selectionItem == 2)
                path = "bin\\xrEngine.exe";
        }

        private void TextBox_Keys_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
