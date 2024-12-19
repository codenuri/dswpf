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
        public event EventHandler? CanExecuteChanged
        {
            // WPF 에서 CanExecuteChanged 에 함수를 등록할때
            // 아래 부분이 호출됩니다
            // value 에 있는값이 WPF의 함수 입니다.
            add 
            {
                // 해당 함수를 CommandManager 라는 클래스에 등록하면
                // 현재 윈도우에 UI 변화가 있으면 
                // #1. 자동으로 value(WPF 함수) 호출
                // #2. WPF 내부 함수가 CanExecute 호출
                // #3. CanExecute 의 결과로 UI Update
                CommandManager.RequerySuggested += value;
            }
            remove 
            {
                CommandManager.RequerySuggested -= value;
            }
        }


 
        public bool CanExecute(object? parameter)
        {
            Console.WriteLine("CanExecute 호출됨");

            Ex4Command4 win = (Ex4Command4)(Application.Current.MainWindow);

            bool b1 = !string.IsNullOrEmpty(win.txtbox.Text);

            return b1 && win.checkbox.IsChecked == true;
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
