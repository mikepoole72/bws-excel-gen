using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelConfig
{
    public interface IExcelSaveTemplateFileConfig : IExcelTemplateFileConfig
    {
        string OutputFolderPath { get; set; }
        string OutputFileNameFormat { get; set; }
    }
}
