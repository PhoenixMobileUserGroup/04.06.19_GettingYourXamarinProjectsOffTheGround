using ProjectSpartan.Framework.Contracts;
using ProjectSpartan.Framework.Services;
using SimpleInjector;

namespace ProjectSpartan.UI.StartUp
{
    public static class IOCConfigurationHelper
    {
        public static Container GetRegisteredContainer()
        {
            Container container = new Container();
            RegisterServices(container);
            RegisterRepositories(container);
            return container;
        }

        private static void RegisterServices(Container container)
        {
            container.RegisterSingleton<IDependencyResolutionService>(() => new DependencyResolutionService(container));
        }

        private static void RegisterRepositories(Container container)
        {

        }
    }
}
