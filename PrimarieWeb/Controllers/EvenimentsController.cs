using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrimarieWeb.Models;
using PrimarieWeb.Services.Interfaces;

namespace PrimarieWeb.Controllers
{
    public class EvenimentsController : Controller
    {
        private readonly IEvenimentService _evenimentService;

        public EvenimentsController(IEvenimentService documentService)
        {
            _evenimentService = documentService;
        }

        // GET: ShoppingCarts
        public IActionResult Index()
        {
            var shoppingCarts = _evenimentService.GetAll();
            return View(shoppingCarts);
        }

        // GET: ShoppingCarts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShoppingCarts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Eveniment eveniment)
        {
            if (ModelState.IsValid)
            {
                _evenimentService.Add(eveniment);
                return RedirectToAction(nameof(Index));
            }

            return View(eveniment);
        }

        // GET: ShoppingCarts/Edit/5
        public IActionResult Edit(int id)
        {
            var eveniment = _evenimentService.GetById(id);
            if (eveniment == null)
            {
                return NotFound();
            }

            return View(eveniment);
        }

        // POST: ShoppingCarts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Eveniment eveniment)
        {
            if (id != eveniment.EvenimentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _evenimentService.Update(eveniment);
                return RedirectToAction(nameof(Index));
            }

            return View(eveniment);
        }

        // GET: ShoppingCarts/Delete/5
        public IActionResult Delete(int id)
        {
            var eveniment = _evenimentService.GetById(id);
            if (eveniment == null)
            {
                return NotFound();
            }

            return View(eveniment);
        }

        // POST: ShoppingCarts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var eveniment = _evenimentService.GetById(id);
            if (eveniment == null)
            {
                return NotFound();
            }

            _evenimentService.Delete(eveniment);
            return RedirectToAction(nameof(Index));
        }
    }
}