using System.Web.Http;
using Ap.Express.Host.Configuration;
using Owin;

namespace Ap.Express.Host
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
