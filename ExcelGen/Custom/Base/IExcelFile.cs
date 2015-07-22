using System;
namespace ExcelGen.Base
{
    public interface IExcelFile
    {
        string FileDownloadName { get; set; }
        string WorkbookAuthor { get; set; }
        string WorkbookTitle { get; set; }

        void GenerateExcel();
    }
}
