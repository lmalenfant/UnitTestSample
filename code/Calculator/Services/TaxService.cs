namespace Calculator.Services
{
    /// <summary>
    /// A tax service
    /// </summary>
    public class TaxService : ITaxService
    {
        private readonly ICalculatorService _calculatorService;

        public TaxService(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        /// <summary>
        /// Method to calculate tax
        /// </summary>
        /// <param name="taxRate">Tax rate as a percentage</param>
        /// <param name="amount">Amount to be taxed</param>
        /// <returns>The amount of tax</returns>
        public double CalculateTaxes(double taxRate, double amount)
        {
            var taxMultiplier = _calculatorService.Divide(taxRate, 100);
            return taxMultiplier * amount;
        }
    }
}
