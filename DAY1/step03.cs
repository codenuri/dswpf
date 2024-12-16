using System;
using System.Windows;

// Step03. Application 클래스와 event loop

class Program
{
    [STAThread]
    public static void Main()
    {
        Window win = new Window();
        win.Show();

        Application app = new Application();
        app.MainWindow = win; // 위에서 만든 윈도우를 Main 윈도우로 등록

        app.Run(); // 프로그램을 종료하지 말고 event 루프를 수행해 달라.
      
    }
}
