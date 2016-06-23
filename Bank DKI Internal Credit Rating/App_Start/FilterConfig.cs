using System.Web;
using System.Web.Mvc;

namespace Bank_DKI_Internal_Credit_Rating
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}