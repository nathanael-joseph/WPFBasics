using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using WPFBasics.ViewModels;

namespace WPFBasics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Task _addCarsTask { get; set; }
        private CancellationTokenSource _cancelAddCarsSource;
        public MainViewModel Model { get; private set; }
        public MainWindow()
        {
            InitializeComponent();
            Model = new MainViewModel();
            Model.Cars.Add(new CarViewModel(DateTime.Now, "Honda", "Civic"));
            DataContext = Model;
            _cancelAddCarsSource = new CancellationTokenSource();
            _addCarsTask = AddCars(_cancelAddCarsSource.Token);

        }

        private Task AddCars(CancellationToken token)
        {
            return Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Dispatcher.BeginInvoke(() => Model.Cars.Add(new CarViewModel(DateTime.Now, "Honda", "Civic")));
                    Thread.Sleep(2000);
                }
            }, token);
        }


        private void EndTaskButton_Click(object sender, RoutedEventArgs e)
        {
            _cancelAddCarsSource.Cancel();
        }
    }
}
