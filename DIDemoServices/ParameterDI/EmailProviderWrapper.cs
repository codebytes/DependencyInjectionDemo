namespace DIDemoServices.ParameterDI
{
    public class EmailProviderWrapper : IEmailProvider
    {
        public void SendDeleteConfirmation(int id)
        {
            EmailProvider.SendDeleteConfirmation(id);
        }
    }
}
