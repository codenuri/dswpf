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

namespace _03_XAML2
{
    /// <summary>
    /// Ex4Window.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex4Window : Window
    {
        public Ex4Window()
        {
            InitializeComponent();

            // WPF 학습할때, 각각의 컨트롤의 클래스 계층도를 가끔 보면
            // 도움이 됩니다.
            int n1 = 10;
            string s = "hello";

            Util.ShowHierachy(n1);
            Util.ShowHierachy(s);
            Util.ShowHierachy(this);
            Util.ShowHierachy(sp);
            Util.ShowHierachy(button);
            Util.ShowHierachy(label);
            Util.ShowHierachy(rect);

            // App 객체의 클래스 계층도 출력되게 해보세요
            Util.ShowHierachy(  Application.Current );
        }
    }
}
