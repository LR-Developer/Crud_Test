using CrudTest.Contracts;
using System.Web.Mvc;

namespace CrudTest.Controllers
{
    public class HomeController : Controller
    {
        private ICustomerRepository _customerRepository;

        public HomeController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // GET: Home
        public ActionResult Index()
        {
            var customers = _customerRepository.Get();

            return View(customers);
        }
    }
}