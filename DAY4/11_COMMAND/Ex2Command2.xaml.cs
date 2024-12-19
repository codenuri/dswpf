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
    // 버튼에 연결한 Command 객체
    // #1. 이명령이 선택될때(버튼 누를때) 해야할 일
    // #2. 명령을 지금 실행할수 있는지 여부(버튼 enable 여부)
    public class LogInCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true; // 항상 실행 할수 있다.
            //return false; // 항상 실행할수 없다
          
        }
        public void Execute(object? parameter)
        {
            MessageBox.Show("Log In 진행");
        }
    }



    public partial class Ex2Command2 : Window
    {
        // 아래 처럼 명령 객체를 코드로 만들어도 되지만
        // 대부분 "XAML 의 리소스로 만들어서 사용"
        // public static LogInCommand logincmd = new LogInCommand();

        public Ex2Command2()
        {
            InitializeComponent();
        }
    }
}
