﻿using System;
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

namespace ClassesIntro
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

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog doggy = new ClassesIntro.Dog("poodle", "bob", 12);
            doggy.Bark();
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog doggy = new ClassesIntro.Dog("golden retrievers","lily",30);
            doggy.SayName();
        }
    }
}
