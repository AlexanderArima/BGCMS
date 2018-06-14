using System.Web.Mvc;

namespace BGCMS.Web.Areas.TS00WG
{
    public class TS00WGAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "TS00WG";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "TS00WG_default",
                "TS00WG/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}