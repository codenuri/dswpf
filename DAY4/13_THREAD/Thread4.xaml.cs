using System;
using System.Collections.Generic;
using System.IO;
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
    /// Thread4.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Thread4 : Window
    {
        public Thread4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream("a.txt", FileMode.Create))
            {
                byte[] buff = new byte[1024 * 1024 * 2000]; // 2G

                fs.Write(buff); //  동기적으로 쓰기

                Console.WriteLine("WriteSync Finish");
            }
        }

        private async void Button2_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream("a.txt", FileMode.Create))
            {
                byte[] buff = new byte[1024 * 1024 * 2000]; // 2G

//                fs.WriteAsync(buff); //  비동기적으로 쓰기
//                               => 요청만 하고 즉시 반환

                await fs.WriteAsync(buff);
                        // 요청하고
                        // 주스레드는 메세지처리 루프로가서 계속 메세지 처리할수 있
                        // 작업이 종료되면 메세지Q에 종료 되었다고 event 수신
                        // 이곳으로 다시 와서 수행


                Console.WriteLine("WriteAsync Finish");
            }
        }
    }
}
