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

namespace _06_RESOURCE
{
    /// <summary>
    /// Ex1Resource1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex1Resource1 : Window
    {
        public Ex1Resource1()
        {
            // 핵심 #1. 리소스 개념(정체)
            // App 나 Window 안에는 Resources 라는 속성이 있는데.
            // 정체는 Dictionary 입니다. ( key-value 보관 )
            // Util.ShowHierachy(this.Resources);

            // 핵심 #2. C#코드로 리소스를 만들어서 등록하는 방법
            // 자주 사용하는 브러시(자원)을 미리 만들어서
            // 리소스(dictionary)에 보관한것
            this.Resources["mybrush1"] = new SolidColorBrush(Colors.Yellow);

            // 핵심 #3. 아래 메소드 안에서 XAML 의 속성 초기화등이 수행됩니다.
            // 따라서, XAML 에서 사용할 리소스를 C# 코드로  만들려면
            // 반드시 이 메소드 호출전에 만들어야 합니다.
            InitializeComponent();

 
         
        }
    }
}
