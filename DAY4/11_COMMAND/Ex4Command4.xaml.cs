using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _11_COMMAND
{
    public class LogInCommand3 : ICommand
    {
        public event EventHandler? CanExecuteChanged;

 
        public bool CanExecute(object? parameter)
        {
            Console.WriteLine("CanExecute 호출됨");

            Ex4Command4 win = (Ex4Command4)(Application.Current.MainWindow);

            bool b1 = !string.IsNullOrEmpty(win.txtbox.Text);

            return b1 && win.checkbox.IsChecked == true;
        }



        public void FireCanExecute()
        {
   
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }


        public void Execute(object? parameter)
        {
            MessageBox.Show("Log In 진행");
        }
    }

    public partial class Ex4Command4 : Window
    {
        public Ex4Command4()
        {
            InitializeComponent();
        }
    }
}
