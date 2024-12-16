using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

// Step09. Content 라는 속성 - WPF 의 핵심



class MainWindow : Window
{
    public MainWindow()
    {
        this.Title = "Hello"; // 윈도우의 캡션 문자열에 나타납니다.

        // #1. Content 속성 
//      this.Content = "Hello"; // 윈도우 화면 자체에 나타납니다.



        // #2. Content 에는, 문자열, 자식윈도우, 그림등 다양한것을 연결가능합니다.

        Button btn = new Button();

        this.Content = btn;
    }
}

















class App : Application
{
    public App()
    {
    }

    [STAThread]
    public static void Main()
    {
        App app = new App();

        MainWindow win = new MainWindow();
        win.Show();

        app.Run();
    }

}
