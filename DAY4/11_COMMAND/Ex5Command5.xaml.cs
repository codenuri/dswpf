using _11_COMMAND;
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

// Command 핵심 정리
// => Command 를 사용해서 event 처리 하려면

// #1. LogInCommand4 같은 클래스 만드세요
// #2. XAML 에서 리소스에서 LogInCommand4 객체 생성
// #3. Button 이나 메뉴에서 Command 속성에 연결하세요

// LogInCommand4 같은 클래스 만들때 
// => CanExecute 와 Execute 는 사용자가 만들수 밖에 없습니다.
// => 그런데, add, remove 부분은 WPF 가 제공할수 있습니다.

// 그래서 WPF 에서 아래 클래스 제공
/*
public class RoutedCommand : ICommand
{
    // 아래 코드 처럼 제공
    public event EventHandler? CanExecuteChanged
    {
        add
        {
            CommandManager.RequerySuggested += value;
        }
        remove
        {
            CommandManager.RequerySuggested -= value;
        }
    }


    public bool CanExecute(object? parameter)
    {
        return 사용자가 등록한 함수();
    }

    public void Execute(object? parameter)
    { 
        사용자가 등록한 함수 호출();
    }
}
*/



namespace _11_COMMAND
{
    public class LogInCommand4 : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add
            {
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

            Ex5Command5 win = (Ex5Command5)(Application.Current.MainWindow);

            bool b1 = !string.IsNullOrEmpty(win.txtbox.Text);

            return b1 && win.checkbox.IsChecked == true;
        }


        public void Execute(object? parameter)
        {
            MessageBox.Show("Log In 진행");
        }
    }
    public partial class Ex5Command5 : Window
    {
        public Ex5Command5()
        {
            InitializeComponent();
        }
    }
}
