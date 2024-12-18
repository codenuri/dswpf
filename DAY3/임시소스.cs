        public Ex1ElementBinding()
        {
            InitializeComponent();

            Binding b = new Binding();

            b.Source = slider3; // slider3 의
            b.Path = new PropertyPath("Value"); // value 를
            b.Mode = BindingMode.OneWay;        // 한방향으로

            slider4.SetBinding(System.Windows.Controls.Slider.ValueProperty, b);
        }
