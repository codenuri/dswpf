using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _02_XAML
{
    /// <summary>
    /// Ex3Window.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex3Window : Window
    {
        public Ex3Window()
        {
            //btn1.Background = new SolidColorBrush(Colors.Red);

            // 아래 함수 안에서 XAML 의 모든 초기화가 이루어집니다.
            // 컨트롤의 이름(참조변수)와 실제 컨트롤 연결도 이때 됩니다.
            // 따라서, XAML 에서 만든 컨트롤의 이름(참조변수)는 
            // 이함수 아래 부터 사용가능
            Console.WriteLine($"{btn1 == null}");   // True

            InitializeComponent();

            Console.WriteLine($"{btn1 == null}");   // False

            // XAML 로 만든 컨트롤도, 이름(Name, x:Name) 으로 
            // C# 에서 자유롭게 접근 가능합니다.
            btn1.Background = new SolidColorBrush(Colors.Red);
            btn2.Background = new SolidColorBrush(Colors.Yellow);
        }
    }
}
