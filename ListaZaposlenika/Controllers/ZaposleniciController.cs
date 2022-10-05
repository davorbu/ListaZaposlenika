using ListaZaposlenika.Data;
using ListaZaposlenika.Models;
using Microsoft.AspNetCore.Mvc;


namespace ListaZaposlenika.Controllers
{
    public class ZaposleniciController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ZaposleniciController(ApplicationDbContext context)
        {
            _context = context;
        }   

        public IActionResult Index()
        {
            var listaZaposlenika = _context.Zapposlenici.ToList();
            return View(listaZaposlenika);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Zaposlenik zaposlenik = new Zaposlenik();
            return PartialView("_ZaposlenikModelPartial", zaposlenik);
        }



        [HttpPost]
        public IActionResult Create(Zaposlenik zaposlenici)
        {
            _context.Zapposlenici.Add(zaposlenici);
            _context.SaveChanges();
            return PartialView("_ZaposlenikModelPartial", zaposlenici);
        }



        public IActionResult Details(int id)
        {
            
           var zaposlenici = _context.Zapposlenici.Where(x => x.Id == id).FirstOrDefault();
            return PartialView("_DetailsZaposlenikModelPartial", zaposlenici);
        }
    }
}
