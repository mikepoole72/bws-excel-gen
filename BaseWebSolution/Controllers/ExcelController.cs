using ExcelConfig;
using ExcelGen.Base;
using ExcelGen.Custom;
using ExcelGen.Custom.Base;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseWebSolution.Controllers
{
    public class ExcelController : Controller
    {
        //
        // GET: /Excel/

        public ActionResult Index(int id)
        {
            ActionResult result = View();


            // set the configuration for injecting into the excel generator 
            ExcelTemplateFileConfig config = new ExcelTemplateFileConfig
            {
                ApplicationPath = HttpContext.Server.MapPath("~"),
                TemplateFolderPath = ConfigurationManager.AppSettings["ExcelTemplateFolder"].ToString(),
                TemplateFileName = ConfigurationManager.AppSettings["ExcelTemplateFileName"].ToString(),
                TemporaryFolderPath = ConfigurationManager.AppSettings["ExcelTempFolder"].ToString(),
                TemporaryFileNameFormat = ConfigurationManager.AppSettings["ExcelTempFileNameFormat"].ToString(),
                FileDownloadName = ExcelFile.DefaultDownloadFileName
            };

            // set the configuration for injecting into the excel generators (includes save to location)
            ExcelSaveTemplateFileConfig configSave = new ExcelSaveTemplateFileConfig
            {
                ApplicationPath = HttpContext.Server.MapPath("~"),
                TemplateFolderPath = ConfigurationManager.AppSettings["ExcelTemplateFolder"].ToString(),
                TemplateFileName = ConfigurationManager.AppSettings["ExcelTemplateFileName"].ToString(),
                TemporaryFolderPath = ConfigurationManager.AppSettings["ExcelTempFolder"].ToString(),
                TemporaryFileNameFormat = ConfigurationManager.AppSettings["ExcelTempFileNameFormat"].ToString(),
                FileDownloadName = ExcelFile.DefaultDownloadFileName,
                OutputFolderPath = ConfigurationManager.AppSettings["ExcelOutputFolder"].ToString(),
                OutputFileNameFormat = ConfigurationManager.AppSettings["ExcelOutputFileNameFormat"].ToString()
            };

            
            

            TemplateExcelFile templateExcelFile;

            switch (id)
            {
                case 1:
                    using (templateExcelFile = new CustomSaveTemplateExcelFile(configSave))
                    {
                        templateExcelFile.Setup();
                    }
                    ViewBag.Message = String.Format("The excel file was saved to {0}", ((SaveTemplateExcelFile)templateExcelFile).OutputFilePath);
                    break;

                case 2:
                    using (templateExcelFile = new CustomStreamTemplateExcelFile(config))
                    {
                        templateExcelFile.Setup();
                        result = File(((StreamTemplateExcelFile)templateExcelFile).FileAsByteArray, ExcelFile.ContentType, templateExcelFile.FileDownloadName);
                    }
                    
                    break;

                default:
                    ViewBag.Message = String.Format("There was no excel file for id = {0}.", id);
                    break;
            }

            return result;

        }

    }
}
