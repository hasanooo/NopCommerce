using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Services.Cms;
using Nop.Services.Plugins;

namespace Nop.Plugin.Widgets.HelloWorld
{
    public class MyPluginMethood :BasePlugin, IWidgetPlugin
    {
        public bool HideInWidgetList => false;


        public Type GetWidgetViewComponent(string widgetZone)
        {
            return typeof(ExampleWidgetViewComponent);
        }
        public Task<IList<string>> GetWidgetZonesAsync()
        {
            return Task.FromResult<IList<string>>(new List<string> { "home_page_before_categories" });
        }

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
