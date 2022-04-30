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
        private CarViewModel? _selectedCar;
        public CarViewModel? SelectedCar 
        {
            get => _selectedCar;
            set
            {
                _selectedCar = value;
                OnPropertyChanged(nameof(SelectedCar));
            }
        }
        public MainViewModel()
        {
            Cars = new ObservableCollection<CarViewModel>();
        }
    }
}
