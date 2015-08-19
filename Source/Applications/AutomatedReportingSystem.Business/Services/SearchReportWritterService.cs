using AutomatedReportingSystem.Business.Interfaces;
using AutomatedReportingSystem.Business.Models;

namespace AutomatedReportingSystem.Business.Services
{
    /// <summary>
    /// Class which writes report when seach is occured.
    /// </summary>
    public class SearchReportWritterService : ISearchReportWritterService
    {
        /// <summary>
        /// Log search report
        /// </summary>
        /// <param name="clientNumber"></param>
        /// <param name="totalInvoiceAmount"></param>
        /// <param name="serviceTax"></param>
        /// <param name="educationCess"></param>
        /// <param name="foreignRemittance"></param>
        /// <param name="wireTransferCharge"></param>
        /// <returns></returns>
        public SearchReport LogSearchReport(string clientNumber, double totalInvoiceAmount, double serviceTax, double educationCess, double foreignRemittance, double wireTransferCharge)
        {
            var validReport = new SearchReport()
            {
                ClientNumber = clientNumber,
                TotalInvoiceAmount = totalInvoiceAmount,
                ServiceTax = serviceTax,
                EducationCess = educationCess,
                ForeignRemittance = foreignRemittance,
                WireTransferCharge = wireTransferCharge
            };

            return validReport;
        }
    }
}
