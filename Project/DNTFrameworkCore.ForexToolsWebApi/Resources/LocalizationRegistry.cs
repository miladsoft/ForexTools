using Microsoft.Extensions.DependencyInjection;

namespace DNTFrameworkCore.ForexToolsWebApi.Resources
{
    public static class LocalizationRegistry
    {
        public static void AddResources(this IServiceCollection services)
        {
            services.AddSingleton<ISharedLocalizer, SharedLocalizer>();
            services.AddSingleton<IMessageLocalizer, MessageLocalizer>();
            services.AddSingleton<ILabelLocalizer, LabelLocalizer>();
        }
    }
}