using System;

namespace DIDemoServices.ParameterDI
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IAuditService _auditService;
        public IEmailProvider EmailProvider { get; set; }

        public ClientService(IClientRepository clientRepository, IAuditService auditService)
        {
            _clientRepository = clientRepository;
            _auditService = auditService;
        }

        public void Delete(int id)
        {
            _auditService.LogDelete(id);
            _clientRepository.Delete(id);
            EmailProvider?.SendDeleteConfirmation(id);
        }
    }
}
