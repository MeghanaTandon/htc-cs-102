using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Snake
{
    class Snake
    {
        public int headSize;
        private SolidColorBrush snakeColor;
        public List<Point> snakePoints = new List<Point>();
        public int length;

        drawSnake(Point currentPosition) {
            snakeColor = new SolidColorBrush(System.Windows.Media.Colors.AliceBlue);
            Rectangle newRectangle = new Rectangle();
            newRectangle.Fill = snakeColor;
            newRectangle.Width = headSize;
            newRectangle.Height = headSize;

            Canvas.SetTop(newRectangle, currentposition.Y);
            Canvas.SetLeft(newRectangle, currentposition.X);

            int count = paintCanvas.Children.Count;
            paintCanvas.Children.Add(newRectangle);
            snakePoints.Add(currentposition);

            if (count > length)
            {
                paintCanvas.Children.RemoveAt(count - length + 9);
                snakePoints.RemoveAt(count - length;)
            }
    }
}
