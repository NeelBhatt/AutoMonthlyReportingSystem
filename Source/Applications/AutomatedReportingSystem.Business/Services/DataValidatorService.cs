using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedReportingSystem.Business.Interfaces;
using AutomatedReportingSystem.Business.Models;

namespace AutomatedReportingSystem.Business.Services
{
    /// <summary>
    /// Class which represents validation of the application
    /// </summary>
    public class DataValidatorService : IDataValidator
    {
        /// <summary>
        /// Method to validate customer name.
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public List<string> ValidateCustomerNumber(List<InvoiceDetails> table)
        {
            return table != null
                ? table.Where(x => !x.ClientNumber.Contains('D') && !x.ClientNumber.Contains('I'))
                    .Select(y => y.InvoiceNumber)
                    .ToList()
                : null;
        }

        /// <summary>
        /// Method to validate invoice number
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public List<string> ValidateInvoiceNumber(List<InvoiceDetails> table)
        {
            return table != null
                ? table.GroupBy(x => x.InvoiceNumber).SelectMany(grp => grp.Skip(1)).Select(x => x.InvoiceNumber).ToList() :
            null;
        }

        /// <summary>
        /// Method to validate invoice amount
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public List<string> ValidateInvoiceAmount(List<InvoiceDetails> table)
        {
            return table != null ? table.Where(x => x.InvoiceAmount < 0).Select(y => y.InvoiceNumber).ToList() : null;
        }

        /// <summary>
        /// Method to validate invoice date
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public List<string> ValidateInvoiceDate(List<InvoiceDetails> table)
        {
            return table != null
                ? table.Where(x => x.InvoiceDate == DateTime.MinValue).Select(y => y.InvoiceNumber).ToList()
                : null;
        }
    }
}

