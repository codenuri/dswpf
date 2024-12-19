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
    /// Ex2Dialog.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex2Dialog : Window
    {
        public Ex2Dialog()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MyDialog dlg = new MyDialog();

            dlg.txtbox.Text = "초기값";

            if (dlg.ShowDialog() == true)
            {
                MessageBox.Show("OK 누름");
            }
            else
            {
                MessageBox.Show("Cancel 누름");
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg =
                                    new Microsoft.Win32.OpenFileDialog();

            dlg.FileName = "디폴트파일이름";
            dlg.DefaultExt = "*.txt";
            dlg.Filter = "Text(*.txt)|*.txt|All(*.*)|*.*";

            if (dlg.ShowDialog() == true)
            {
                string s = dlg.FileName; // 선택한 파일 이름

                MessageBox.Show(s);
            }
        }
    }
}
