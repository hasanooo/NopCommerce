using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Services.Plugins;

namespace Nop.Plugin.Widgets.HelloWorld
{
    public class MyPluginMethood :BasePlugin
    {

        public override async Task InstallAsync()
        {
            await base.InstallAsync();
        }
         public override async Task UninstallAsync()
        {
            await base.UninstallAsync();
        }

    }
}
