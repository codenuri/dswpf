using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// Step08-1. 객체의 수명에 주의하세요

// 1. App 객체 생성
// 2. MainWindow  객체 생성
//              => App.OnStartup() 호출. this.MainWindow 사용가능

// 3. MainWindow  객체 파괴
//              => App.OnExit() 호출. this.MainWindow 사용 못함
// 4. App 객체 파괴

// App 메소드에서 MainWindow 접근 : MainWindow 가 파괴되었을수 있다!
//                                 항상 조심

// MainWindow 메소드에서 App 접근 : 항상안전하다.
//                                 App 는 프로그램 종료시 마지막으로
//                                 파괴



class MainWindow : Window
{
    public MainWindow()
    {
    }

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

        this.MainWindow.Title = "Hello";
        ((MainWindow)this.MainWindow).Foo(); 
    }

    // OnExit 만들고 MainWindow 의 Foo 호출해 보세요
    protected override void OnExit(ExitEventArgs e)
    {
        base.OnExit(e);
//      ((MainWindow)this.MainWindow).Foo(); // runtime error

       Console.WriteLine($"{this.MainWindow ==null}");
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

        app.Run();
    }

}
