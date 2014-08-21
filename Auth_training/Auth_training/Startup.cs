using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Auth_training;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AngularJSAuthentication.API.Startup))]
namespace AngularJSAuthentication.API
{
    public class Startup
    {
        public void COnfiguration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}