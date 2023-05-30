using CoPLauncher.View;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace CoPLauncher.View.ViewModel
{
    internal class MainViewModel: ViewModelBase
    {
        private Page Home = new LaunchPage();
        private Page Descr = new DescrPage();
        private Page Settings = new SettingsPage();
        private Page Graphics = new GraphicsPage();
        private Page _CurPage = new LaunchPage();

        public Page CurPage
        {
            get => _CurPage;
            set => Set(ref _CurPage, value);
        }

        public ICommand OpenDescrPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Descr);
            }
        }
        public ICommand OpenSettingsPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Settings);
            }
        }
        public ICommand OpenHomePage
        {
            get
            {
                return new RelayCommand(() => CurPage = Home);
            }
        }
        public ICommand OpenGraphicsPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Graphics);
            }
        }
    }
}
