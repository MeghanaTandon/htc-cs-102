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

namespace PolymorphismIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Animal> Animals;
        public MainWindow()
        {
            InitializeComponent();
            Animals = new ObservableCollection<Animal>();

            // Define some animals
            Frog frog = new Frog(4, "Kermit", false, 8);
            Dog dog = new Dog("Muppet", 20, "Rolf", 24);
            Duck duck = new Duck(9, "Donald", 15);
            Dog dog2 = new Dog("Mutt", 200, "Clifford", 1000);
            Duck duck2 = new Duck(5, "Daffy", 60);
            Frog frog2 = new Frog(3, "Jeremiah", false, 15);

            // Add the animals to the list
            Animals.Add(frog);
            Animals.Add(dog);
            Animals.Add(duck);
            Animals.Add(frog2);
            Animals.Add(dog2);
            Animals.Add(duck2);

            lvAnimals.ItemsSource = Animals;
        }

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog dog = new Dog();
            dog.Bark();
        }

        private void Quack_Button_Click(object sender, RoutedEventArgs e)
        {
            Duck duck = new Duck();
            duck.Quack();
        }

        private void Ribbit_Button_Click(object sender, RoutedEventArgs e)
        {
            Frog frog = new Frog();
            frog.Ribbit();
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Animal a in Animals)
            {
                a.SayName();
            }
        }

        private void lvAnimals_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Animal selectedAnimal = lvAnimals.SelectedItem as Animal;
            if (selectedAnimal != null)
            {
                selectedAnimal.ShowInfo();
            }
        }
    }
}

