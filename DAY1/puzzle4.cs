using System;
using System.Security.Policy;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// #4. 25개 블럭 모두 그리기 

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

        CroppedBitmap cb = new CroppedBitmap(bitmap,
                                new Int32Rect(0, 0, width, height));

        Image img = new Image();

        img.Source = cb;

        // img 를 Grid 의 0, 0 에 
        Grid.SetRow(img, 0);
        Grid.SetColumn(img, 0);

        grid.Children.Add(img);
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


