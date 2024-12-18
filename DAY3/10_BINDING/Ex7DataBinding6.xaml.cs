using System;
using System.Collections.Generic;
using System.IO;
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
    /// Ex7DataBinding6.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex7DataBinding6 : Window
    {
        public Ex7DataBinding6()
        {
            InitializeComponent();
            MakeTree();
        }

        public void MakeTree()
        {
            var drives = DriveInfo.GetDrives(); 

            foreach (DriveInfo drive in drives)
            {
                TreeViewItem tvitem = new TreeViewItem();

                tvitem.Header = drive.Name;
                tvitem.Tag = drive; 


                treeview.Items.Add(tvitem);

                tvitem.Items.Add("*"); 
            }
        }

        private void treeview_Expanded(object sender, RoutedEventArgs e)
        {
         
            TreeViewItem tvitem = (TreeViewItem)e.OriginalSource;

            tvitem.Items.Clear();  
            DriveInfo di = tvitem.Tag as DriveInfo;

            DirectoryInfo root;

            if (di != null)
            {
                root = di.RootDirectory;
            }
            else
            {
                root = (DirectoryInfo)tvitem.Tag;
            }

            var directories = root.GetDirectories();

            foreach (var directory in directories)
            {
                TreeViewItem item = new TreeViewItem();
                item.Header = directory.Name;
                item.Tag = directory;

                tvitem.Items.Add(item);

                item.Items.Add("*");
            }
        }

        private void treeview_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem item = (TreeViewItem)treeview.SelectedItem;
            //TreeViewItem item = (TreeViewItem)sender;

            if ( item.Tag is DriveInfo di )
            {
                listview.ItemsSource = di.RootDirectory.GetDirectories();
            }
            else if ( item.Tag is DirectoryInfo root )
            {
                listview.ItemsSource = root.GetDirectories();
            }
            
        }
    }
}
