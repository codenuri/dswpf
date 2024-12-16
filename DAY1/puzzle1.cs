using System;
using System.Security.Policy;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// #1. 게임 배경 그림 출력

class MainWindow : Window
{
    public MainWindow()
    {
        // #1. Uri 클래스 : 그림, 음악, 동영상등을 Load할때 경로
        //                  를 관리하는 타입. 
        Uri uri = new Uri("C:\\WPF\\totoro.jpg"); // 그림 경로 넣으세요


        // #2. BitmapImage 객체 생성
        // => 순수하게 그림에 대한 데이타를 관리하는 클래스
        BitmapImage bitmap = new BitmapImage( uri );

        // #3. Image : 그림을 화면에 출력하는 컨트롤(UI, 버튼, 윈도우 같은 클래스)
        Image img = new Image();

        img.Source = bitmap;
        

        // #4. Content 속성으로 image 객체 연결
        this.Content = img;
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


// 참고
// 90도 회전
/*
BitmapImage bitmap = new BitmapImage();

bitmap.BeginInit();
bitmap.UriSource = uri;
bitmap.Rotation = Rotation.Rotate90;
bitmap.EndInit();
*/