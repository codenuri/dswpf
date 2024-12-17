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

namespace _07_STYLE
{
    /// <summary>
    /// Ex1Style1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex1Style1 : Window
    {
        public Ex1Style1()
        {
            

            Style style = new Style();

            style.Setters.Add( new Setter( Control.ForegroundProperty, 
                                        new SolidColorBrush(Colors.Red)));

            style.Setters.Add(new Setter(Control.BackgroundProperty,
                                        new SolidColorBrush(Colors.Green)));

            style.Setters.Add(new Setter(Control.FontSizeProperty,
                                        (Double)48));

            this.Resources["mystyle2"] = style;

            InitializeComponent();
        }
    }

}
