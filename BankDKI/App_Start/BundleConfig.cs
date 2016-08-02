using System.Web;
using System.Web.Optimization;

namespace BankDKI
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/js/lib").Include(
                        "~/Content/scripts/lib/jquery.min.js",
                        "~/Content/scripts/lib/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/js/global").Include(
                        "~/Content/scripts/nav.js"));

            bundles.Add(new ScriptBundle("~/js/creditAnalysis").Include(
                "~/Content/scripts/creditAnalysis.js"));

            bundles.Add(new ScriptBundle("~/js/sensitivityAnalysis").Include(
                "~/Content/scripts/sensitivityAnalysis.js"));

            bundles.Add(new ScriptBundle("~/js/login").Include(
                "~/Content/scripts/login.js"));

            bundles.Add(new ScriptBundle("~/js/clientSelect").Include(
                "~/Content/scripts/clientSelect.js"));

            bundles.Add(new StyleBundle("~/css/lib").Include(
                        "~/Content/styles/lib/bootstrap.min.css"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/styles/css/main.css"));

            bundles.Add(new StyleBundle("~/css/logIn").Include(
                        "~/Content/styles/css/logIn.css"));

            bundles.Add(new StyleBundle("~/css/clientSelect").Include(
                        "~/Content/styles/css/clientSelect.css"));

            bundles.Add(new StyleBundle("~/css/financialInfo").Include(
                        "~/Content/styles/css/financialInfo.css"));

            bundles.Add(new StyleBundle("~/css/financialProjection").Include(
                        "~/Content/styles/css/financialProjection.css"));

            bundles.Add(new StyleBundle("~/css/accountingInfo").Include(
                        "~/Content/styles/css/accountingInfo.css"));

            bundles.Add(new StyleBundle("~/css/sensitivity").Include(
                        "~/Content/styles/css/sensitivity.css"));

            bundles.Add(new StyleBundle("~/css/creditAnalysis").Include(
                        "~/Content/styles/css/creditAnalysis.css"));

            bundles.Add(new StyleBundle("~/css/industryComparison").Include(
                        "~/Content/styles/css/industryComparison.css"));

            bundles.Add(new StyleBundle("~/css/fsStandAlone").Include(
                        "~/Content/styles/css/fsStandAlone.css"));

            bundles.Add(new StyleBundle("~/css/fsCombination").Include(
                        "~/Content/styles/css/fsCombination.css"));

            bundles.Add(new StyleBundle("~/css/scfDirectMethod").Include(
                        "~/Content/styles/css/scfDirectMethod.css"));

            bundles.Add(new StyleBundle("~/css/financialRatios").Include(
                        "~/Content/styles/css/financialRatios.css"));

            bundles.Add(new StyleBundle("~/css/sensitivityScenarioAnalysis").Include(
                        "~/Content/styles/css/sensitivityScenarioAnalysis.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            BundleTable.EnableOptimizations = false;
        }
    }
}