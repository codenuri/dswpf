using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    // #1. Data Binding 하려면
    // => Data 를 독립된 클래스로 설계하세요
    // => 흔히 "Model" 이라고 부릅니다.

    public class LineInfo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private byte red = 255;
        private byte green = 0;
        private byte blue = 0;
        private int thick = 30;

        public Brush Brush { get; private set; } = new SolidColorBrush(Colors.Red);

        public void ChangeBrush()
        {
            this.Brush = new SolidColorBrush(
                            Color.FromArgb(255, red, green, blue));

            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs("Brush"));
            }

        }


        public byte Red
        {
            get { return red; }
            set { red = value;
            
                if ( PropertyChanged != null)
                {
                    PropertyChanged(this,
                        new PropertyChangedEventArgs("Red"));
                }
                ChangeBrush();
            }
        }
        public byte Green
        {
            get { return green; }
            set
            {
                green = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this,
                        new PropertyChangedEventArgs("Green"));
                }
                ChangeBrush();
            }
        }

        public byte Blue
        {
            get { return blue; }
            set
            {
                blue = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this,
                        new PropertyChangedEventArgs("Blue"));
                }
                ChangeBrush();
            }
        }
        public int Thick
        {
            get { return thick; }
            set
            {
                thick = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this,
                        new PropertyChangedEventArgs("Thick"));
                }
            }
        }
    }





    /// <summary>
    /// Ex8Example.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex8Example : Window
    {
        private LineInfo info = new LineInfo();

        public Ex8Example()
        {
            InitializeComponent();

            stackpanel.DataContext = info;
        }

        private void canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point pt = e.GetPosition(canvas);

            Rectangle r = new Rectangle();

            r.Fill = info.Brush;
            r.Width = info.Thick;
            r.Height = info.Thick;    
            r.StrokeThickness = info.Thick;

            Canvas.SetLeft(r, pt.X);
            Canvas.SetTop(r, pt.Y);

            canvas.Children.Add(r);

          

        }
    }
}
