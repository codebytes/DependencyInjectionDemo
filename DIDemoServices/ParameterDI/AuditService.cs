using System;

namespace DIDemoServices.ParameterDI
{
    internal class AuditService : IAuditService
    {
        public AuditService()
        {
        }

        public void LogDelete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
