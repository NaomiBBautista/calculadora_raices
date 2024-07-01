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
    public partial class Punto_Fijo : Window
    {
        public Punto_Fijo()
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

            // Punto inicial
            double x0 = -10;

            // Precisión deseada
            double epsilon = 0.00000000001;

            // Número máximo de iteraciones
            int maxIterations = 1000;

            try
            {
                int iterations;
                double root = FixedPoint(coea, coeb, coec, coed, x0, epsilon, maxIterations, out iterations);
                itera.Text = string.Format("Raíz encontrada en x = {0}", root);
                itera.Text += Environment.NewLine;
                itera.Text += string.Format("Número de iteraciones: {0}", iterations);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Función de ecuación cúbica f(x) = ax^3 + bx^2 + cx + d
        double Function(double a, double b, double c, double d, double x)
        {
            return a * Math.Pow(x, 3) + b * Math.Pow(x, 2) + c * x + d;
        }

        // Función de punto fijo g(x) = x + h(x)
        double FixedPointFunction(double a, double b, double c, double d, double x)
        {
            // Definir la función h(x) en términos de la ecuación original
            // Aquí puedes experimentar con diferentes funciones h(x) para mejorar la convergencia
            return -Function(a, b, c, d, x) / (3 * a * Math.Pow(x, 2) + 2 * b * x + c);
        }

        // Implementación del método de punto fijo
        double FixedPoint(double a, double b, double c, double d, double x0, double epsilon, int maxIterations, out int iterations)
        {
            double x = x0;
            iterations = 0;

            while (iterations < maxIterations)
            {
                double nextX = FixedPointFunction(a, b, c, d, x);

                if (Math.Abs(nextX - x) < epsilon)
                {
                    return nextX;
                }

                x = nextX;
                iterations++;
            }

            throw new InvalidOperationException("El método de punto fijo no converge después de las iteraciones máximas.");
        }
    }
}
