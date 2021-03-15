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

namespace Square
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush costumColor;
        Random r = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddOrRemoveItems(object sender, MouseButtonEventArgs e)
        {
            if (e.OriginalSource is Rectangle)
            {
                Rectangle rectangle = (Rectangle)e.OriginalSource;

                myCanvas.Children.Remove(rectangle);
            }
            else
            {
                costumColor = new SolidColorBrush(Color.FromRgb((byte)r.Next(1,255), (byte)r.Next(1, 255), (byte)r.Next(1, 255)));
                Rectangle newrectangle = new Rectangle
                {
                    Width = 50,
                    Height = 50,
                    Fill = costumColor,
                    StrokeThickness = 3,
                    Stroke = Brushes.Black
                };

                Canvas.SetLeft(newrectangle, Mouse.GetPosition(myCanvas).X);
                Canvas.SetTop(newrectangle, Mouse.GetPosition(myCanvas).Y);

                myCanvas.Children.Add(newrectangle);
            }

        }
    }
}
