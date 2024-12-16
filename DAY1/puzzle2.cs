using System;
using System.Security.Policy;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// #2. 그림 자르기!

class MainWindow : Window
{
    private const int COUNT = 5;

    public MainWindow()
    {
        BitmapImage bitmap = new BitmapImage(new Uri("C:\\WPF\\totoro.jpg"));

        // 한블럭 크기 계산
        int width  = (int)(bitmap.Width / COUNT);
        int height = (int)(bitmap.Height / COUNT);



        CroppedBitmap cb = new CroppedBitmap(bitmap,
                                new Int32Rect(0, 0, width, height));


        Image img = new Image();

        img.Source = cb;

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


