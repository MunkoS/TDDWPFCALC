using Prism.Commands;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Calculator
{
   public class CalcViewModel: INotifyPropertyChanged
    {
        private ICommand _calcCommand;
        private int _result;
        public CalcViewModel()
        {
            _calcCommand = new DelegateCommand(() =>
            {
                Calc calculator = new Calc();
                Result = calculator.Calculate(Input);

            }
            );
        }

 

        public ICommand CalcCommand
        {
            get
            {
                return _calcCommand;
            }
        }

        public string Input { get; set; }

        public int Result {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            
        }

    }
}
