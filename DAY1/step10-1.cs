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

//      rd1.Height = 20; // error. 그냥 이렇게 숫자를 넣을수 없습니다
// GridLength 라는 타입의 객체가 필요


//      rd1.Height = new GridLength(200); // 200 pixel
        
        rd1.Height = new GridLength(20, GridUnitType.Star); // 20 %

        RowDefinition rd2 = new RowDefinition();
        rd2.Height = new GridLength(80, GridUnitType.Star); // 80


        grid.RowDefinitions.Add(rd1);
        grid.RowDefinitions.Add(rd2);


        ColumnDefinition cd1 = new ColumnDefinition();
        ColumnDefinition cd2 = new ColumnDefinition();

        grid.ColumnDefinitions.Add(cd1);
        grid.ColumnDefinitions.Add(cd2);

        //------------------------------------------
        // #3. 필요한 자식 컨트롤을 만드세요
        Button btn1 = new Button { Content = "button1" };
        Button btn2 = new Button { Content = "button2" };
        Button btn3 = new Button { Content = "button3" };

        Label lbl1 = new Label {  Content = "label1" };


        // #4. 각 컨트롤이 Grid 에 어느 위치에 놓일지 설정해야 합니다.
        // => 방법이 독특합니다. 잘 생각해보세요
        // => Grid 클래스의 static 메소드 사용
        // => 아래 코드가 복잡해 보일수 있지만 
        //    내일 XML 로 만들면 간단해 집니다.
        Grid.SetRow(btn1, 0); Grid.SetColumn(btn1, 0);
        Grid.SetRow(btn2, 0); Grid.SetColumn(btn2, 1);
        Grid.SetRow(btn3, 1); Grid.SetColumn(btn3, 0);
        Grid.SetRow(lbl1, 1); Grid.SetColumn(lbl1, 1);

        // #5. 각 자식을 grid 의 Collection 에 추가합니다.

        grid.Children.Add(btn1);
        grid.Children.Add(btn2);
        grid.Children.Add(btn3);
        grid.Children.Add(lbl1);
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
