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

namespace MN_CalculadoraRaices
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNewton_Click(object sender, RoutedEventArgs e)
        {
            Newton_Raphson ventanaNewton = new Newton_Raphson();
            ventanaNewton.Show();
        }

        private void btnBiseccion_Click(object sender, RoutedEventArgs e)
        {
            Biseccion ventanaBi = new Biseccion();
            ventanaBi.Show();
        }

        private void btnPunto_Click(object sender, RoutedEventArgs e)
        {
            Punto_Fijo ventanaPunto = new Punto_Fijo();
            ventanaPunto.Show();
        }
    }
}
