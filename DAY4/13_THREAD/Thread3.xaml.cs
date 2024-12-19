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
    /// Thread3.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Thread3 : Window
    {
        public Thread3()
        {
            InitializeComponent();
        }
        public static Task<int> SumAsync(int first, int last)
        {
            Task<int> t = Task.Run(() =>
            {

                int s = 0;
                for (int i = first; i <= last; i++)
                {
                    s += i;
                    Thread.Sleep(10);
                }
                return s;
            });
            return t;
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            //            Task<int> t = SumAsync(1, 500);
            //            int n = t.Result; ; // blocking 발생.!

            Console.WriteLine($"start  {Thread.CurrentThread.ManagedThreadId}");


            int ret = await SumAsync(1, 500);
            // #1. SumAsync 를 수행해 놓고 주스레드는
            // #2. event 루프를 수행하고 가게 됩니다.
            // #3. SumAsync 가 끝나면 이곳으로 와서 나머지 작업 수행
            // => 비동기함수를 동기함수 처럼 사용

            Console.WriteLine($"finish {Thread.CurrentThread.ManagedThreadId}");

            label.Content = ret.ToString();
        }
    }
}
