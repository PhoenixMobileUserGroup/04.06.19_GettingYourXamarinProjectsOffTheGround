using ProjectSpartan.Framework.Contracts;
using SimpleInjector;

namespace ProjectSpartan.Framework.Services
{
    public class DependencyResolutionService : IDependencyResolutionService
    {
        private readonly Container _container;

        public DependencyResolutionService(Container container)
        {
            _container = container;
        }

        public T GetInstance<T>() where T : class
        {
            return _container.GetInstance<T>();
        }
    }
}