using AutomatedReportingSystem.Business.Interfaces;

namespace AutomatedReportingSystem.Business.Services
{
    /// <summary>
    /// Class which represents the deduction of Education cess.
    /// </summary>
    public class EducationCessPayerService : ITaxPayerService
    {
        /// <summary>
        /// Method to deduct amount as tax.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public double DeductAmount(double amount)
        {
            return (amount * 3 / 100);
        }
    }
}
