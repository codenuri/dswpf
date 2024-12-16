using System;
using System.Media;
using System.Security.Policy;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// #7. Layout 중첩

class MainWindow : Window
{
    private const int COUNT = 5;
    private const int EMPTY = COUNT * COUNT - 1;

    private int[,] state = new int[COUNT, COUNT];
    private Grid grid = new Grid();



    protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
    {
        base.OnMouseLeftButtonDown(e);

         Point pt = e.GetPosition(grid); 

        int bx = (int)(pt.X / (grid.ActualWidth / COUNT));
        int by = (int)(pt.Y / (grid.ActualHeight / COUNT));

 
        if (bx < 0 || by < 0 || bx >= COUNT || by >= COUNT) return;


        if (bx > 0 && state[by, bx - 1] == EMPTY) 
        {
            SwapBlock(bx, by, bx - 1, by);
        }
        else if (bx < COUNT - 1 && state[by, bx + 1] == EMPTY) 
        {
            SwapBlock(bx, by, bx + 1, by);
        }
        else if (by > 0 && state[by - 1, bx] == EMPTY) 
        {
            SwapBlock(bx, by, bx, by - 1);
        }
        else if (by < COUNT - 1 && state[by + 1, bx] == EMPTY) 
        {
            SwapBlock(bx, by, bx, by + 1);
        }
        else
        {
            SystemSounds.Beep.Play();
            return;
        }

    }
    public void SwapBlock(int x1, int y1, int x2, int y2)
    {
 
        var collection = grid.Children.Cast<Image>(); // LINQ

        Image? img1 = collection.FirstOrDefault(
                        img => Grid.GetRow(img) == y1 && Grid.GetColumn(img) == x1);

        Image? img2 = collection.FirstOrDefault(
                        img => Grid.GetRow(img) == y2 && Grid.GetColumn(img) == x2);


        if (img1 != null)
        {
            Grid.SetRow(img1, y2);
            Grid.SetColumn(img1, x2);
        }
        if (img2 != null)
        {
            Grid.SetRow(img2, y1);
            Grid.SetColumn(img2, x1);
        }

        int tmp = state[y1, x1];
        state[y1, x1] = state[y2, x2];
        state[y2, x2] = tmp;
    }







    public void InitGameState()
    {
        for (int y = 0; y < COUNT; y++)
        {
            for (int x = 0; x < COUNT; x++)
            {
                state[y, x] = y * COUNT + x;
            }
        }
    }



    public void InitGrid()
    {
//        this.Content = grid;

        // DockPanel : 위, 아래, 왼쪽, 오른쪽을 지정해서 자식 정렬
        //             마지막 자식이 나머지 영역 전체를 차지

        DockPanel dp = new DockPanel();

        Label lb = new Label { Content = "label" };

        DockPanel.SetDock(lb, Dock.Top);
        DockPanel.SetDock(grid, Dock.Bottom);
                    
        dp.Children.Add(lb);
        dp.Children.Add(grid);
                    // => 마지막 자식이 전체를 차지하게 됩니다.

        // 윈도우에 DockPanel 연결
        this.Content = dp;

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
                if (state[y, x] != EMPTY)
                {
                    int bx = state[y, x] % COUNT;
                    int by = state[y, x] / COUNT;


                    CroppedBitmap cb = new CroppedBitmap(bitmap,
                                            new Int32Rect(bx * width,
                                                          by * height,
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



    }


    public MainWindow()
    {
        InitGameState();

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


