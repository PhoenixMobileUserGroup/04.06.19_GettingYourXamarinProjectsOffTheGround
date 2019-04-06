using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSpartan.Business.Contracts
{
    public interface IDependencyResolutionService
    {
        T GetInstance<T>() where T : class;
        object GetInstance(Type type);
    }
}
