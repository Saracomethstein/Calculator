using Calculator.Models;
using NCalc;
using System;
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
        private RelayCommand _clearFuncCommand;
        private RelayCommand _enterRegionCommand;
        private RelayCommand _enterEndRegionCommand;
        private RelayCommand _enterFactCommand;
        private RelayCommand _enterPICommand;
        private RelayCommand _enterECommand;

        public string Func
        {
            get { return _func; }
            set
            {
                _func = value;
                NotifyPropertyChanged(nameof(Func));
            }
        }

        private void Calculate()
        {
            NCalc.Expression e = new NCalc.Expression(Func);
            //e.Parameters["sin"] = new Func<double, double>(Math.Sin);
            //e.Parameters["cos"] = new Func<double, double>(Math.Cos);
            double resut = Convert.ToDouble(e.Evaluate());
            Func = Convert.ToString(resut);
        }

        #region Command

        #region FuncButtons

        public RelayCommand ClearFuncCommand
            => _clearFuncCommand ?? (_clearFuncCommand = new RelayCommand(() =>
            {
                Func = "";
            }));

        public RelayCommand EnterRegionCommand
            => _enterRegionCommand ?? (_enterRegionCommand = new RelayCommand(() =>
            {
                Func += "(";
            }));

        public RelayCommand EnterEndRegionCommand
            => _enterEndRegionCommand ?? (_enterEndRegionCommand = new RelayCommand(() =>
            {
                Func += ")";
            }));

        public RelayCommand EnterFactCommand
            => _enterFactCommand ?? (_enterFactCommand = new RelayCommand(() =>
            {
                Func += "!";
            }));

        public RelayCommand EnterPICommand
            => _enterPICommand ?? (_enterPICommand = new RelayCommand(() =>
            {
                Func += "Pi"; // Time.
                // Math.PI.
            }));

        public RelayCommand EnterECommand
            => _enterECommand ?? (_enterECommand = new RelayCommand(() =>
            {
                Func += "E"; // Time.
                // Math.E.
            }));
        #endregion

        #region OperButtons

        public RelayCommand EnterEqualsCommand
            => _enterEqualsCommand ?? (_enterEqualsCommand = new RelayCommand(() =>
            {
                Calculate();
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
