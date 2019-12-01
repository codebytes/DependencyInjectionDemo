using System.Collections.Generic;
using System.Text;

namespace DIDemoServices.NoDI
{
    public class ClientService
    {
        private ClientRepository _clientRepository;
        
        public ClientService()
        {
            //allocated in constructor but can't test or use a different repository without a code change
            _clientRepository = new ClientRepository();
        }

        public void Delete(int id)
        {
            //hidden dependency to the delete method, newed up here
            var audit = new AuditService();
            audit.LogDelete(id);
            
            _clientRepository.Delete(id);

            //a hidden static dependency, very hard to test with
            EmailProvider.SendDeleteConfirmation(id);
        }
    }
}
