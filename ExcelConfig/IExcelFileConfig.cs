using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelConfig
{
    public interface IExcelFileConfig
    {
        string ApplicationPath { get; set; }
        string FileDownloadName { get; set; }
    }
}
