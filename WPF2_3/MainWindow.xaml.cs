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

namespace WPF2_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<DogOwner> DogOwners = new ObservableCollection<DogOwner>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Seed();

            CollectionViewSource DogOwnerViewSource = new CollectionViewSource();
            DogOwnerViewSource.Source = DogOwners;

            this.DataContext = DogOwnerViewSource;


        }

        public void Seed()
        {
            DogOwner do1 = new DogOwner()
            {
                Name = "Sigurjón Sveinsson",
                Email = "siggi@gmail.com"
            };

            DogOwner do2 = new DogOwner()
            {
                Name = "Hanna Ólafsdóttir",
                Email = "hanna@dog.is"
            };


            Dog dog1 = new Dog()
            {
                Name = "Snati",
                Breed = "Poodle",
                Age = 3
            };

            Dog dog2 = new Dog()
            {
                Name = "Brútus",
                Breed = "Labrador",
                Age = 5
            };

            do2.Dogs.Add(dog1);
            do2.Dogs.Add(dog2);

            DogOwners.Add(do1);
            DogOwners.Add(do2);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
