using System;

namespace ProjectSpartan.Framework.Contracts
{
    public interface IDependencyResolutionService
    {
        T GetInstance<T>() where T : class;
        object GetInstance(Type type);
    }
}

