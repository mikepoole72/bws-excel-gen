using ExcelConfig;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelGen.Base
{
    public class TemplateExcelFile : ExcelFile, IDisposable
    {
        

        protected FileInfo TempTemplateFile;
        protected string _outputFilePath;
        protected IExcelTemplateFileConfig _config;
        
        public TemplateExcelFile(IExcelTemplateFileConfig config) : base(config)
        {
            _config = config;
            DuplicateTemplateFile();
        }

        /// <summary>
        /// Makes a copy of the template file to ensure user loads their own copy
        /// </summary>
        private void DuplicateTemplateFile()
        {
            string templateFilePath = Path.Combine(ApplicationPath, _config.TemplateFolderPath, _config.TemplateFileName);
            FileInfo templateFileInfo = new FileInfo(templateFilePath);
            TempTemplateFile = templateFileInfo.CopyTo(Path.Combine(ApplicationPath, _config.TemporaryFolderPath, String.Format(_config.TemporaryFileNameFormat, FileId)));
        }

        /// <summary>
        /// Setup the excel package and execute pre-gen, gen and post-gen methods
        /// </summary>
        public override void Setup()
        {
            using (ExcelPackage = new ExcelPackage(TempTemplateFile))
            {
                PreGenerateExcel();
                GenerateExcel();
                PostGenerateExcel();
            }
        }

        public void Dispose()
        {
            if (TempTemplateFile != null)
            {
                TempTemplateFile.Delete();
            }
        }
    }
}
