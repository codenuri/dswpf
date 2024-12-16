using System;
using System.Windows;

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


        win.Show();

        app.Run();    
    }
}
