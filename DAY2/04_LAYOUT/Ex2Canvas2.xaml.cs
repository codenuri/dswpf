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

namespace _04_LAYOUT
{
    /// <summary>
    /// Ex2Canvas2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex2Canvas2 : Window
    {
        private Point from;

        public Ex2Canvas2()
        {
            InitializeComponent();
        }

        private void canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Console.WriteLine("ButtonDown");

            from = e.GetPosition(this);
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Point to = e.GetPosition(this);

                Line line = new Line();
                line.Stroke = new SolidColorBrush(Colors.Red);

                line.StrokeThickness = 5;

                line.X1 = from.X;
                line.Y1 = from.Y;
                line.X2 = to.X;
                line.Y2 = to.Y;

                // 선을 그리는 것은 결국 "Line" 객체를 만들어서
                // canvas 의 자식으로 추가하는 것 입니다.
                canvas.Children.Add(line);

                from = to; // 현재점을 다시 시작점으로
            }
        }

        private void canvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            canvas.Children.Clear();
        }
    }
}
