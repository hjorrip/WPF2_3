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
using System.Windows.Shapes;

namespace WPF2_3
{
    /// <summary>
    /// Interaction logic for ChangeDogWindow.xaml
    /// </summary>
    public partial class ChangeDogWindow : Window
    {
        Dog d = new Dog();

        public ChangeDogWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dog temp = (Dog)App.Current.Properties["selecteddog"];
            temp.Name = d.Name;
            temp.Age = d.Age;
            temp.Breed = d.Breed;
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Dog temp = (Dog)App.Current.Properties["selecteddog"];
            d.Name = temp.Name;
            d.Age = temp.Age;
            d.Breed = temp.Breed;
            this.DataContext = d;



         //   d = (Dog)App.Current.Properties["selecteddog"];
         // this.DataContext = d;
        }
    }
}
