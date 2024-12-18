﻿using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// Step08. App 와 Window 간의 서로 참조 얻기

// #1. App 에서 Window 객체의 참조가 필요 하면
// => this.MainWindow 사용하면 됩니다.
// => 그런데, "this.MainWindow" 가 "Window class" 타입이므로
// => MainWindow 클래스가 추가한 고유 멤버 접근시에는 아래 처럼 캐스팅해서 사용
//    
//   ((MainWindow)this.MainWindow).Foo();
//   


class MainWindow : Window
{
    public MainWindow()
    {
    }

    // App 의 OnStartup 에서 아래 메소드 호출해 보세요
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

        // 여기서 Window 의 타이틀을 "Hello" 로 변경해 보세요. 
        // => 핵심 App 객체는 MainWindow 속성에 "주 윈도우"참조를 가지고있습니다.

        this.MainWindow.Title = "Hello";

        //      this.MainWindow.Foo(); // error. this.MainWindow의 데이타 타입은
                                        // Window 인데
                                        // Foo 는  MainWindow 클래스에 있다.

        ((MainWindow)this.MainWindow).Foo(); // OK..
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

//      app.MainWindow = win; // 예전에는 필수 
        app.Run();
    }

}
