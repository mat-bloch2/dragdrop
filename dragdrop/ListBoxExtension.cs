using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace dragdrop
{
    public static class ListBoxExtension
    {
        public static ListBoxItem GetItemAt(this ListBox listBox,Point point)
        {
            DependencyObject zdażenie = VisualTreeHelper.HitTest(listBox, point).VisualHit;
            while(zdażenie!=null && !(zdażenie is ListBoxItem))
            zdażenie = VisualTreeHelper.GetParent(zdażenie);
            return (ListBoxItem)zdażenie;
        }

      
    }
}
