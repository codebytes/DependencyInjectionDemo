using System;

namespace DIDemoServices.Operations.Interfaces
{
    public interface IOperation
    {
        Guid OperationId { get; }
    }
}