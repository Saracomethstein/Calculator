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
        private RelayCommand _enterEqualsCommand;
        private RelayCommand _enterPlusCommand;
        private RelayCommand _enterMinusCommand;
        private RelayCommand _enterMultiplicationCommand;
        private RelayCommand _enterDivisionCommand;
        private RelayCommand _enterDotCommand;
        private RelayCommand _enterPlusMinusCommand;
        private RelayCommand _clearFunc;

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

        #region FuncButtons

        public RelayCommand ClearFunc
            => _clearFunc ?? (_clearFunc = new RelayCommand(() =>
            {
                Func = "";
            }));

        #endregion

        #region OperButtons

        public RelayCommand EnterEqualsCommand
            => _enterEqualsCommand ?? (_enterEqualsCommand = new RelayCommand(() =>
            {
                Func += "="; // Time.
                // Calculate!
            }));

        public RelayCommand EnterPlusCommand
            => _enterPlusCommand ?? (_enterPlusCommand = new RelayCommand(() =>
            {
                Func += "+";
            }));

        public RelayCommand EnterMinusCommand
            => _enterMinusCommand ?? (_enterMinusCommand = new RelayCommand(() =>
            {
                Func += "-";
            }));

        public RelayCommand EnterDivisionCommand
            => _enterDivisionCommand ?? (_enterDivisionCommand = new RelayCommand(() =>
            {
                Func += "/";
            }));

        public RelayCommand EnterMultiplicationCommand
            => _enterMultiplicationCommand ?? (_enterMultiplicationCommand = new RelayCommand(() =>
            {
                Func += "*";
            }));

        public RelayCommand EnterDotCommand
            => _enterDotCommand ?? (_enterDotCommand = new RelayCommand(() =>
            {
                Func += ".";
            }));

        public RelayCommand EnterPlusMinusCommand
            => _enterPlusMinusCommand ?? (_enterPlusMinusCommand = new RelayCommand(() =>
            {
                Func += "-";
            }));
        #endregion

        #region ControlButtons
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
        #endregion

        #region InputDigits
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

        public RelayCommand EnterDigitThreeCommand
            => _enterDigitThreeCommand ?? (_enterDigitThreeCommand = new RelayCommand(() =>
            {
                Func += "3";
            }));

        public RelayCommand EnterDigitFourCommand
            => _enterDigitFourCommand ?? (_enterDigitFourCommand = new RelayCommand(() =>
            {
                Func += "4";
            }));

        public RelayCommand EnterDigitFiveCommand
            => _enterDigitFiveCommand ?? (_enterDigitFiveCommand = new RelayCommand(() =>
            {
                Func += "5";
            }));

        public RelayCommand EnterDigitSixCommand
            => _enterDigitSixCommand ?? (_enterDigitSixCommand = new RelayCommand(() =>
            {
                Func += "6";
            }));

        public RelayCommand EnterDigitSevenCommand
            => _enterDigitSevenCommand ?? (_enterDigitSevenCommand = new RelayCommand(() =>
            {
                Func += "7";
            }));

        public RelayCommand EnterDigitEightCommand
            => _enterDigitEightCommand ?? (_enterDigitEightCommand = new RelayCommand(() =>
            {
                Func += "8";
            }));

        public RelayCommand EnterDigitNineCommand
            => _enterDigitNineCommand ?? (_enterDigitNineCommand = new RelayCommand(() =>
            {
                Func += "9";
            }));

        public RelayCommand EnterDigitZeroCommand
            => _enterDigitZeroCommand ?? (_enterDigitZeroCommand = new RelayCommand(() =>
            {
                Func += "0";
            }));
        #endregion

        #endregion
    }
}
