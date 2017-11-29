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

namespace _04.tekenen_2._0
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

        private void Circle_Click(object sender, RoutedEventArgs e)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Margin = new Thickness(0, 0, 150, 50);
            ellipse.Height = 100;
            ellipse.Width = 100;
            ellipse.Fill = Brushes.DarkGoldenrod;
            ellipse.Stroke = Brushes.Crimson;
            ellipse.StrokeThickness = 7;
            mainGrid.Children.Add(ellipse);
        }
        private void Circle2_Click(object sender, RoutedEventArgs e)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Margin = new Thickness(150, 0, 0, 50);
            ellipse.Height = 100;
            ellipse.Width = 100;
            ellipse.Fill = Brushes.DarkGoldenrod;
            ellipse.Stroke = Brushes.Crimson;
            ellipse.StrokeThickness = 7;
            mainGrid.Children.Add(ellipse);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rec = new Rectangle();
            rec.Fill = System.Windows.Media.Brushes.IndianRed;
            rec.Stroke = System.Windows.Media.Brushes.GreenYellow;
            rec.Height = 300;
            rec.Width = 350;
            mainGrid.Children.Add(rec);
        }

        private void Line1_Click(object sender, RoutedEventArgs e)
        {
            Line Line1 = new Line();
            Line1.Stroke = Brushes.Black;
            Line1.X1 = 150;
            Line1.X2 = 250;
            Line1.Y1 = 250;
            Line1.Y2 = 250;
            Line1.StrokeThickness = 7;
            mainGrid.Children.Add(Line1);
        }
    }
}
