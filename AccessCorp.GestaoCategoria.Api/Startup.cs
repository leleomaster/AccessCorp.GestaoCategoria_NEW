using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AccessCorp.GestaoCategoria.Api.Startup))]

namespace AccessCorp.GestaoCategoria.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
