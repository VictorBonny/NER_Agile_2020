using System.Web;
using System.Web.Mvc;

namespace _2020_TP_PortailNER_Agile
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
