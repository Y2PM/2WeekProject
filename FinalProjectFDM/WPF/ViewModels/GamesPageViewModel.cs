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
        private ICommand _navigateToHomePageCommand;
        public ICommand navigateToHomePageCommand
        {
            get
            {
                if (_navigateToHomePageCommand == null)
                {
                    _navigateToHomePageCommand = new Command(navigateToHomePage, canNavigateToHomePage);
                }
                return _navigateToHomePageCommand;
            }
            set { _navigateToHomePageCommand = value; }
        }

        public bool canNavigateToHomePage()
        {
            return true;
        }

        public void navigateToHomePage()
        {
            MainWindowViewModel windowViewModel = App.Current.MainWindow.DataContext as MainWindowViewModel;
            windowViewModel.page = "MainPage.xaml";
        }
    }
}
