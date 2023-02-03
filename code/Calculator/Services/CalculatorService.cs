using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Calculator.Tests")]

namespace Calculator.Services
{
    /// <summary>
    /// Calculator service
    /// </summary>
    public class CalculatorService : ICalculatorService
    { 
        /// <summary>
        /// Method to add doubles
        /// </summary>
        /// <param name="values">The parameter list of doubles</param>
        /// <returns>The result of the addition as a double</returns>
        public double Add(params double[] values)
        {
            return values.Sum();
        }

        /// <summary>
        /// Method to divide a double by a double
        /// </summary>
        /// <param name="number">The number to divide</param>
        /// <param name="divisor">The divisor</param>
        /// <returns>The result as a double</returns>
        /// <exception cref="ArgumentException">Argument exception when the divisor is zero</exception>
        public double Divide(double number, double divisor)
        {
            if (divisor == 0) throw new ArgumentException("The divisor cannot be zero");
            return number / divisor;
        }
    }
}
