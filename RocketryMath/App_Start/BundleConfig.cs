﻿using System.Web.Optimization;

namespace RocketryMath
{
    public class BundleConfig
    {
        #region Public Methods

        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(
                new ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"));

            bundles.Add(
                new ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"));

            bundles.Add(
                new ScriptBundle("~/bundles/mathjax").Include(
                    "~/Scripts/MathJax/MathJax.js"
                ));

            // Use the development version of Modernizr to develop with and learn from. Then, when
            // you're ready for production, use the build tool at https://modernizr.com to pick only
            // the tests you need.
            bundles.Add(
                new ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"));

            bundles.Add(
                new ScriptBundle("~/bundles/bootstrap").Include(
                    "~/Scripts/bootstrap.js",
                    "~/Scripts/respond.js"));

            bundles.Add(
                new StyleBundle("~/Content/css").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/site.css",
                    "~/Content/callouts.css",
                    "~/Content/navigation.css",
                    "~/Content/shop-site.css"));

            bundles.Add(
                new StyleBundle("~/bundles/fontawesome").Include(
                    "~/Content/font-awesome.min.css"
                ));
        }

        #endregion Public Methods
    }
}