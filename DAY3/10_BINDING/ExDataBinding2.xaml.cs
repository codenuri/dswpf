using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _10_BINDING
{
    /// <summary>
    /// ExDataBinding2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ExDataBinding2 : Window
    {
        // Person : 속성 변경시 통보하는 기능이 있씁니다.
        // List   : 요소 추가시 통보하는 기능이 없습니다.
        //          즉, INotifyPropertyChanged 를 구현안함
        //private List<Person> st = new List<Person>();

        // 아래 컬렉션이 INotifyPropertyChanged를 구현한 Collection 입니다.
        private ObservableCollection<Person> st = new ObservableCollection<Person>();



        public ExDataBinding2()
        {
            InitializeComponent();

            st.Add(new Person { Name = "kim", Address = "seoul" });
            st.Add(new Person { Name = "lee", Address = "seoul" });
            st.Add(new Person { Name = "park", Address = "seoul" });

            // 여러개 요소를 보관 하는 컨테이너는 collection 과 자동연결가능합니다.
            listbox.ItemsSource = st;

            // stackpanel.DataContext = pe; // 이전 예제의 이코드와 잘 비교해보세요
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // #1. List(st) 에 있는 요소를 변경했습니다.
            // => ListBox 가 update 될까요 ?
            st[0].Name = txtbox.Text; 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            st.Add( new Person { Name = "unknown", Address = "unknown" });
        }
    }
}
