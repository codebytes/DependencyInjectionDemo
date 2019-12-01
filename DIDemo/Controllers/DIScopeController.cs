using DIDemo.Models;
using DIDemoServices.Operations.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DIDemo.Controllers
{
    public class DIScopeController : Controller
    {
        private readonly IOperationService _operationService;
        private readonly IOperationTransient _transientOperation;
        private readonly IOperationScoped _scopedOperation;
        private readonly IOperationSingleton _singletonOperation;
        private readonly IOperationSingletonInstance _singletonInstanceOperation;

        public DIScopeController(
            IOperationService operationService,
            IOperationTransient transientOperation,
            IOperationScoped scopedOperation,
            IOperationSingleton singletonOperation,
            IOperationSingletonInstance singletonInstanceOperation)
        {
            _operationService = operationService;
            _transientOperation = transientOperation;
            _scopedOperation = scopedOperation;
            _singletonOperation = singletonOperation;
            _singletonInstanceOperation = singletonInstanceOperation;
        }

        public IActionResult Index()
        {

            return View(new DIScopedModel
            {
                OperationService = _operationService,
                TransientOperation = _transientOperation,
                ScopedOperation = _scopedOperation,
                SingletonOperation = _singletonOperation,
                SingletonInstanceOperation = _singletonInstanceOperation
            });
        }
    }
}