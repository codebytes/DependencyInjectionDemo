namespace DIDemoServices.ConstructorDI
{
    public interface IEmailProvider
    {
        void SendDeleteConfirmation(int id);
    }
}
