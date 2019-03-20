using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MovieList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Movie> MovieList;

        public MainWindow()
        {
            InitializeComponent();

            MovieList = new ObservableCollection<Movie>();
            lvMovies.ItemsSource = MovieList;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            int year;

            try
            {
                year = int.Parse(releaseYearInput.Text);
            }
            catch (FormatException d)
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }
            

            Movie movieToAdd = new Movie(titleInput.Text, year);

            MovieList.Add(movieToAdd);

            titleInput.Clear();
            releaseYearInput.Clear();
        }

        private void AddAnimatedMovieButton_Click(object sender, RoutedEventArgs e)
        {
            int year;

            try
            {
                year = int.Parse(releaseYearInput.Text);
            }
            catch (FormatException d)
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }
            string Title = titleInput.Text;
            int Year = int.Parse(releaseYearInput.Text);
            string Studio = animationStudio.Text;
            string Type = animationType.Text;

            AnimatedMovie movieToAdd = new AnimatedMovie(Title, Year, Studio, Type);

            MovieList.Add(movieToAdd);

            titleInput.Clear();
            releaseYearInput.Clear();
            animationStudio.Clear();
            animationType.Clear();

        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie m in MovieList)
            {
                m.ShowDetails();
            }
        }

        private void lvMovies_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Movie selectedMovie = lvMovies.SelectedItem as Movie;
            if (selectedMovie != null)
            {
                selectedMovie.ShowDetails();
            }
        }
    }
}
