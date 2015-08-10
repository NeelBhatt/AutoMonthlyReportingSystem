
using AutomatedReportingSystem.Business.Models;

namespace AutomatedReportingSystem.Business.Interfaces
{
    /// <summary>
    /// interface for Datatable Operations
    /// </summary>
    public interface IDatatableOperations
    {
        InvoiceDetails CreateEmptyDataTable(string firstLine);

        InvoiceDetails AddRow(InvoiceDetails dataTable, string line);
    }
}
