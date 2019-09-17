using System.Threading.Tasks;

namespace DIDemoServices.Interfaces
{
    public interface IMyDependency
    {
        string GenerateMessage(string message);
    }
}