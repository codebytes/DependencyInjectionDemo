using System.Threading.Tasks;

namespace DIDemoServices.Operations.Interfaces
{
    public interface IMyDependency
    {
        string GenerateMessage(string message);
    }
}