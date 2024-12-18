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
    /// VisualTree.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class VisualTree : Window
    {
        public VisualTree()
        {
            InitializeComponent();
        }
        // 사용법 : VisualTree vt = new VisualTree();
        //         vt.Process(mainwindow)

        public void Process(DependencyObject root)
        {
            tree.Items.Clear();
            ShowChild(root, null);
        }


        public void ShowChild(DependencyObject obj, TreeViewItem parent )
        {
            TreeViewItem item = new TreeViewItem();

//          item.Header = $"{obj.GetType().Name} ({obj.ToString()})";
            item.Header = $"{obj.GetType().Name}";

            item.IsExpanded = true;

            if( parent == null )
                tree.Items.Add( item );
            else 
                parent?.Items.Add ( item );

            int cnt = VisualTreeHelper.GetChildrenCount(obj);

            for (int i = 0; i < cnt; i++)
            {
                DependencyObject childobj = VisualTreeHelper.GetChild(obj, i);

                ShowChild(childobj, item );
            }

        }
    }
}
