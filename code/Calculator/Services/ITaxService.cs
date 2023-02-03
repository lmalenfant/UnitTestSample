namespace Calculator.Services
{
    public interface ITaxService
    {
        /// <summary>
        /// Method to calculate tax
        /// </summary>
        /// <param name="taxRate">Tax rate as a percentage</param>
        /// <param name="amount">Amount to be taxed</param>
        /// <returns>The amount of tax</returns>

        double CalculateTaxes(double taxRate, double amount);
    }
}
