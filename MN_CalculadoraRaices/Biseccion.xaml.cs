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
using System.Windows.Shapes;

namespace MN_CalculadoraRaices
{
    /// <summary>
    /// Lógica de interacción para Biseccion.xaml
    /// </summary>
    public partial class Biseccion : Window
    {

        public Biseccion()
        {
            InitializeComponent();
        }

        double f(double x, double coea, double coeb, double coec, double coed)
        {
            // Define la función que quieres encontrar sus raíces
            return coea * Math.Pow(x, 3) + coeb * Math.Pow(x, 2) + coec * x + coed;
        }

        (double root, int iterations) Bisection(double a, double b, double tolerance, double coea, double coeb, double coec, double coed)
        {
            // Implementa el método de bisección
            double c = (a + b) / 2;
            int iterations = 0;

            while (Math.Abs(f(c, coea, coeb, coec, coed)) > tolerance)
            {
                if (f(a, coea, coeb, coec, coed) * f(c, coea, coeb, coec, coed) < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }

                c = (a + b) / 2;
                iterations++;
            }

            return (root: c, iterations: iterations);
        }

        (double root, int iterations)[] FindRoots(double coea, double coeb, double coec, double coed)
        {
            // Encuentra todas las raíces de una ecuación de hasta tercer grado

            // Define el rango inicial y la tolerancia
            double a = -10;
            double b = 10;
            double tolerance = 0.00001;

            var roots = new (double root, int iterations)[3];
            int rootIndex = 0;

            double x = a;

            while (x <= b)
            {
                var result = Bisection(x, x + 1, tolerance, coea, coeb, coec, coed);
                roots[rootIndex] = result;
                rootIndex++;
                x++;
            }

            return roots;
        }


        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            string parsedCoefficientA = coeA.Text;
            double coefficientA;

            if (double.TryParse(parsedCoefficientA, out coefficientA)) { }
            else { }

            string parsedCoefficientB = coeB.Text;
            double coefficientB;

            if (double.TryParse(parsedCoefficientB, out coefficientB)) { }
            else { }

            string parsedCoefficientC = coeC.Text;
            double coefficientC;

            if (double.TryParse(parsedCoefficientC, out coefficientC)) { }
            else { }

            string parsedCoefficientD = coeD.Text;
            double coefficientD;

            if (double.TryParse(parsedCoefficientD, out coefficientD)) { }
            else { }

            double coea, coeb, coec, coed;
            if (!double.IsNaN(coefficientD))
            {
                // Ecuación de tercer grado
                coea = coefficientA;
                coeb = coefficientB;
                coec = coefficientC;
                coed = coefficientD;
            }
            else
            {
                // Convertir ecuación de segundo grado a ecuación de tercer grado
                coea = 0;
                coeb = coefficientA;
                coec = coefficientB; 
                coed = coefficientC;
            }


            // Llama a la función FindRoots y muestra los resultados
            var roots2 = FindRoots(coea, coeb, coec, coed);
            foreach (var root in roots2)
            {
                itera.Text += string.Format($"Raíz {Array.IndexOf(roots2, root) + 1}: {root.root}");
                itera.Text += string.Format($"Número de iteraciones: {root.iterations}");
            }

        }
    }
}
