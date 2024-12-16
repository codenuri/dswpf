using System;
using System.Security.Policy;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// #4. 25개 블럭 모두 그리기 
// => 2중루프 로 25개의 image 객체 생성후 grid에 추가
// => Image 의 Stretch, Margin 속성 사용

class MainWindow : Window
{
    private const int COUNT = 5;
    private Grid grid = new Grid();

    public void InitGrid()
    {
        this.Content = grid;

        for (int i = 0; i < COUNT; i++)
        {
            grid.RowDefinitions.Add(new RowDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
        }

        this.Width = 800;
        this.Height = 600;
    }

    public void DrawGame()
    {
        BitmapImage bitmap = new BitmapImage(new Uri("C:\\WPF\\totoro.jpg"));
        int width = (int)(bitmap.Width / COUNT);
        int height = (int)(bitmap.Height / COUNT);


        for( int y = 0; y < COUNT; y++ )
        {
            for (int x = 0; x < COUNT; x++)
            {

                CroppedBitmap cb = new CroppedBitmap(bitmap,
                                        new Int32Rect(x * width, 
                                                      y * height, 
                                                      width, height));

                Image img = new Image();

                img.Source = cb;
                img.Stretch = Stretch.Fill;  // 가로세로 비율 유지 안함.
                img.Margin = new Thickness(0.5); 


                Grid.SetRow(img, y);
                Grid.SetColumn(img, x);

                grid.Children.Add(img);

            }
        }



    }


    public MainWindow()
    {
        InitGrid();

        DrawGame();
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


