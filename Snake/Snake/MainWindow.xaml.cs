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
using System.Windows.Threading;

namespace Snake
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);

            /* Here user can change the speed of the snake.
             * Possible speeds are FAST, MODERATE, SLOW and DAMNSLOW */
            timer.Interval = MODERATE;
            timer.Start();

            this.KeyDown += new KeyEventHandler(OnButtonKeyDown);
            paintSnake(startingPoint);
            currentPosition = startingPoint;

            // Instantiate Food Objects
            for (int n = 0; n < 10; n++)
            {
                paintBonus(n);
            }
        }
    }
}
