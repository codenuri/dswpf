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

namespace _09_CONTROL2
{
    /// <summary>
    /// Ex3Example.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex3Example : Window
    {
        public Ex3Example()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // 핵심 : 타이틀 바가 아닌 클라이언트영역에서도 윈도우 이동가능하게
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
