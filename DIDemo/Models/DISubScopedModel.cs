﻿using DIDemoServices.Operations.Interfaces;

namespace DIDemo.Models
{
    public class DISubScopedModel
    {
        public IOperationService OperationService { get; set; }
        public IOperationTransient TransientOperation { get; set; }
        public IOperationScoped ScopedOperation { get; set; }
        public IOperationSingleton SingletonOperation { get; set; }
        public IOperationSingletonInstance SingletonInstanceOperation { get; set; }
        public DIScopedModel DiSubScopedModel { get; set; }
    }
}
