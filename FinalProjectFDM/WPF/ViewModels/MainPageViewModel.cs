using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private ICommand _navigateToGamesPageCommand;
        public ICommand navigateToGamesPageCommand
        {
            get
            {
                if (_navigateToGamesPageCommand == null)
                {
                    _navigateToGamesPageCommand = new Command(navigateToGamesPage, canNavigateToGamesPage);
                }
                return _navigateToGamesPageCommand;
            }
            set { _navigateToGamesPageCommand = value; }
        }

        public bool canNavigateToGamesPage()
        {
            return true;
        }

        public void navigateToGamesPage()
        {
            MainWindowViewModel windowViewModel = App.Current.MainWindow.DataContext as MainWindowViewModel;
            windowViewModel.page = "GamesPage.xaml";
        }
    }
}
