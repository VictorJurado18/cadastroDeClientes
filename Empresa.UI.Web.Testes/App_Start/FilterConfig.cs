using System.Web;
using System.Web.Mvc;

namespace Empresa.UI.Web.Testes
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
