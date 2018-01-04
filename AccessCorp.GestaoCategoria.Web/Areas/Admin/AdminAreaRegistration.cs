using System.Web.Mvc;

namespace AccessCorp.GestaoCategoria.Web.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
             name: "Default_Admin",
             url: "Admin/{controller}/{action}/{id}",
             defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
             namespaces: new[] { "AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers" }
         );
        }
    }
}