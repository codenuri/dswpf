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
    /// Ex1ElementBinding.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex1ElementBinding : Window
    {
        // #1. 아래 코드는 C# 코드로 직접 slider1 과 slider2를 연결한것
        // => event 처리

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (slider1 != null && slider2 != null)
            {
                slider2.Value = slider1.Value;
            }
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (slider1 != null && slider2 != null)
            {
                slider1.Value = slider2.Value;
            }
        }

        public Ex1ElementBinding()
        {
            InitializeComponent();

            // #2. 아래 코드는 C# 코드로 2개의 컨트롤의 속성을 연결(Binding) 한것
            Binding b = new Binding();

            b.Source = slider3; // slider3 의
            b.Path = new PropertyPath("Value"); // value 를
//          b.Mode = BindingMode.OneWay;        // 한방향으로
//          b.Mode = BindingMode.OneWayToSource; 
//          b.Mode = BindingMode.TwoWay;
            b.Mode = BindingMode.Default;

            slider4.SetBinding(System.Windows.Controls.Slider.ValueProperty, b);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            label.FontSize = 50;
        }
    }
}
