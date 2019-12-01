namespace DIDemoServices.ConstructorDI
{
    public class EmailProviderWrapper : IEmailProvider
    {
        public void SendDeleteConfirmation(int id)
        {
            EmailProvider.SendDeleteConfirmation(id);
        }
    }
}
