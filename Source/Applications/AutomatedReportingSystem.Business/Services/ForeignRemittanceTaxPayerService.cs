using AutomatedReportingSystem.Business.Interfaces;

namespace AutomatedReportingSystem.Business.Services
{
    /// <summary>
    /// Class which represents the deduction of Foreign Remittance tax.
    /// </summary>
    public class ForeignRemittanceTaxPayerService : ITaxPayerService
    {
        /// <summary>
        /// Method to deduct amount as tax
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public double DeductAmount(double amount)
        {
            return (amount * 5 / 100);
        }
    }
}
