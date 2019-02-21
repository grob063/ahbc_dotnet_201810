using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using Ahbc.SampleLab.eCommerce.Models;
using Ahbc.SampleLab.eCommerce.Services;

namespace Ahbc.SampleLab.eCommerce.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        // GET: Products
        public async Task<ActionResult> Index()
        {
            return View(await _service.Get());
        }

        // GET: Products/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Product product = await _service.Get(id.Value);
            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }

        public ActionResult Create(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ViewData["Id"] = id;

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Inventory inventory)
        {
            await _service.UpdateInventory(inventory);
            return RedirectToAction("Details", new {Id = inventory.ID });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _service.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
