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
    /// Thread2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Thread2 : Window
    {
        public Thread2()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            button.IsEnabled = false;

            Thread t = new Thread(() => Sum(1, 100)); 
            t.Start();

        }

        public void ChangeProgress(int v)
        {
            prg.Value = v;
        }

        public int Sum(int first, int last)
        {
            int s = 0;
            for (int i = first; i <= last; i++)
            {
                s += i;
                Thread.Sleep(50);
                Console.WriteLine($"Sum {i}");

//              prg.Value = i;  // 예외 발생. 새로운 스레드가 주스레드UI접근
//              ChangeProgress(i); // 역시 예외

//                Dispatcher.BeginInvoke(ChangeProgress, i);
                 // 주스레드의 이벤트 Q에 ChangeProgress(i) 를 실행해달라고
                // 정보를 넣는것
                // => 주스레드가 Q에서 꺼내서 ChangeProgress(i) 실행

                Dispatcher.BeginInvoke((int v)=> { prg.Value = i;}, i);

            }
            // Label 에 연산결과 s 넣어 보세요 (s.ToString())
            Dispatcher.BeginInvoke((int v) => { label.Content = v.ToString(); }, s);

            Dispatcher.BeginInvoke( () => { button.IsEnabled = true; } );

            return s;
        }
    }
}
