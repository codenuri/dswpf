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
    /// <summary>
    /// Ex3Window.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex3Window : Window
    {
        public Ex3Window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // WPF 에서 새로운 창 나타내는 것은 아래 처럼 하면 됩니다.
            Ex1Window ex1 = new Ex1Window();

//          ex1.ShowDialog();   // 자식창이 나타나있는 동안은
                                // 부모창 사용 못함
                                // 흔히 "모달(Modal)" 이라고 합니다.

            ex1.Show(); // Modaless. 부모창 사용가능
                        // 단, 이경우 여러개 나타나지 않도록 주의!
                        
        }
    }
}
