using Calculator.Models;
using NCalc;
using System;
using System.Runtime;
using System.Windows;

namespace Calculator.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        #region Private Func
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
        private RelayCommand _enterCommaCommand;
        private RelayCommand _clearFuncCommand;
        private RelayCommand _clearAllFuncCommand;
        private RelayCommand _enterRegionCommand;
        private RelayCommand _enterEndRegionCommand;
        private RelayCommand _enterFactCommand;
        private RelayCommand _enterPICommand;
        private RelayCommand _enterECommand;
        private RelayCommand _enterSinCommand;
        private RelayCommand _enterCosCommand;
        private RelayCommand _enterTanCommnad;
        private RelayCommand _enterCotCommand;
        private RelayCommand _enterPowCommand;
        private RelayCommand _enterSqrtCommand;
        #endregion

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
            e.Parameters["pi"] = Math.PI;
            e.Parameters["e"] = Math.E;

            e.EvaluateFunction += (name, argc) =>
            {
                double num = Convert.ToDouble(argc.Parameters[0].Evaluate());
                
                switch (name)
                {
                    case "sin":
                        argc.Result = Math.Round(Math.Sin(num * Math.PI / 180), 6);
                        break;
                    case "cos":
                        argc.Result = Math.Round(Math.Cos(num * Math.PI / 180), 6);
                        break;
                    case "tan":
                        argc.Result = Math.Round(Math.Tan(num * Math.PI / 180), 6); // Error: 90 and 270 grad
                        break;
                    case "cot":
                        argc.Result = Math.Round(1.0 / Math.Round(Math.Tan(num * Math.PI / 180), 6), 6);
                        break;
                    case "sqrt":
                        argc.Result = Math.Sqrt(num);
                        break;
                    case "fact":
                        argc.Result = Factorial((int)num);
                        break;
                    case "pow":
                        argc.Result = Math.Pow(num, 2);
                        break;
                }
            };

            try
            {
                object result = e.Evaluate();
                Func = Convert.ToString(result);
            }
            catch
            {
                Func = "Error";
            }
        }

        private int Factorial(int fact)
        {
            int result = 1;

            for (int i = 0; i < fact; ++i)
            {
                result += result * i;
            }

            return result;
        }

        private void Backspace()
        {
            if(Func.Length > 0)
            {
                Func = Func.Substring(0, Func.Length - 1);
            }
        }

        #region Command

        #region FuncButtons

        public RelayCommand ClearFuncCommand
            => _clearFuncCommand ?? (_clearFuncCommand = new RelayCommand(() =>
            {
                Backspace();
            }));

        public RelayCommand ClearAllFuncCommand
            => _clearAllFuncCommand ?? (_clearAllFuncCommand = new RelayCommand(() =>
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
                Func += "fact";
            }));

        public RelayCommand EnterPICommand
            => _enterPICommand ?? (_enterPICommand = new RelayCommand(() =>
            {
                Func += "pi";
            }));

        public RelayCommand EnterECommand
            => _enterECommand ?? (_enterECommand = new RelayCommand(() =>
            {
                Func += "e";
            }));

        public RelayCommand EnterSinCommand
            => _enterSinCommand ?? (_enterSinCommand = new RelayCommand(() =>
            {
                Func += "sin";
            }));

        public RelayCommand EnterCosCommand
            => _enterCosCommand ?? (_enterCosCommand = new RelayCommand(() =>
            {
                Func += "cos";
            }));

        public RelayCommand EnterTanCommand
            => _enterTanCommnad ?? (_enterTanCommnad = new RelayCommand(() =>
            {
                Func += "tan";
            }));

        public RelayCommand EnterCotCommand
            => _enterCotCommand ?? (_enterCotCommand = new RelayCommand(() =>
            {
                Func += "cot";
            }));

        public RelayCommand EnterPowCommand
            => _enterPowCommand ?? (_enterPowCommand = new RelayCommand(() =>
            {
                Func += "pow";
            }));

        public RelayCommand EnterSqrtCommand
            => _enterSqrtCommand ?? (_enterSqrtCommand = new RelayCommand(() =>
            {
                Func += "sqrt";
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

        public RelayCommand EnterCommaCommand
            => _enterCommaCommand ?? (_enterCommaCommand = new RelayCommand(() =>
            {
                Func += ",";
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
