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
    public class MyPoint
    {
        public int X { set; get; } = 0;
        public int Y { set; get; } = 0;

        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }

    /// <summary>
    /// Ex1Window.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex1Window : Window
    {
        public Ex1Window()
        {
            InitializeComponent();
        }
    }
}
