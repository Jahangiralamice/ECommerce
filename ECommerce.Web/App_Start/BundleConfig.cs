﻿using System.Web;
using System.Web.Optimization;

namespace ECommerce.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/css/bootstrap.min.css",
                "~/Content/css/bootstrap-select.css",
                "~/Content/css/bootstrap-datepicker3.min.css",
                "~/Content/css/font-awesome.min.css",
                "~/Content/css/icheck/blue.min.css",
                "~/Content/css/datatables/jquery.dataTables.min.css",
                "~/Content/css/AdminLTE.css",
                "~/Content/css/select2.min.css",
                "~/Content/css/custom.css",

                "~/Content/css/skins/skin-blue.css",
            "~/Content/site.css"));
        }
    }
}
