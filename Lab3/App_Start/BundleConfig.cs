using System.Web;
using System.Web.Optimization;

namespace Lab3
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/animation").Include(
                "~/Scripts/main.js"));

            bundles.Add(new ScriptBundle("~/bundles/interactive").Include(
                "~/Scripts/meetUs.js"));            


            bundles.Add(new StyleBundle("~/Content/commonStyles").Include(
                      "~/Content/Common/common.css",
                      "~/Content/Common/reset.css",
                      "~/Content/Common/circles.css",
                      "~/Content/Fontawesome/all.css",
                      "~/Content/Fontawesome/fontawesome.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                      "~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/overview").Include(
                "~/Content/overview.css"));

            bundles.Add(new StyleBundle("~/Content/content").Include(
                "~/Content/content.css"));

            bundles.Add(new StyleBundle("~/Content/chapterStyle").Include(
                "~/Content/Chapters/chapterStart.css"));

            bundles.Add(new StyleBundle("~/Content/inboundMarketStat").Include(
                "~/Content/Chapters/chapter1.css"));

            bundles.Add(new StyleBundle("~/Content/keyInsights1").Include(
                "~/Content/Chapters/chapter1_1.css"));

            //bundles.Add(new StyleBundle("~/Content/fontawesome").Include(
            //    "~/Content/Fontawesome/all.css",
            //    "~/Content/Fontawesome/fontawesome.css"));

            bundles.Add(new StyleBundle("~/Content/startPage").Include(
                "~/Content/title.css"));

            bundles.Add(new StyleBundle("~/Content/form").Include(
                "~/Content/formStyle.css",
                "~/Content/Common/common.css",
                "~/Content/Common/reset.css"));
        }
    }
}
