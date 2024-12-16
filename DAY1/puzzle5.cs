using System;
using System.Security.Policy;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// #5. 자료 구조 도입
// => 게임판의 상태를 나타내는 5 * 5 의 2차원 배열

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


        for (int y = 0; y < COUNT; y++)
        {
            for (int x = 0; x < COUNT; x++)
            {

                CroppedBitmap cb = new CroppedBitmap(bitmap,
                                        new Int32Rect(x * width,
                                                      y * height,
                                                      width, height));

                Image img = new Image();

                img.Source = cb;
                img.Stretch = Stretch.Fill;  
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


