using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dragdrop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           ListBox list= sender as ListBox;
           ListBoxItem item= list.GetItemAt(e.GetPosition(list));
            if(item!=null)
            {
                DataObject data = new DataObject();
                data.SetData("lista", list);
                data.SetData("item", item);
                DragDrop.DoDragDrop(list, data, DragDropEffects.Move | DragDropEffects.Copy);
             
            }
        }

        private void ListBox_Drop(object sender, DragEventArgs e)
        {

            ListBox list = sender as ListBox;

            ListBoxItem  dane = e.Data.GetData("item") as ListBoxItem;
            ListBox oldlist = e.Data.GetData("lista") as ListBox;
            oldlist.Items.Remove(dane);

            list.Items.Add(dane);

        }
    }
}
