using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF.ViewModels
{
    public class GamesPageViewModel : BaseViewModel
    {
        private ICommand _navigateToMainPageCommand;

        public ICommand navigateToHomePageCommand
        {
            get
            {
                if (_navigateToMainPageCommand == null)
                {
                    _navigateToMainPageCommand = new Command(navigateToMainPage, canNavigateToMainPage);
                }
                return _navigateToMainPageCommand;
            }
            set { _navigateToMainPageCommand = value; }
        }

        public bool canNavigateToMainPage()
        {
            return true;
        }

        public void navigateToMainPage()
        {
            MainWindowViewModel windowViewModel = App.Current.MainWindow.DataContext as MainWindowViewModel;
            windowViewModel.page = "MainPage.xaml";
        }
    }
}
