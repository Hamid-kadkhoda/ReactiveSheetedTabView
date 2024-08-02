using Microsoft.Extensions.DependencyInjection;

namespace System.ReactiveSheetedTabView

{
    public static class Dependency
    {
        public static void AddReactiveSheetedTabView(this IServiceCollection services)
        {
            services.AddSingleton<ReactiveTabSheetManager>();
        }
    }
}
