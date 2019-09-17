using DIDemoServices.Interfaces;

namespace DIDemo.Models
{
    public class DIScopedModel
    {
        public IOperationService OperationService { get; set; }
        public IOperationTransient TransientOperation { get; set; }
        public IOperationScoped ScopedOperation { get; set; }
        public IOperationSingleton SingletonOperation { get; set; }
        public IOperationSingletonInstance SingletonInstanceOperation { get; set; }
    }
}
