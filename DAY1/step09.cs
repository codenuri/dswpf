using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

// Step09. Content 라는 속성 - WPF 의 핵심



class MainWindow : Window
{
    public MainWindow()
    {
        this.Title = "Hello"; // 윈도우의 캡션 문자열에 나타납니다.

        // #1. Content 속성 
        //      this.Content = "Hello"; // 윈도우 화면 자체에 나타납니다.



        // #2. Content 에는, 문자열, 자식윈도우, 그림등 다양한것을 연결가능합니다.
        // => Window 뿐 아니라 대부분의 UI 는 Content 속성이 있습니다.
//      Button btn = new Button();
//      btn.Content = "확인";
//      this.Content = btn;

        // #3. 위 3줄은 아래 처럼 해도 됩니다.
        // => 객체 {} 초기화로 속성을 지정하는 코드
        Button btn = new Button { Content = "확인" };
        this.Content = btn;


        // 버튼 누를때 메세지 박스 나타나게 해보세요
        btn.Click += Btn_Click;


    }

    private void Btn_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Button Click");
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
