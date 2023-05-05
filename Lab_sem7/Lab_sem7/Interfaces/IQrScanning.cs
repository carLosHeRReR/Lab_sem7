using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sem7.Interfaces
{
    public interface IQrScanning
    {
        Task<string> ScanAsync();
    }
}
