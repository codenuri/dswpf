using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// Step08-1. 

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
