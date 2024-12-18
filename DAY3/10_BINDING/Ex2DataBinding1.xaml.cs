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

namespace _10_BINDING
{
    /// <summary>
    /// Ex2DataBinding1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex2DataBinding1 : Window
    {
        private Person pe;

        public Ex2DataBinding1()
        {
            InitializeComponent();

            pe = new Person { Name = "kim", Address = "seoul" };

            // Layout(패널) 에는 다양한 UI 가 놓이게 됩니다.
            // 패널에 DataContext 로 객체를 지정하면
            // 패널위에 모든 컨트롤에서 사용가능합니다.
            // => 객체의 속성(Property) 이름으로 접근하게 됩니다.
            stackpanel.DataContext = pe;
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 객체의 상태가 변경될때
            // => 객체와 연결된 UI 가 자동 업데이트 될수 있을까요 ?
            pe.Name = "lee";
            pe.Address = "jeju";
        }
    }
}
