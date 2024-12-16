using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

// Step10-1. Grid Layout
// => 엑셀 같은 형태의 격자로 자식 컨트롤 배치

class MainWindow : Window
{
    public MainWindow()
    {
        Grid grid = new Grid();
        this.Content = grid;

        Button btn1 = new Button { Content = "button1" };

        grid.Children.Add(btn1);
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
