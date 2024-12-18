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

namespace _10_BINDING
{
    /// <summary>
    /// Ex8Example.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex8Example : Window
    {
        private byte red = 255;
        private byte green = 0;
        private byte blue = 0;
        private int thick = 0;

        public Ex8Example()
        {
            InitializeComponent();
        }

        private void canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point pt = e.GetPosition(canvas);

            Rectangle r = new Rectangle();

            r.Fill = new SolidColorBrush(Color.FromArgb(255, red, green, blue));
            r.Width = 30;
            r.Height = 30;    
            r.StrokeThickness = thick;

            Canvas.SetLeft(r, pt.X);
            Canvas.SetTop(r, pt.Y);

            canvas.Children.Add(r);

            Console.WriteLine("aa");

        }
    }
}
