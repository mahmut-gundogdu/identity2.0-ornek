using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using identitySample.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;

//[assembly: OwinStartup(typeof(identitySample.App_Start.Startup))]

namespace identitySample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<DataContext>(() => new DataContext());
            app.CreatePerOwinContext<UserManagerApp>(Create);
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }

        public  UserManagerApp Create(IdentityFactoryOptions<UserManagerApp> identitiyFactorOptions, Microsoft.Owin.IOwinContext owinContext)
        {
            DataContext db = owinContext.Get<DataContext>();
            UserManagerApp user = new UserManagerApp(new UserStore<Kullanici>(db));

            return user;
        }


    }
}
