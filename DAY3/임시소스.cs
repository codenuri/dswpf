        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // visual tree 개념 : 현재 UI 의 자식 컨트롤을 나타내는 tree 구조

            int cnt = VisualTreeHelper.GetChildrenCount(this);

            for (int i = 0; i < cnt; i++)
            {
                object obj = VisualTreeHelper.GetChild(this, i);

                Console.WriteLine(obj.GetType().Name );
            }

        }
