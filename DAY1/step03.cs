using System;
using System.Windows;

// Step03. Application 클래스와 event loop

class Program
{
    [STAThread]
    public static void Main()
    {
        // #1. Application 객체 생성
        Application app = new Application();
                        // 1. WPF 라이브러리 관련 초기화 수행
                        // 2. 따라서, Main 에서 다른 작업 하기 전에 먼저 생성

        // #2. UI(윈도우) 생성
        Window win = new Window();
        win.Show();

//        Window win2 = new Window();
//        win2.Show();

        // #3. UI 를 app 등록후, event 루프 수행
//      app.MainWindow = win; // 위에서 만든 윈도우를 Main 윈도우로 등록
//      app.Run(); // 프로그램을 종료하지 말고 event 루프를 수행해 달라.

//      app.Run(win); // 위 코드 대신 이렇게 해도 됩니다.
        app.Run();    // 한개만 만든경우는 이렇게 해도 됩니다.
    }
}
// 꼭 기억할것
// app.MainWindow 속성에 주 윈도우 참조가 저장되었다는점.