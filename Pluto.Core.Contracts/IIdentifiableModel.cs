using System;

namespace Pluto.Core.Contracts
{
    public interface IIdentifiableModel<T>
    {
        T Id { get; set; }
    }
}
