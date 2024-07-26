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

namespace WpfApp4
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            labelR.Content = sliderR.Value.ToString();
            labelG.Content = sliderG.Value.ToString();
            labelB.Content = sliderB.Value.ToString();
        }


        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateBackgroundColor();
        }

        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateBackgroundColor();

        }

        private void Slider_ValueChanged_2(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateBackgroundColor();
        }

        private void UpdateBackgroundColor()
        {
            byte valueR = (byte)(sliderR.Value);
            byte valueG = (byte)(sliderG.Value);
            byte valueB = (byte)(sliderB.Value);

            labelR.Content = sliderR.Value.ToString();
            labelG.Content = sliderG.Value.ToString();
            labelB.Content = sliderB.Value.ToString();

            Back.Background = new SolidColorBrush(Color.FromRgb(valueR, valueG, valueB));

            if (btnOriginal.IsChecked == true)
            {
                Back.Background = new SolidColorBrush(Color.FromRgb(valueR, valueG, valueB));
            }
            else if (btnGray.IsChecked == true)
            {
                byte gray = (byte)((valueR + valueG + valueB) / 3);
                Back.Background = new SolidColorBrush(Color.FromRgb(gray, gray, gray));
            }
            else if (btnInvert.IsChecked == true)
            {
                Back.Background = new SolidColorBrush(Color.FromRgb((byte)(255 - valueR), (byte)(255 - valueG), (byte)(255 - valueB)));
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            UpdateBackgroundColor();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            UpdateBackgroundColor();
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            UpdateBackgroundColor();
        }
    }
}