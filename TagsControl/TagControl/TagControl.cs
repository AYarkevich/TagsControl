using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TagsControl.Core;

namespace TagsControl.TagControl
{
    public class TagControl : Control
    {
        public static readonly DependencyProperty TagsItemsProperty =
            DependencyProperty.Register(nameof(TagsItems), typeof(IEnumerable<string>), typeof(TagControl),
                new PropertyMetadata(default(IEnumerable<string>)));

        public static readonly DependencyProperty AddCommandProperty =
            DependencyProperty.Register(nameof(AddCommand), typeof(ICommand), typeof(TagControl),
                new PropertyMetadata(default(ICommand)));

        public static readonly DependencyProperty RemoveCommandProperty =
            DependencyProperty.Register(nameof(RemoveCommand), typeof(ICommand), typeof(TagControl),
                new PropertyMetadata(default(ICommand)));

        public IEnumerable<string> TagsItems
        {
            get => (IEnumerable<string>) GetValue(TagsItemsProperty);
            set => SetValue(TagsItemsProperty, value);
        }

        public ICommand AddCommand
        {
            get => (ICommand) GetValue(AddCommandProperty);
            set => SetValue(AddCommandProperty, value);
        }

        public ICommand RemoveCommand
        {
            get => (ICommand) GetValue(RemoveCommandProperty);
            set => SetValue(RemoveCommandProperty, value);
        }
    }
}