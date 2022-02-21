using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace TagsControl.TagControl
{
    public class TagControl : Control
    {
        public static readonly DependencyProperty TagsItemsProperty =
            DependencyProperty.Register(nameof(TagsItems), typeof(IEnumerable<string>), typeof(TagControl),
                new PropertyMetadata(default(IEnumerable<string>)));

        public IEnumerable<string> TagsItems
        {
            get => (IEnumerable<string>) GetValue(TagsItemsProperty);
            set => SetValue(TagsItemsProperty, value);
        }
    }
}