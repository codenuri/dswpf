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

namespace _12_MENU
{
    /// <summary>
    /// MyDialog.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MyDialog : Window
    {
        public MyDialog()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true; // 이렇게 하면 이 결과가
                                 // ShowDialog 의 반환값으로 전달
            Close();    // Dialog 닫기
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
