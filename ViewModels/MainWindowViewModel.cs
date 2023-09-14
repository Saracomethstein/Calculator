using Calculator.Models;
using System.Windows;

namespace Calculator.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private RelayCommand _getCloseApplication;
        private RelayCommand _getMinimizedCommand;

        public RelayCommand GetCloseApplication
            => _getCloseApplication ?? (_getCloseApplication = new RelayCommand(() =>
            {
                System.Windows.Application.Current.Shutdown();
            }));

        public RelayCommand GetMinimizedCommand
            => _getMinimizedCommand ?? (_getMinimizedCommand = new RelayCommand(() =>
            {
                var window = System.Windows.Application.Current.Windows[0];

                if (window != null)
                {
                    window.WindowState = WindowState.Minimized;
                }
            }));

    }
}
