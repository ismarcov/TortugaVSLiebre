using Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(MvcMovie.Startup))]
namespace MvcMovie.Hubs
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)            
        {
            //app.MapSignalR();
            app.MapSignalR(new HubConfiguration() { EnableJSONP = true });
        }
    }
    
}
