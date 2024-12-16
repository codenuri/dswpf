using System;
using System.Windows;
using System.Windows.Media;

// Step04. Window 클래스는 다양한 속성(property)를 제공합니다.

class Program
{
    [STAThread]
    public static void Main()
    {
        Application app = new Application();

        Window win = new Window();
        win.Title = "Hello, WPF";

        // 윈도우 크기를 500 * 500 으로 만들어보세요.
        win.Width = 500;
        win.Height = 500;
        win.Left = 100;  // x
        win.Top = 100;   // y

        win.Topmost = true;  // 최상위 윈도우(뒤로 가지 않은 윈도우)
        win.Background = new SolidColorBrush(Colors.Red);

        win.Show();

        app.Run();    
    }
}
