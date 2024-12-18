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
    /// Ex6DataBinding5.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex6DataBinding5 : Window
    {
        public Ex6DataBinding5()
        {
            InitializeComponent();

            // Fonts.SystemFontFamilies : 현재 PC에 설치된 모든 폰트
            //                            목록을 가진 collection 
            listbox.ItemsSource = Fonts.SystemFontFamilies;
        }
    }
}

// 1. slider 변할때, label 폰트 크기 연결 - element binding
// 2. text 변할때 label 문자열 변경
// 3. listbox 선택 변경시, label 폰트 변경
