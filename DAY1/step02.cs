using System;
using System.Windows;

// Step02. Window 만들기
// #1. 프로그램에서 UI 를 생성하는 경우 반드시
//     Main 함수위에 "[STAThread]" 표기해야 합니다.

// #2. 윈도우를 만들려면 "Window" 클래스 사용합니다

class Program
{
    [STAThread]
    public static void Main()
    {
        Window win = new Window();
        win.Show();

        MessageBox.Show("Hello, WPF");
    }
}
