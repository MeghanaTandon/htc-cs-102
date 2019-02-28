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
        public List<Movie> movieList;

        public MainWindow()
        {
            InitializeComponent();

            movieList = new List<Movie>();
        }

        private void textBoxTitle_TextChanged(object sender, TextChangedEventArgs e)
        { 

        }

        private void buttonAddMovie_Click(object sender, RoutedEventArgs e)
        {
            Movie addMovie = new MovieList.Movie(textBoxTitle.Text, Int32.Parse(textBoxRelease.Text), textBoxDirector.Text, textBoxGenre.Text, Int32.Parse(textBoxRelease.Text));
            movieList.Add(addMovie);
            textBoxRelease.Text = String.Empty;
            textBoxTitle.Text = String.Empty;
            textBoxDirector.Text = String.Empty;
            textBoxGenre.Text = String.Empty;
            textBoxLength.Text = String.Empty;
        }

        private void buttonShowMovie_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Movie movie in movieList
                )
            {
                sb.Append(movie.ShowMovieInfo() + "\n");
            }
            MessageBox.Show(sb.ToString());
        }
    }
}
