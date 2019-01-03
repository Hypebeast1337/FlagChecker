using System.Web.Optimization;

namespace CodeRepository.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jvectormap").Include(
                        "~/Scripts/jquery-jvectormap-2.0.3.js",
                        "~/Scripts/jvector/jquery-jvectormap-world-mill.js",
                        "~/Scripts/jvector/gdp-data.js"));

            bundles.Add(new ScriptBundle("~/bundles/Scripts").Include(
                        "~/Scripts/simplebar.js",
                        "~/Scripts/angular.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/jvectormap/jquery-jvectormap-2.0.3.css",
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/custom.css",
                      "~/Content/simplebar.css",
                      "~/Content/normalize.css",
                      "~/Content/font-awesome-4.7.0/css/font-awesome.css"));
        }
    }
}