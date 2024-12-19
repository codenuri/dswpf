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
    /// Ex6RoutedCommand1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex6RoutedCommand1 : Window
    {
        public Ex6RoutedCommand1()
        {
            InitializeComponent();
        }

        private void Login_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Login 진행");
        }

        private void Login_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !string.IsNullOrEmpty(txtbox.Text) && 
                            checkbox.IsChecked == true;
        }
    }

// UI(로그인 버튼) 의 Enable/Disable 을 만들려면
// #1. Command 를 사용하지 않을때
// => 로그인 관련 모든 컨트롤(동의,ID, PASSWORD) 에서 발생하는
//    event 핸들러를 만들고
// => 모든 event 핸들러에서 enable 조건 조사후
// => 버튼의 enable/disable을 직접 코딩해야 합니다.
//    그런데, LogIn 은 버튼뿐 아니라 메뉴, 툴바, 단축키로할수도 있으므로
//    이 모든 것은 직접 enable/disable 해야 합니다.


// #2. Command 를 사용하면
// => Execute 와 CanExecute 함수만 만들어서
// => RoutedCommand 에 연결하거나, LogInCommand 같이 직접 만들면 됩니다.
// => 버튼의 Click 이벤트가 아닌 Command 이벤트에 연결
// => Command 이벤트가 있는 컨트롤만 연결가능(버튼, 메뉴, 툴바, 단축키등)


// RoutedCommand 사용법
// #1. C# 소스에  Execute 와 CanExecute 함수 만드세요

// #2. XAML 에서 리소스에 RoutedCommand 객체 생성

// #3. XAML <Window.CommandBinding> 으로 "#2에서만든 객체" 에 "#1의 함수연결"

// #4. 버튼이나 메뉴에서 Click 대신 Command로 리소스에서 만든 객체 연결
