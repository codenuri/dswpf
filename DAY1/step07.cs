using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// Step07. WPF 프로그램의 기본 구조
// => 기본적으로 2개의 클래스로 구성

// MainWindow : 주 윈도우(GUI). 윈도우에서 발생하는 이벤트 처리

// App        : GUI 는 아니지만
//              프로그램의 시작과 끝(Startup, Exit), 상태 변화등에 따른 event 처리
//              Run 메소드에서 event loop 수행
//              Main 메소드 제공.

// 아래 코드는 WPF 프로그램의 전형적인 모양 입니다.
// => 오후 수업은 이코드를 복사 해서 계속 사용

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
