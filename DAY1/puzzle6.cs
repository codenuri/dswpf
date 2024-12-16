using System;
using System.Media;
using System.Security.Policy;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// #6. 블럭이동

class MainWindow : Window
{
    private const int COUNT = 5;
    private const int EMPTY = COUNT * COUNT - 1; 

    private int[,] state = new int[COUNT, COUNT]; 
    private Grid grid = new Grid();


    // 결국 사용자는 Image 에서 마우스를 클릭하게 되지만
    // Window 도 이벤트를 처리할수 있습니다(Bubbling Event 개념- 내일)
    protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
    {
        base.OnMouseLeftButtonDown(e);

        // #1. 클릭된 좌표 구하기
        //      Point pt = e.GetPosition(this); // 이코드는 윈도우 기준 좌표
        Point pt = e.GetPosition(grid); // ok. 게임판은 결국 grid 기준으로

        // #2. x, y 축으로 몇번째 블럭인가
        int bx = (int)(pt.X / (grid.ActualWidth / COUNT));
        int by = (int)(pt.Y / (grid.ActualHeight / COUNT));

        // 게임판 밖인 경우
        if (bx < 0 || by < 0 || bx >= COUNT || by >= COUNT) return;


        // #3. 이동 가능한지 조사한다. - 핵심

        if (bx > 0 && state[by, bx - 1] == EMPTY) // 왼쪽이 EMPTY 조사
        {
            SwapBlock(bx, by, bx - 1, by);
        }
        else if (bx < COUNT - 1 && state[by, bx + 1] == EMPTY) // 오른쪽이 EMPTY 조사
        {
            SwapBlock(bx, by, bx + 1, by);
        }
        else if (by > 0 && state[by - 1, bx] == EMPTY) // 위쪽 EMPTY 조사
        {
            SwapBlock(bx, by, bx, by - 1);
        }
        else if (by < COUNT - 1 && state[by + 1, bx] == EMPTY) // 아래 EMPTY 조사
        {
            SwapBlock(bx, by, bx, by + 1);
        }
        else
        {
            SystemSounds.Beep.Play();
            return;
        }
        // 한개라도 움직혔으므려 다 맞추었는지 확인
    }
    public void SwapBlock(int x1, int y1, int x2, int y2)
    {
        // 아래 코드는 약간 어렵습니다. - 별도로 설명..
        var collection = grid.Children.Cast<Image>(); // LINQ

        Image? img1 = collection.FirstOrDefault(
                        img => Grid.GetRow(img) == y1 && Grid.GetColumn(img) == x1);

        Image? img2 = collection.FirstOrDefault(
                        img => Grid.GetRow(img) == y2 && Grid.GetColumn(img) == x2);

        // img1 : grid 의 x1, y1 에 있는 Image
        // img2 : grid 의 x2, y2 에 있는 Image

        // 이제 img1, img2 의 위치를 변경합니다.
        if ( img1 != null)
        {
            Grid.SetRow(img1, y2);
            Grid.SetColumn(img1, x2);
        }
        if (img2 != null)
        {
            Grid.SetRow(img2, y1);
            Grid.SetColumn(img2, x1);
        }
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


