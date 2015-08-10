
using System.Collections.Generic;
using AutomatedReportingSystem.Business.Models;

namespace AutomatedReportingSystem.Business.Interfaces
{
    /// <summary>
    /// interface for Data Validator
    /// </summary>
    public interface IDataValidator
    {
        List<string> ValidateCustomerNumber(List<InvoiceDetails> table);

        List<string> ValidateInvoiceNumber(List<InvoiceDetails> table);

        List<string> ValidateInvoiceAmount(List<InvoiceDetails> table);

        List<string> ValidateInvoiceDate(List<InvoiceDetails> table);
    }
}
