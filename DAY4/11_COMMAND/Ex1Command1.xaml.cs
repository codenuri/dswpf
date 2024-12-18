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

namespace _11_COMMAND
{
    /// <summary>
    /// Ex1Command1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex1Command1 : Window
    {
        public Ex1Command1()
        {
            InitializeComponent();
        }

        // 여러개의 컨트롤에 상태가 변경될때 마다
        // 버튼의 Enable/Disable 여부가 변경되어야 합니다.
        // 이런 판단을 하는 함수를 별도로 만들면 편리합니다.
        // => 디자인 패턴에서 "중재자(Mediator)" 라고 불리는 패턴 입니다.
        private void ChangeButtonState()
        {
            button.IsEnabled = !string.IsNullOrEmpty(txtbox.Text) && checkbox.IsChecked == true;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("로그인과정처리");
        }

        // 결국
        // #1. 버튼을 누를때 해야할 일이 있고 - 지금까지 함수로 작성
        // #2. 버튼을 누를수 있는지(해당 명령을 지금실행할수 있는지) 를 결정하는 함수
        //     필요

        // => 이 2개를 하나의 클래스로 만들자는 것이
        // => WPF Command 기술




        private void txtbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChangeButtonState();
        }

        private void checkbox_Checked(object sender, RoutedEventArgs e)
        {
            ChangeButtonState();
        }


    }
}
