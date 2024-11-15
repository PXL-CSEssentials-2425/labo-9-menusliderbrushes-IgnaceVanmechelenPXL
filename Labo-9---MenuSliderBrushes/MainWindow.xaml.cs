using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Labo_9___MenuSliderBrushes
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
        private void CloseApp(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Bent u zeker dat u de applicatie wenst af te sluiten?", "afsluiten", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
        private void MnuNumberOneClick(object sender, RoutedEventArgs e)
        {
            numberOneTextBox.Text = "2";
        }
        private void MnuNumberTwoClick(object sender, RoutedEventArgs e)
        {
            numberTwoTextBox.Text = "2";
        }

        private void NumberOneSliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            numberOneTextBox.Text = numberOneSlider.Value.ToString();
        }

        private void NumberTwoSliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            numberTwoTextBox.Text = numberTwoSlider.Value.ToString();
        }
    }
}