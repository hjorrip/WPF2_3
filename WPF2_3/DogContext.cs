using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF2_3
{
    class DogContext
    {
        public static ObservableCollection<DogOwner> DogOwners = new ObservableCollection<DogOwner>();
    }
}
