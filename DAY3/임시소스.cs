        public void ShowChild(DependencyObject obj, string sep)
        {
            // 먼저 자신의 타입 이름을 출력
            Console.WriteLine($"{sep}{obj.GetType().Name}");

            int cnt = VisualTreeHelper.GetChildrenCount(obj);

            for (int i = 0; i < cnt; i++)
            {
                DependencyObject childobj = VisualTreeHelper.GetChild(obj, i);

                ShowChild(childobj, sep + "   ");
            }

        }
