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
    /// Ex2KeyEvent.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex2KeyEvent : Window
    {
        public Ex2KeyEvent()
        {
            InitializeComponent();
        }

        private void KeyEvent(object sender, KeyEventArgs e)
        {
            Console.WriteLine($"KeyEvent : {e.RoutedEvent}, {e.Key}");
        }

        private void MyTextInput(object sender, TextCompositionEventArgs e)
        {
            Console.WriteLine($"MyTextInput : {e.RoutedEvent}, {e.Text}");
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            Console.WriteLine($"TextChanged : {e.RoutedEvent}");
        }
    }
}

// 키보드를 누르면
// PreviewKeydown
// KEYDOWN - 인자가 대소문자 구별안함

// 누른 키보드가 문자(ASCII)키보드라며 - TextInput 발생 => 인자가 대소문자 구별
// = PreviewTextInput
// = TextChanged   <= TextBox 가 변경되었으므로 발생

// PreviewKeyup
// KEYUP 
