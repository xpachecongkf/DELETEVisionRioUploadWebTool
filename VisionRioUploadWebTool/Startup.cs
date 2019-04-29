using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;

[assembly: OwinStartup(typeof(VisionRioUploadWebTool.Startup))]
namespace VisionRioUploadWebTool
{

    public class Startup
    {
        // Any connection or hub wire up and configuration should go here

        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}