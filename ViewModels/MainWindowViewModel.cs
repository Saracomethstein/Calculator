using Calculator.Models;
using System.Windows;

namespace Calculator.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private string _func;
        private RelayCommand _getCloseApplication;
        private RelayCommand _getMinimizedCommand;
        private RelayCommand _enterDigitOneCommand;
        private RelayCommand _enterDigitTwoCommand;
        private RelayCommand _enterDigitThreeCommand;
        private RelayCommand _enterDigitFourCommand;
        private RelayCommand _enterDigitFiveCommand;
        private RelayCommand _enterDigitSixCommand;
        private RelayCommand _enterDigitSevenCommand;
        private RelayCommand _enterDigitEightCommand;
        private RelayCommand _enterDigitNineCommand;
        private RelayCommand _enterDigitZeroCommand;

        public string Func
        {
            get { return _func; }
            set
            { 
                _func = value;
                NotifyPropertyChanged(nameof(Func));
            }
        }

        #region Command
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

        public RelayCommand EnterDigitOneCommand
            => _enterDigitOneCommand ?? (_enterDigitOneCommand = new RelayCommand(() =>
            {
                Func += "1";
            }));

        public RelayCommand EnterDigitTwoCommand
            => _enterDigitTwoCommand ?? (_enterDigitTwoCommand = new RelayCommand(() =>
            {
                Func += "2";
            }));

        #endregion
    }
}
