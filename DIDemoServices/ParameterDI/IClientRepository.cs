namespace DIDemoServices.ParameterDI
{
    public interface IClientRepository
    {
        void Delete(int id);
        void Add(string name);
    }
}