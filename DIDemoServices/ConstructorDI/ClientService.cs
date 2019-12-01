namespace DIDemoServices.ConstructorDI
{
    public class ClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IAuditService _auditService;
        private readonly IEmailProvider _emailProvider;

        public ClientService(IClientRepository clientRepository, IAuditService auditService, IEmailProvider emailProvider)
        {
            _clientRepository = clientRepository;
            _auditService = auditService;
            _emailProvider = emailProvider;
        }

        public void Delete(int id)
        {
            _auditService.LogDelete(id);
            _clientRepository.Delete(id);
            _emailProvider.SendDeleteConfirmation(id);
        }
    }
}
