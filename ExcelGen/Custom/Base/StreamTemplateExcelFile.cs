using ExcelConfig;
using ExcelGen.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelGen.Custom.Base
{
    public class StreamTemplateExcelFile: TemplateExcelFile, IDisposable
    {
        public byte[] FileAsByteArray { get; set; }

        public StreamTemplateExcelFile(IExcelTemplateFileConfig config): base(config)
        {

        }

        public override void PostGenerateExcel()
        {
            FileAsByteArray = ExcelPackage.GetAsByteArray();
        }
    }
}
