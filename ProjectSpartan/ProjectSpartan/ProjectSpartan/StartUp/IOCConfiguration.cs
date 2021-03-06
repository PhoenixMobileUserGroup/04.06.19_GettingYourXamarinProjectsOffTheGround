﻿using ProjectSpartan.Business.Contracts;
using ProjectSpartan.Business.Services;
using ProjectSpartan.UI.Navigation.Contracts;
using ProjectSpartan.UI.Navigation.Services;
using SimpleInjector;

namespace ProjectSpartan.UI.StartUp
{
    public static class IOCConfiguration
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
            container.RegisterSingleton<INavigationService, NavigationService>();
        }

        private static void RegisterRepositories(Container container)
        {

        }
    }
}
