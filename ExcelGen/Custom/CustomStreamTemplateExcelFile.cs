using ExcelConfig;
using ExcelGen.Custom.Base;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelGen.Custom
{
    /// <summary>
    /// Example class to demo the streaming of an excel file from a template using customised data/operations
    /// </summary>
    public class CustomStreamTemplateExcelFile : StreamTemplateExcelFile
    {
        public CustomStreamTemplateExcelFile(IExcelTemplateFileConfig config) : base(config)
        {

        }

        /// <summary>
        /// Customise this method to manipulate the Excel template before streaming to client
        /// </summary>
        public override void GenerateExcel()
        {
            ExcelWorksheet worksheet = ExcelPackage.Workbook.Worksheets[1];

            // change data in excel
            worksheet.Cells[2, 1].Value = 4;

            // after changing the excel data, refresh all calculations in the excel
            ExcelPackage.Workbook.Calculate();

            // after calculation runs, get newly calculated value
            double output = Convert.ToDouble(worksheet.Cells[2, 3].Value);

            // overwrite the cell containing the embedded formula with the calculated value
            worksheet.Cells[2, 3].Value = output;

            // remove the other worksheets that depended on the formula
            ExcelPackage.Workbook.Worksheets.Delete("Sheet2");
            ExcelPackage.Workbook.Worksheets.Delete("Sheet3");
        }
    }
}
