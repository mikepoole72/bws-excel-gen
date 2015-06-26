using System.Web;
using System.Web.Optimization;

namespace BaseWebSolution
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/jquery-ui-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.unobtrusive*",
            //            "~/Scripts/jquery.validate*"));

            /*
             // unobtrusive not in RSCHDLR but globalise.js is....
              
             bundles.Add(new ScriptBundle("~/bundles/validation")                
                .Include("~/Scripts/validation/jquery.validate.js")
                .Include("~/Scripts/validation/jquery.validate.globalize.js"));
            */

            bundles.Add(new ScriptBundle("~/bundles/js")
                        .Include("~/Scripts/bootstrap/bootstrap.js")
                        .Include("~/Scripts/modernizr-2.6.2.js"));

            // REMOVED DEFAULT
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            // http://blog.falafel.com/three-steps-use-jquery-ui-asp-net-mvc-5/
            // https://jqueryui.com/autocomplete/#default

            //bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
            //            "~/Content/themes/base/jquery.ui.core.css",
            //            "~/Content/themes/base/jquery.ui.resizable.css",
            //            "~/Content/themes/base/jquery.ui.selectable.css",
            //            "~/Content/themes/base/jquery.ui.accordion.css",
            //            "~/Content/themes/base/jquery.ui.autocomplete.css",
            //            "~/Content/themes/base/jquery.ui.button.css",
            //            "~/Content/themes/base/jquery.ui.dialog.css",
            //            "~/Content/themes/base/jquery.ui.slider.css",
            //            "~/Content/themes/base/jquery.ui.tabs.css",
            //            "~/Content/themes/base/jquery.ui.datepicker.css",
            //            "~/Content/themes/base/jquery.ui.progressbar.css",
            //            "~/Content/themes/base/jquery.ui.theme.css"));

            // CssRewriteUrlTransform requires later version of System.Web.Optimization (1.1+) - it resolves the absolute paths to URLs
            bundles.Add(new StyleBundle("~/bundles/css")
                .Include("~/Content/bootstrap.css", new CssRewriteUrlTransform()));

        }
    }
}