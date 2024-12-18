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
    /// Ex4Event.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex4Event : Window
    {
        public Ex4Event()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // #1. txtbox 의 값을 얻어야 합니다.
            string s = txtbox.Text;

            if (s == String.Empty) return;

            // #2. txtbox 를 비우세요
            txtbox.Text = "";

            // #3. txtbox에서 얻은것을 listbox에 추가하세요
            listbox.Items.Add(s);
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // #1. listbox 에서 선택된 항목을 얻어야 합니다.
            int idx = listbox.SelectedIndex; // 선택된 항목의 index

            string s = listbox.SelectedItem.ToString();

            // #2. label 을 변경해야 합니다.

            label.Content = s;
        }
    }
}
