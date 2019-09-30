using System.Web;
using System.Web.Mvc;

namespace GlobalSuperstore_P3_27798607
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
