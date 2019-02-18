using System;
using DIDemo.Models;
using DIDemoServices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace DIDemo.Controllers
{
    public class DiSubScopeController : Controller
    {
        private readonly IOperationService _operationService;
        private readonly IOperationTransient _transientOperation;
        private readonly IOperationScoped _scopedOperation;
        private readonly IOperationSingleton _singletonOperation;
        private readonly IOperationSingletonInstance _singletonInstanceOperation;
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public DiSubScopeController(
            IServiceScopeFactory serviceScopeFactory,
            IOperationService operationService,
            IOperationTransient transientOperation,
            IOperationScoped scopedOperation,
            IOperationSingleton singletonOperation,
            IOperationSingletonInstance singletonInstanceOperation)
        {
            _serviceScopeFactory = serviceScopeFactory;
            _operationService = operationService;
            _transientOperation = transientOperation;
            _scopedOperation = scopedOperation;
            _singletonOperation = singletonOperation;
            _singletonInstanceOperation = singletonInstanceOperation;
        }

        public IActionResult Index()
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var diScopedModel = new DIScopedModel
                {
                    OperationService= scope.ServiceProvider.GetService<IOperationService>(),
                    TransientOperation = scope.ServiceProvider.GetService<IOperationTransient>(),
                    ScopedOperation = scope.ServiceProvider.GetService<IOperationScoped>(),
                    SingletonOperation = scope.ServiceProvider.GetService<IOperationSingleton>(),
                    SingletonInstanceOperation = scope.ServiceProvider.GetService<IOperationSingletonInstance>()
                };
            
                return View(new DISubScopedModel
                {
                    OperationService = _operationService,
                    TransientOperation = _transientOperation,
                    ScopedOperation = _scopedOperation,
                    SingletonOperation = _singletonOperation,
                    SingletonInstanceOperation = _singletonInstanceOperation,
                    DiSubScopedModel = diScopedModel
                });
               
            }
           
        }
    }
}