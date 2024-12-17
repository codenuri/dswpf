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

namespace _05_EVENT
{
    /// <summary>
    /// Ex1RoutedEvent.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex1RoutedEvent : Window
    {
        public Ex1RoutedEvent()
        {
            InitializeComponent();
        }

        private void Ellipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Ellipse_MouseLeftButtonDown");
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Window_MouseLeftButtonDown");
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Canvas_MouseLeftButtonDown");
        }

        private void Window_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Window_PreviewMouseLeftButtonDown");

            // event 처리 종료 해 달라.
            // => 다음 단계로 전달되지 않는다.
            // => Preview 에서 종료하면 MouseLeftButtonDown 자체에서 처리안됨
            e.Handled = true;
        }



        private void Canvas_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Canvas_PreviewMouseLeftButtonDown");
        }

        private void Ellipse_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Ellipse_PreviewMouseLeftButtonDown");
        }
    }
}

// event
// 자신이 먼저 처리 => 부모 전달 => 다시 부모 전달 : Bubbling Event
// preview 는 부모 => 자식순서                   : Tunelling Event