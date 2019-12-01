using DIDemoServices.NoDI;
using Microsoft.AspNetCore.Mvc;

namespace DIDemo.Controllers
{
    public class NoDIClientController : Controller
    {
        public NoDIClientController()
        {

        }

        public IActionResult Delete(int id)
        {
            var clientService = new ClientService();
            clientService.Delete(id);
            return View();
        }
    }
}