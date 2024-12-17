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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _03_XAML2
{
    // 이번 단계의 핵심 : MARKUP Extension
    // MarkupExtension 으로 부터 상속 받는 타입은 
    // => XAML 에서 attribute 의 속성 값으로 사용가능 합니다.

    public class Null : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
//          return new SolidColorBrush(Colors.Red);
            return null;
        }
    }

    public class Header : MarkupExtension
    {
        private string key;

        public Header(string k)
        {
            key = k;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            switch(key)
            {
                case "FontSize": return (Double)32;
                case "Background": return new SolidColorBrush( Colors.Red );
            }
            return null;
        }
    }
    // 핵심 : 생성자 인자가 아닌 Property 로 만들었다는 점
    public class MyStyle : MarkupExtension
    {
       
        public String Key { get; set; }
        public String Element { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Element == "Title")
            {
                switch (Key)
                {
                    case "FontSize": return (Double)32;
                    case "Background": return new SolidColorBrush(Colors.Red);
                }
            }
            else if (Element == "Description")
            {
                switch (Key)
                {
                    case "FontSize": return (Double)20;
                    case "Background": return new SolidColorBrush(Colors.Yellow);
                }
            }
            return null;
        }
    }

    public partial class Ex2Window : Window
    {
        public Ex2Window()
        {
            InitializeComponent();
        }
    }
}
