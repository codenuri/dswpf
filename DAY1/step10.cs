using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

// Step10. Layout 
// #1. Content 속성에는 오직 한개의 객체만 연결가능합니다.
// #2. 여러개 자식을 부착하려면 Layout 을 사용합니다

// window.Content = layout;
// layout.Add(버튼1);
// layout.Add(버튼2);
// layout.Add(버튼3);

// Layout : 여러개 자식 컨트롤을 어떻게 배치 할지 결정하는 클래스
//          "Panel" 이라고도 하고
//          7~8 개 정도 됩니다.

class MainWindow : Window
{
    public MainWindow()
    {
        // StackPanel : 모든 자식컨트롤을 스택 처럼 차례대로 쌓는 Layout
        StackPanel sp = new StackPanel();
        this.Content = sp;

        sp.Children.Add(new Button { Content = "Button1" });
        sp.Children.Add(new Button { Content = "Button2" });
        sp.Children.Add(new Button { Content = "Button3" });

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
