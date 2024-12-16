using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// Step08-2
// App 에서 MainWindow 접근 : this.MainWindow 또는
//                           ((MainWindow)this.MainWindow)

class MainWindow : Window
{
    public MainWindow()
    {
    }

    protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
    {
        base.OnMouseLeftButtonDown(e);

        // Application.Current : 프로그램의 어디에서라도
        //                       app 객체의 참조가 필요할때 사용

        // 프로그램을 종료하면 App 객체의 Shutdown 메소드 호출하면됩니다.

        // Application.Current.Shutdown(); 

        ?; // App 의 Foo 호출해 보세요 
    }

}

class App : Application
{
    public void Foo()
    {
        Console.WriteLine("App.Foo");
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
