using System.Windows;
using VolumeEngine.ViewModel;

namespace CubeIntersection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CubeView : Window
    {
        private readonly CubeViewModel _viewModel = new CubeViewModel();
        public CubeView()
        {
            InitializeComponent();
            DataContext = _viewModel;
        }

        private void OnClick_CalculateValues(object sender, RoutedEventArgs e)
        {
            _viewModel.Calculate();
        }
    }
}
