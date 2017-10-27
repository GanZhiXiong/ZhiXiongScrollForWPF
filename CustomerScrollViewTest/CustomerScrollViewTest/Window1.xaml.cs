using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CustomerScrollViewTest
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public class MyClass
        {
            public string Name{ get; set; }
            public string Value{ get; set; }
        }

        public Window1()
        {
            InitializeComponent();

            List<MyClass> myClasses=new List<MyClass>();
            for (int i = 0; i < 50; i++)
            {
                MyClass myClass=new MyClass();
                myClass.Name = "name" + i;
                myClass.Value= "name" + i;
                myClasses.Add(myClass);
            }
            DataGridTest.ItemsSource = myClasses;
        }

        private void UIElement_OnMouseWheel(object sender, MouseWheelEventArgs e)
        {
            Console.WriteLine(sender);
        }

        private void UIElement_OnPreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
            eventArg.RoutedEvent = UIElement.MouseWheelEvent;
            eventArg.Source = sender; 
            ScrollViewer.RaiseEvent(eventArg);
        }

        private void UIElement_OnPreviewMouseWheel1(object sender, MouseWheelEventArgs e)
        {
            var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
            eventArg.RoutedEvent = UIElement.MouseWheelEvent;
            eventArg.Source = sender;
            ScrollViewer1.RaiseEvent(eventArg);
        }
    }
}
