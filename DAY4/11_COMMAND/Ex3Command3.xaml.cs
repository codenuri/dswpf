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

    public class LogInCommand2 : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        // 핵심 : 아래 함수는 언제 호출되는가 ?
        // #1. 처음에 한번 호출됩니다.
        // #2. 컨트롤들의 상태가 변경되어서 
        //     다시 상태조사를 하고 싶다면 CanExecuteChanged 에 등록된
        //     함수를 호출해야 합니다.
        public bool CanExecute(object? parameter)
        {
            Console.WriteLine("CanExecute 호출됨");

            Ex3Command3 win = (Ex3Command3) (Application.Current.MainWindow);

            bool b1 = !string.IsNullOrEmpty(win.txtbox.Text);
            
            return b1 && win.checkbox.IsChecked == true;
        }



        public void FireCanExecute()
        {
            // CanExecute 를 다시 호출해 달라는 것
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


    public partial class Ex3Command3 : Window
    {
        public Ex3Command3()
        {
            InitializeComponent();
        }

        private void txtbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            LogInCommand2 cmd = (LogInCommand2)this.Resources["mycmd1"];

            if (cmd != null)
            {
                cmd.FireCanExecute();
            }
        }

        private void checkbox_Click(object sender, RoutedEventArgs e)
        {
            LogInCommand2 cmd = (LogInCommand2)this.Resources["mycmd1"];

            if (cmd != null)
            {
                cmd.FireCanExecute();
            }
        }
    }
}
