using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF2_3
{
    class DogOwner
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public ObservableCollection<Dog> Dogs { get; set; }

        public DogOwner()
        {
            this.Dogs = new ObservableCollection<Dog>();
        }

    }
}
