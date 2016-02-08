using System.Configuration;

namespace StaticService.Configuration
{
    public class GlobalSection : ConfigurationSection
    {
        [ConfigurationProperty("url", IsRequired = true)]
        public string Url => (string)this["url"];


        [ConfigurationProperty("serviceName", IsRequired = true)]
        public string ServiceName => (string)this["serviceName"];

        [ConfigurationProperty("displayName", IsRequired = true)]
        public string DisplayName => (string)this["displayName"];

        [ConfigurationProperty("description", IsRequired = true)]
        public string Description => (string)this["description"];

        [ConfigurationProperty("root", IsRequired = true)]
        public string Root => (string)this["root"];

        [ConfigurationProperty("cultureResources", IsRequired = false)]
        public string CultureResources => (string)this["cultureResources"];
    }
}