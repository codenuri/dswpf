using System;
using System.Windows;
using System.Windows.Media;

// Step05-1. Window event 처리
// #1. Window 의 파생 클래스를 만들어서 사용

// 아래 코드의 의미
// => Window 에서 발생한 이벤트는 Window 의 메소드에서 처리!!

class MainWindow : Window
{
    public MainWindow() 
    {
        // 아래 코드에서는 "this" 는 없어도 됩니다.
        this.MouseLeftButtonDown += MainWindow_MouseLeftButtonDown;
    }

    private void MainWindow_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        MessageBox.Show("Click");
    }
}


class Program
{
    [STAThread]
    public static void Main()
    {
        Application app = new Application();

        MainWindow win = new MainWindow();
        win.Show();

        app.Run();
    }
}
