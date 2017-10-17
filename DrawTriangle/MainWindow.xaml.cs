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

namespace DrawTriangle
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

        private void draw_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            DrawTriangle(Convert.ToInt32(xCoo.Text), Convert.ToInt32(xCoo2.Text), Convert.ToInt32(yCoo.Text), Convert.ToInt32(yCoo2.Text));
        }

        private void DrawTriangle(int x1, int x2, int y1, int y2)
        {
            DrawLine(x1, x2, x1, y2);
            DrawLine(x1, y2, y1, y2);
            DrawLine(x1, x2, y1, y2);

        }

        private void DrawLine(int x1, int x2, int y1, int y2)
        {
            Line line = new Line();
            line.X1 = x1;
            line.Y1 = x2;
            line.X2 = y1;
            line.Y2 = y2;
            line.Stroke = Brushes.Black;

            canvas.Children.Add(line);
        }
    }
}
