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

        // 이제 다양한 컨트롤을 sp(stackpanel)에 붙이면 
        // 어떻게 컨트롤을 배치할지를 sp 가 결정합니다.
        // => 윈도우 size 변경시 sp 가 알아서 자식컨트롤의 위치, 크기
        //    를 자동으로 결정.

        // sp.Children : Collection 입니다.
        //               그래서 Add() 로 자식 컨트롤들을 넣으면됩니다.

        sp.Children.Add(new Button { Content = "Button1" });
        sp.Children.Add(new Button { Content = "Button2" });
        sp.Children.Add(new Button { Content = "Button3" });


        // Layout(Panel) 도 다양한 속성이 있습니다
        sp.Orientation = Orientation.Horizontal;

        sp.HorizontalAlignment = HorizontalAlignment.Right;

        // StackPanel 외에도 7~8개의 Layout 이 있습니다.
        // (내일 모두 배우게 됩니다.)

    }
}

// 쉬는 시간에 그림한개만 구해 놓으세요 (width, height 는 700~800정도)
// sliding puzzle 게임 에 배경
// jpg. png 등 모두 가능.. 











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
