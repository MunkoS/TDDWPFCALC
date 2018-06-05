using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System.Windows.Input;

namespace CalculatorTest
{
    [TestClass]
    public class CalcViewModelTest
    {
        [TestMethod]
        public void CanCreateViewModel()
        {
            CalcViewModel viewModel = new CalcViewModel();
            
        }

        [TestMethod]
        public void CanInputSum()
        {
            CalcViewModel viewModel = new CalcViewModel();

            viewModel.Input = "1+1";

            Assert.AreEqual("1+1", viewModel.Input);

        }

   
        public void CanExecuteCalculateCommand()
        {
            CalcViewModel viewModel = new CalcViewModel();

            ICommand command = viewModel.CalcCommand;

            command.Execute(null);

        }



        [TestMethod]
        public void CanExecuteCalculateCommandTwoPlusTwo()
        {
            CalcViewModel viewModel = new CalcViewModel();
            viewModel.Input = "2+2";

            ICommand command = viewModel.CalcCommand;
            command.Execute(null);

            Assert.AreEqual(4,viewModel.Result);

        }

        [TestMethod]
        public void CanExecuteCalculateCommandFiveTimeSeven()
        {
            CalcViewModel viewModel = new CalcViewModel();
            viewModel.Input = "5*7";

            ICommand command = viewModel.CalcCommand;
            command.Execute(null);

            Assert.AreEqual(35, viewModel.Result);

        }


        [TestMethod]
        public void ResultChangedNotificationIsFired()
        {
            CalcViewModel viewModel = new CalcViewModel();
            bool hasFired = false;
            viewModel.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == "Result")
                    hasFired = true;
                
            };
            viewModel.Input = "5*7";
            ICommand command = viewModel.CalcCommand;
            command.Execute(null);
            Assert.IsTrue(hasFired);

        }
    }
}
