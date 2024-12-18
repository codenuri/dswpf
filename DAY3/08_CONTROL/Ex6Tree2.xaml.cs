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

namespace _08_CONTROL
{
    /// <summary>
    /// Ex6Tree2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex6Tree2 : Window
    {
        public Ex6Tree2()
        {
            InitializeComponent();
            MakeTree();
        }

        public void MakeTree()
        {
            // #1. Drive 명 얻기
            var drives = DriveInfo.GetDrives(); // A:, B:, C:, D: 얻기

            foreach (DriveInfo drive in drives)
            {
                TreeViewItem tvitem = new TreeViewItem();

                tvitem.Header = drive.Name;
                tvitem.Tag = drive; // 아이템에 태그로 drive 객체 자체를 보관
                                    // 이 예제의 핵심

                // treeview : treeview 자체의 이름
                // tvitem   : 현재 treeview 에 추가한 항목이름
                treeview.Items.Add(tvitem);

                // item 에 임시로 자식 부착 
                tvitem.Items.Add("*"); // 앞에 삼각형 표시하기 위해
            }
        }

        private void treeview_Expanded(object sender, RoutedEventArgs e)
        {
            // 현재 sender 는 TreeView 입니다.
            // 현재 선택(열린) TreeViewItem 얻기            
            TreeViewItem tvitem = (TreeViewItem)e.OriginalSource;

            tvitem.Items.Clear();  // * 등 기존에 있던 항목 제거

            // Tag 에 포함된 drive 객체를 꺼내서 디렉토리 열거
            DriveInfo di = tvitem.Tag as DriveInfo;

            DirectoryInfo root;

            if (di != null )
            {
                root = di.RootDirectory;
            }
            else
            {
                // Tag 에 보관된것이 Drive 가 아닌 Directory 라는 것
                root = (DirectoryInfo)tvitem.Tag;
            }


            var directories = root.GetDirectories();

            foreach (var directory in directories)
            {
                TreeViewItem item = new TreeViewItem();
                item.Header = directory.Name;
                item.Tag = directory;

                // 현재 아이템(선택된아이템)의 자식으로 다시 디렉토리 추가
                tvitem.Items.Add(item);

                item.Items.Add("*");
            }



            Console.WriteLine("expanded");
        }
    }
}
