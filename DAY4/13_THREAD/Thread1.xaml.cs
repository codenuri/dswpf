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
            // #1. 직접 호출. 
            // => 주스레드가 오랜 시간을 걸리는 작업을 하게 되면
            // => event Q에 쌓인 event 를 처리 못하게 됩니다.
            // => "응답없음" 발생
            // => 나중에 한번에 이벤트 처리
            // int ret = Sum(1, 500);  // 오랜 작업을 주스레드가 직접 호출!!

            // #2. 오랜 시간이 걸리는 작업은 새로운 스레드가 하게 하고
            // => 주스레드는 계속 이벤트처리

            //Thread t = new Thread(Sum); // error. 인자 없는 함수만 가능

            Thread t = new Thread( () => Sum(1, 500) ); // 람다표현식
                           // void 함수() { Sum(1,500);} 으로생각
            t.Start();

        }



        // git 에 임시소스에 Sum 복사해오세요
        public static int Sum(int first, int last)
        {
            int s = 0;
            for (int i = first; i <= last; i++)
            {
                s += i;
                Thread.Sleep(10);
                Console.WriteLine($"Sum {i}");
            }
            return s;
        }
    }
}
