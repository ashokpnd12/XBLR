using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace XBLR.UI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                                                    "~/Content/css/handsontable.full.css",
                                                    "~/Content/jsTree/themes/default-dark/style.min.css",
                                                    "~/Content/jsTree/themes/default/style.min.css",
                                                    "~/Content/css/pickaday.css",
                                                    "~/Content/css/handsontable.full.css",
                                                    "~/Content/jsTree/themes/default-dark/style.min.css"
                                                ));

            bundles.Add(new ScriptBundle("~/bundles/jquery")
               .Include(
               "~/scripts/jquery-3.3.1.min.js",
               "~/scripts/jstree.min.js",
               "~/Scripts/handsontable.full.js",
               "~/Scripts/moment.js",
               "~/Scripts/pickaday.js"
               ));
        }
    }
}