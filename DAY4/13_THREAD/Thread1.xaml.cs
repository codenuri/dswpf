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

namespace _13_THREAD
{
    /// <summary>
    /// Thread1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Thread1 : Window
    {
        public Thread1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int ret = Sum(1, 1000);
        }

        // git 에 임시소스에 Sum 복사해오세요
        public static int Sum(int first, int last)
        {
            int s = 0;
            for (int i = first; i <= last; i++)
            {
                s += i;
                Thread.Sleep(10);
            }
            return s;
        }
    }
}
