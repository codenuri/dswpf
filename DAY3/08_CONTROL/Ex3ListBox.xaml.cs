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

namespace _08_CONTROL
{
    /// <summary>
    /// Ex3ListBox.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex3ListBox : Window
    {
        public Ex3ListBox()
        {
            InitializeComponent();

            listbox.Items.Add("aaaa");
            listbox.Items.Add("bbbb");
        }
    }
}
