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

namespace _09_CONTROL2
{
    /// <summary>
    /// Ex2ControlTemplate.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex2ControlTemplate : Window
    {
        public Ex2ControlTemplate()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VisualTree vt = new VisualTree();
            vt.Process(this);

            vt.Show();
        }
    }
}
