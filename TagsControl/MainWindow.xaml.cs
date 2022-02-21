using System.Collections.Generic;

namespace TagsControl
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Items = new List<string>()
            {
                "first item",
                "second item",
                "third item"
            };
        }

        public List<string> Items { get; set; }
    }
}