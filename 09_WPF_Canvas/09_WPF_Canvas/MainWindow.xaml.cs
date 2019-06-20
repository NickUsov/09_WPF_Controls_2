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

namespace _09_WPF_Canvas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Canvas can = null;
        Button bt = null;
        public MainWindow()
        {
            InitializeComponent();
            can = new Canvas();
            bt = new Button();
            bt.Height = 50;
            bt.Width = 50;
            bt.MouseEnter += mouseEnter;
            can.Children.Add(bt);
            Canvas.SetTop(bt, 0);
            Canvas.SetLeft(bt, 0);
            Content = can;
        }
        public void mouseEnter(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int x = (int)(ActualHeight - bt.ActualHeight);
            Canvas.SetTop(bt, rnd.Next(0, x));
            int y = (int)(ActualWidth - bt.ActualWidth);
            Canvas.SetLeft(bt, rnd.Next(0, y));
        }
    }
}
