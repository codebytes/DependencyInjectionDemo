using System.Threading.Tasks;
using DIDemoServices.Interfaces;
using Microsoft.Extensions.Configuration;

namespace DIDemoServices
{
    public class MyDependency : IMyDependency
    {
        private readonly string _configuredMessage;
        public MyDependency(IConfiguration config)
        {
            _configuredMessage = config["MyStringKey"];
        }

        public string GenerateMessage(string message)
        {
            return $"{_configuredMessage} - {message}";
        }
    }
}
