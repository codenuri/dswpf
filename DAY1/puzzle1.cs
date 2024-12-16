using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// #1. 게임 배경 그림 출력

class MainWindow : Window
{
    public MainWindow()
    {
        Uri uri = new Uri("C:\\WPF\\totoro.jpg"); // 그림 경로 넣으세요

        BitmapImage bitmap = new BitmapImage( uri );

        Image img = new Image();
        img.Source = bitmap;


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
