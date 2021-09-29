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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Imagen
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

        private void uniformeRadio_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.Uniform;
        }

        private void rellenoUniformeRadio_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.UniformToFill;
        }

        private void sinAjusteRadio_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.None;
        }

        private void rellenoRadio_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.Fill;
        }

        private void opacidadAltaRadio_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 1;
        }

        private void opacidadBajaRadio_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.1;
        }

        private void opacidadMediaRadio_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.5;
        }
    }
}
