using System;

namespace ProjectSpartan.Business.Contracts
{
    public interface IDependencyResolutionService
    {
        T GetInstance<T>() where T : class;
        object GetInstance(Type type);
    }
}
