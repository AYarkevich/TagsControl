using System.Collections.Generic;
using System.Collections.ObjectModel;
using TagsControl.Core;

namespace TagsControl
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            AddCommand = new RelayCommand(AddCommandExecute);
            RemoveCommand = new RelayCommand(RemoveCommandExecute);
            
            
            InitializeComponent();
            DataContext = this;
            Items = new ObservableCollection<string>()
            {
                "first item",
                "second item",
                "third item"
            };

        }

        public RelayCommand RemoveCommand { get; }
        public RelayCommand AddCommand { get; }
        public ObservableCollection<string> Items { get; set; }

        private void AddCommandExecute(object arg)
        {
            if (arg is string stringArg)
            {
                Items.Add(stringArg);
            }
        }

        private void RemoveCommandExecute(object arg)
        {
            if (arg is string stringArg)
            {
                Items.Remove(stringArg);
            }
        }
    }
}