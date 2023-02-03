namespace Calculator.Services
{
    public interface ICalculatorService
    {
        /// <summary>
        /// Method to add doubles
        /// </summary>
        /// <param name="values">The parameter list of doubles</param>
        /// <returns>The result of the addition as a double</returns>
        double Add(params double[] values);

        /// <summary>
        /// Method to divide a double by a double
        /// </summary>
        /// <param name="number">The number to divide</param>
        /// <param name="divisor">The divisor</param>
        /// <returns>The result as a double</returns>
        double Divide(double number, double divisor);
    }
}
