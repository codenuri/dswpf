using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// step11 : UI 는 XML 로 만들고, 
//          EVENT 는 C#으로 !!

class MainWindow : Window
{
    public MainWindow()
    {
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
