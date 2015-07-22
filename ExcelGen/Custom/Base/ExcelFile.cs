using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using ExcelConfig;

namespace ExcelGen.Base
{
    /// <summary>
    /// Container for creating the excel file details and content
    /// </summary>
    public abstract class ExcelFile : IExcelFile
    {
        // constants
        public const string ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        public const string DefaultDownloadFileName = "Results.xlsx";

        // properties
        public string FileDownloadName { get; set; }
        public string WorkbookAuthor { get; set; }
        public string WorkbookTitle { get; set; }
        public ExcelPackage ExcelPackage { get; set; }
        
        // members
        protected string ApplicationPath { get; set; }
        protected readonly string FileId = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-ms");

        public ExcelFile(IExcelFileConfig excelFileConfig)
        {
            ApplicationPath = excelFileConfig.ApplicationPath;
            FileDownloadName = excelFileConfig.FileDownloadName;
        }

        // overridable methods


        /// <summary>
        /// Setup the excel package (depends on excel template/from new)
        /// </summary>
        public virtual void Setup()
        {
            
        }

        /// <summary>
        /// Generate the excel workbook
        /// </summary>
        public virtual void GenerateExcel()
        { }
        
        public virtual void PreGenerateExcel()
        { }

        public virtual void PostGenerateExcel()
        { }
    }
}
