using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Layouts
{
    public static class LabelSupplier
    {
        public static void SetLabels(this Layout layout)
        {
            for(int i = 1; i <= 100; i++)
            {
                var label = new Label { Text = $"Label {i}" };
                layout.Children.Add(label);
            }
        }

        public static void MakeBackgroundBlue(this VisualElement element)
        {
            element.Background = Brush.Red;
        }
    }
}
