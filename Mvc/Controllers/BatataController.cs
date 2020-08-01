using Domain.Model.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers
{
    public class BatataController : Controller
    {
        private readonly IBatataService _batataService;

        public BatataController(
            IBatataService batataService)
        {
            _batataService = batataService;
        }

        public string VenderBatata(int quantidade)
        {
            var resultado = _batataService.VenderBatata(quantidade);

            return resultado;
        }
    }
}
