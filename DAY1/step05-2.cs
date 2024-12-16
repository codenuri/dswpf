using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// C# 의 특징(MS 제품의 전반적인 특징)
// => rich interface
// => 어떤 일을 하는 방법이 한개가 아닌 여러가지가 있는 언어!


// Step05-2. event 를 처리하는 2가지 방법

// #1. win.약속된event = 메소드 등록
//     => 이 방법이 더 널리 사용됩니다.(내일 부터 배우는 자동생성 코드가하는 방식)
//     => 등록되는 메소드의 인자는 2개(sender, 추가 정보)

// #2. 약속된 가상메소드 override
//     => 가상 메소드의 인자는 1개(추가정보만)
//     => 어차피 Window 의 메소드 이므로 sender 필요 없음. this


class MainWindow : Window
{
    protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
    {
        // 이경우, 기반 클래스 메소드를 호출하는 코드가 자동생성되는데
        // 지우지 말고 그냥 두세요... 하는 일 있음.
        base.OnMouseLeftButtonDown(e);

        Console.WriteLine("OnMouseLeftDown");
    }


    public MainWindow()
    {
        this.MouseLeftButtonDown += MainWindow_MouseLeftButtonDown;
    }

    private void MainWindow_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        Console.WriteLine("MainWindow_MouseLeftButtonDown");
        //MessageBox.Show("Click");
    }
}


class Program
{
    [STAThread]
    public static void Main()
    {
        Application app = new Application();

        MainWindow win = new MainWindow();
        win.Show();

        app.Run();
    }
}