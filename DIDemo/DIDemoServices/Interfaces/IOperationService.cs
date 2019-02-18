namespace DIDemoServices.Interfaces
{
    public interface IOperationService
    {
        IOperationTransient TransientOperation { get; }
        IOperationScoped ScopedOperation { get; }
        IOperationSingleton SingletonOperation { get; }
        IOperationSingletonInstance SingletonInstanceOperation { get; }
    }
}