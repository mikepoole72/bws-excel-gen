using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelConfig
{
    public class ExcelSaveTemplateFileConfig : IExcelSaveTemplateFileConfig
    {
        public string TemplateFolderPath { get ; set; }

        public string TemplateFileName { get; set; }

        public string TemporaryFolderPath { get; set; }

        public string TemporaryFileNameFormat { get; set; }

        public string OutputFolderPath { get; set; }

        public string OutputFileNameFormat { get; set; }

        public string ApplicationPath { get; set; }

        public string FileDownloadName { get; set; }

        public ExcelSaveTemplateFileConfig()
        {

        }
    }
}
