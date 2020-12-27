﻿using System.Web;
using System.Web.Optimization;

namespace Woodable.Web
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
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/ion.rangeSlider.js",
                      "~/Scripts/magnific-popup.js",
                      "~/Scripts/owl.carousel.js",
                      "~/Scripts/tilt.jquery.js",
                      "~/Scripts/jquery.easypiechart.js",
                      "~/Scripts/bigtext.js",
                      "~/Scripts/main.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/animate.css",
                      "~/Content/font-awesome.css",
                      "~/Content/ion-range-slider.css",
                      "~/Content/linear-icons.css",
                      "~/Content/magnific-popup.css",
                      "~/Content/owl.carousel.css",
                      "~/Content/theme.css"
                      ));
        }
    }
}
