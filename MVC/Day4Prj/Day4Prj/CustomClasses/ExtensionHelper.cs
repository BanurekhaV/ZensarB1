using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day4Prj.CustomClasses
{
    public static class ExtensionHelper
    {
        public static IHtmlString LabelWithRed(this HtmlHelper helper, string content)
        {
            string htmlstr = String.Format("<Label><i><font color=Red>{0}</font></i></Label>", content);
            return new HtmlString(htmlstr);
        }

        public static IHtmlString LabelWithGreen(this HtmlHelper helper, string content)
        {
            string htmlstr = String.Format("<Label><i><font color=green>{0}</font></i></Label>", content);
            return new HtmlString(htmlstr);
        }
    }
}