using System;
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


