using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// Step06. Application 도 event 가 있다.

class MainWindow : Window
{
    public MainWindow()
    {
    }
}

class App : Application
{
    // #1. 가상 메소드로 event 처리하는 코드
    protected override void OnActivated(EventArgs e)
    {
        base.OnActivated(e);
        Console.WriteLine("Program Activate 됩니다.");
    }

    public App()
    {
        // #2. delegate(event)를 등록하는 코드
        // Startup event : 프로그램 처럼 실행시 발생하는 이벤트
        // Exit    event : 프로그램이 종료될때 발생
        this.Startup += App_Startup;
    }

    private void App_Startup(object sender, StartupEventArgs e)
    {
        Console.WriteLine("App_Startup");
    }
}


class Program
{
    [STAThread]
    public static void Main()
    {
        App app = new App();

        MainWindow win = new MainWindow();
        win.Show();

        app.Run();
    }
}