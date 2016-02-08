using System.Web.Http;
using Express;
using Owin;
using StaticService.Configuration;

namespace StaticService
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();
            var contentOptions = new ContentOptions(AppSettings.Root).UseWeb();
            if (AppSettings.CultureResources.Length > 0)
            {
                contentOptions.UseCulture(AppSettings.CultureResources);
            }
            config.UseStatic(contentOptions);
            appBuilder.UseWebApi(config);
        }

    }
}
