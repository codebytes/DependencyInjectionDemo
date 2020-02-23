namespace DIDemoServices.ParameterDI
{
    public interface IEmailProvider
    {
        void SendDeleteConfirmation(int id);
    }
}
