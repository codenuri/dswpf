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
    /// Ex3NumberText.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex3NumberText : Window
    {
        public Ex3NumberText()
        {
            InitializeComponent();
        }

        private void txtbox_PreviewTextInput(object sender, 
                                TextCompositionEventArgs e)
        {
            short val;
            bool b = short.TryParse(e.Text, out val);

            if (b)
            {
                Console.WriteLine("숫자이므로 event 전달 중지");
                e.Handled = true;
            }
        }

        private void txtbox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
    }
}

// KEYDOWN, KEYUP, PREVIEW KEYDOWN, PREVIEW KEYUP
// => 인자에 들어오는 것은 "가상 키코드(키보드 번호)" 입니다.
// => 대소문자 구별 안됨.

// TEXTINTPUT
// => 인자로 들어오는 것은 "ascii" 대소 문자 구별됨

// SCAN CODE  : 키보드 배열 순서대로 정의된 키보드 번호(문자 번호 아님)
//               Q:16, W:17, E:18

// 가상 키 코드 : 키보드 번호, 단, S/W 하기 쉽게
//              A 키 : 65,  B 키 : 66, C : 67
//              핵심 : 문자가 아닌 키보드 번호
//              대문자 상태에서 "A" 를 누르면 65
//              소문자 상태에서 "A" 를 누르면 65

// ASC 코드 : 키보드가 아닌 문자에 부여된 번호
//              A : 65,  a : 97