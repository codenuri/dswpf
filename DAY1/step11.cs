using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;

// step11 : UI 는 XML 로 만들고, 
//          EVENT 는 C#으로 !!

class MainWindow : Window
{
    public MainWindow()
    {
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

//        MainWindow win = null;
        Window win = null;


        // 실행파일이 있는 위치를 기준으로 ../../.. 해야 소스가 있는 폴더 입니다.
        FileStream fs = new FileStream("../../../ex1.txt", 
                            FileMode.Open, FileAccess.Read);

        win = (Window)XamlReader.Load(fs);

        fs.Close();


        win.Show();

        app.Run();
    }

}
