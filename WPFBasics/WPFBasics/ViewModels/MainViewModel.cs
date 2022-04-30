using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBasics.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<CarViewModel> Cars { get; private set; }
        
        public MainViewModel()
        {
            Cars = new ObservableCollection<CarViewModel>();
        }
    }
}
