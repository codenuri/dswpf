using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

// Step10-1. Grid Layout
// => 엑셀 같은 형태의 격자로 자식 컨트롤 배치

class MainWindow : Window
{
    public MainWindow()
    {
        // #1. Layout 만들고, Window의 Content 속성에 연결
        Grid grid = new Grid();
        this.Content = grid;

        // #2. Row, Col 의 갯수를 지정해야 합니다.

        // 일반적인 라이브러리들의 코드
        // grid.SetRowsCols(2, 2); 

        // WPF : 잘 설계된 객체지향 라이브러리 입니다.
        //       Column, Row 라는 것도 모두 객체 입니다.
        RowDefinition rd1 = new RowDefinition();
        RowDefinition rd2 = new RowDefinition();

        grid.RowDefinitions.Add(rd1);
        grid.RowDefinitions.Add(rd2);

        ColumnDefinition cd1 = new ColumnDefinition();
        ColumnDefinition cd2 = new ColumnDefinition();

        grid.ColumnDefinitions.Add(cd1);
        grid.ColumnDefinitions.Add(cd2);

        //------------------------------------------




        Button btn1 = new Button { Content = "button1" };

        grid.Children.Add(btn1);
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
