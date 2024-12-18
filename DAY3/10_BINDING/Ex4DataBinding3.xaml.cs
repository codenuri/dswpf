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
    /// Ex4DataBinding3.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex4DataBinding3 : Window
    {
        private ObservableCollection<Person> st = new ObservableCollection<Person>();

        public Ex4DataBinding3()
        {
            InitializeComponent();

            st.Add(new Person { Name = "kim", Address = "seoul" });
            st.Add(new Person { Name = "lee", Address = "seoul" });
            st.Add(new Person { Name = "park", Address = "seoul" });

            listview.ItemsSource = st;
        }
    }
}
