using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CallViewerData.Extensions
{
    public static class HtmlExtensions
    {

        public static MvcHtmlString DisplayWithBreaksFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            var metadata = ModelMetadata.FromLambdaExpression(expression, html.ViewData);
            var model = html.Encode(metadata.Model).Replace("\n", "<br />\r\n");

            if (String.IsNullOrEmpty(model))
                return MvcHtmlString.Empty;

            return MvcHtmlString.Create(model);
        }

        public static MvcHtmlString Display100<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            var metadata = ModelMetadata.FromLambdaExpression(expression, html.ViewData);
            var model = html.Encode(metadata.Model);
                                                      
            if (String.IsNullOrEmpty(model))
            return MvcHtmlString.Empty;

            if (model.Length > 100)             
            for (int i = 100; i <= model.Length; i++)
            {
                    if (model.Length - i > 0)
                    {         
                        
                        if (Char.ToString(model[i]) == " ")
                        {
                            model = model.Insert(i, "<br />");
                            i += 100;
                            i = i.Round(100);
                        }
                        if(((double)i/100) % 1 > 0.15)
                        {
                            model = model.Insert(i, "<br />");
                            i += 100;
                            i = i.Round(100);
                        }
                    }
            }

            return MvcHtmlString.Create(model);
        }

    }

    public static class HtmlHelpers
    {
        public static IHtmlString ReplaceBreaks(this HtmlHelper helper, string str)
        {
            return MvcHtmlString.Create(str.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None).Aggregate((a, b) => a + "<br />" + b));
        }
    }
}
