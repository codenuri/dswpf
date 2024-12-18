﻿using System;
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
    private const int EMPTY = COUNT * COUNT - 1; // 마지막 블럭은 그리면 안된다

    private int[,] state = new int[COUNT, COUNT]; // 이번 단계의 핵심


    private Grid grid = new Grid();


    public void InitGameState()
    {
        // 아래 코드가 0 ~ 24까지 채우는 코드
        for (int y = 0; y < COUNT; y++)
        {
            for (int x = 0; x < COUNT; x++)
            {
                state[y, x] = y * COUNT + x; 
            }
        }

//      state[0, 2] = 20; // 테스트용
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
                    // state[y,x] 에 7 이 있다면
                    // 7 => x= 2번째, y = 1 번째 라는 것을 구해야 한다.
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


