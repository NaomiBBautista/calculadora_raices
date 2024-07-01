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
    /// Lógica de interacción para Newton_Raphson.xaml
    /// </summary>
    public partial class Newton_Raphson : Window
    {
        public Newton_Raphson()
        {
            InitializeComponent();
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



            double[] root = null;

            if (!double.IsNaN(coefficientD))
            {
                // Ecuación de tercer grado
                root = FindCubicRoots(coefficientA, coefficientB, coefficientC, coefficientD);
            }
            else
            {
                // Convertir ecuación de segundo grado a ecuación de tercer grado
                root = FindCubicRoots(0, coefficientA, coefficientB, coefficientC);
            }

            raices.Text = string.Join("\n", root);

            double[] FindCubicRoots(double a, double b, double c, double d)
            {
                double[] roots = new double[3];

                // Función para calcular el valor de la ecuación cúbica
                double CubicFunction(double x)
                {
                    return a * Math.Pow(x, 3) + b * Math.Pow(x, 2) + c * x + d;
                }

                // Función para calcular la derivada de la ecuación cúbica
                double CubicDerivative(double x)
                {
                    return 3 * a * Math.Pow(x, 2) + 2 * b * x + c;
                }

                // Método de Newton-Raphson para encontrar las raíces
                (double root, int iterations) NewtonRaphson(double x, double eps, int maxIte)
                {
                    double xi = x;
                    int iterations = 0;

                    while (Math.Abs(CubicFunction(xi)) > eps && iterations < maxIte)
                    {
                        xi = xi - CubicFunction(xi) / CubicDerivative(xi);
                        iterations++;
                    }

                    return (xi, iterations);
                }

                // Buscar todas las raíces
                double x0 = -5; // Valor de inicio para el método de Newton-Raphson
                double increment = 5; // Cantidad para aumentar el valor de inicio en cada iteración
                double epsilon = 0.000000000000000000001; // Tolerancia para la convergencia
                int maxIterations = 100; // Número máximo de iteraciones permitidas

                for (int i = 0; i < 3; i++)
                {
                    var result = NewtonRaphson(x0, epsilon, maxIterations);
                    roots[i] = result.root;
                    x0 += increment; // Aumentar el valor de inicio para encontrar la siguiente raíz
                    itera.Text += string.Format("Raíz encontrada: {0} en {1} iteraciones.\n", result.root.ToString("F10"), result.iterations);
                }


                return roots;
            }
        }
    }
}
