using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelConfig
{
    public interface IExcelTemplateFileConfig : IExcelFileConfig
    {
        string TemplateFolderPath { get; set; }
        string TemplateFileName { get; set; }
        string TemporaryFolderPath { get; set; }
        string TemporaryFileNameFormat { get; set; }
        
    }
}
