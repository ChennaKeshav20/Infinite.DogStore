using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Infinite.DogStore.Models;


namespace Infinite.DogStore.Controllers
{
    public class DogStoreController : Controller
    {
        private readonly ApplicationDbContext _context = null;
        public DogStoreController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: DogStore
        public ActionResult Index()
        {
            var pets = _context.Pets.ToList();
            return View(pets);
            
        }
        public ActionResult Create()
        {
            var dogBreed=_context.DogBreeds.ToList();
            ViewBag.DogBreeds = dogBreed;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Pet pet)
        {
            if (ModelState.IsValid)
            {
                _context.Pets.Add(pet);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            var dogBreed=_context.DogBreeds.ToList();
            ViewBag.DogBreeds = dogBreed;
            return View();
        }
    }
}