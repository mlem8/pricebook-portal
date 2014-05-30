using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PricebookPortal_MVC.DAL;
using PricebookPortal_MVC.Models;

namespace PricebookPortal_MVC.Controllers
{
    public class PricebookController : Controller
    {
        private IPricebookRepository _pricebookRepository;

        public PricebookController()
        {
            _pricebookRepository = new PricebookRepository();
        }

        public PricebookController(IPricebookRepository repository)
        {
            _pricebookRepository = repository;
        }

        public ActionResult Index()
        {
            return View();
        }
	}
}