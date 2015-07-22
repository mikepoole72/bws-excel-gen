using ExcelConfig;
using ExcelGen.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelGen.Custom.Base
{
    public class SaveTemplateExcelFile : TemplateExcelFile
    {
        /// <summary>
        /// Saved template path
        /// </summary>
        public string OutputFilePath
        {
            get
            {
                return Path.Combine(_config.ApplicationPath, _configSave.OutputFolderPath, string.Format(_configSave.OutputFileNameFormat, FileId));
            }
        }

        protected IExcelSaveTemplateFileConfig _configSave;

        public SaveTemplateExcelFile(IExcelSaveTemplateFileConfig config) : base(config)
        {
            _configSave = config;
        }
        public override void PostGenerateExcel()
        {
            ExcelPackage.SaveAs(new FileInfo(OutputFilePath)); 
        }
        
    }
}
