using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// Step08. App 와 Window 간의 서로 참조 얻기

class MainWindow : Window
{
    public MainWindow()
    {
    }

    // App 의 OnStartup 에서 아래 메소드 호출해 보세요
    public void Foo()
    {
        Console.WriteLine("MainWindow Foo");
    }
}

class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        // 여기서 Window 의 타이틀을 "Hello" 로 변경해 보세요. 
        // => 핵심 App 객체는 MainWindow 속성에 "주 윈도우"참조를 가지고있습니다.

        this.MainWindow.Title = "Hello";
    }

    public App()
    {

    }

    [STAThread]
    public static void Main()
    {
        App app = new App();

        MainWindow win = new MainWindow();
        win.Show();

//      app.MainWindow = win; // 예전에는 필수 
        app.Run();
    }

}
