
using System.Collections.Generic;
using AutomatedReportingSystem.Business.Models;

namespace AutomatedReportingSystem.Business.Interfaces
{
    /// <summary>
    /// interface for FileOperations
    /// </summary>
    public interface IFileOperations
    {
        void InitializeProcess(string sourceDirectory);

        List<InvoiceDetails> GetFileData(string sourceDirectory);
    }
}
