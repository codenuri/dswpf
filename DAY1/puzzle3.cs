using System;
using System.Security.Policy;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// #3. Grid Layout 도입
// => 5 * 5 로 설정
// => 0, 0  위치에  왼쪽 상단 0번째 블럭 그림 출력

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

        // 수업을 위해 윈도우 크기도 설정.
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


