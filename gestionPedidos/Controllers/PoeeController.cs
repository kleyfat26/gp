using gestionPedidos.Models;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace gestionPedidos.Controllers
{
    public class PoeeController : Controller
    {
        private readonly gestionpedidoContext _context;
        private const int PageSize = 10;
        public PoeeController(gestionpedidoContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? i)
        {
            return View(_context.Poees.ToList().ToPagedList(i ?? 1, PageSize));
        }

        public IActionResult PoeeDetalle(string pedidoKey, int? i)
        {
            ViewBag.pedidoKey = pedidoKey;
            return View(_context.Pedidomovs.Where(p => p.PedidoKey.Equals(pedidoKey)).ToPagedList(i ?? 1, PageSize));
        }
    }
}
