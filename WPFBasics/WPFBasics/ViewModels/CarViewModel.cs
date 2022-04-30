using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBasics.ViewModels
{
    public class CarViewModel : ViewModelBase
    {
        public DateTime ModelDate { get; }

        private string? _manufacturer;
        public string? Manufacturer
        {
            get { return _manufacturer; }
            set 
            { 
                _manufacturer = value; 
                OnPropertyChanged(nameof(Manufacturer)); 
            }
        }

        private string? _model;
        public string? Model
        {
            get { return _model; }
            set
            {
                _model = value;
                OnPropertyChanged(nameof(Manufacturer));
            }
        }

        private string? _description;
        public string? Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }




        public CarViewModel(DateTime modelDate)
        {
            ModelDate = modelDate;
        }

        public CarViewModel(DateTime modelDate, string manufacturer, string model)
        : this(modelDate)
        { 
            Manufacturer = manufacturer;
            Model = model;  
        }

        public override string ToString() => $"{Manufacturer} - {Model} - {ModelDate:Y}";

    }
}
