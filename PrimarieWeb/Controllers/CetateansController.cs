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
    public class CetateansController : Controller
    {
        private readonly ICetateanService _cetateanService;

        public CetateansController(ICetateanService cetateanService)
        {
            _cetateanService = cetateanService;
        }

        // GET: ShoppingCarts
        public IActionResult Index()
        {
            var users = _cetateanService.GetAll();
            return View(users);
        }

        // GET: ShoppingCarts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShoppingCarts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cetatean user)
        {
            if (ModelState.IsValid)
            {
                _cetateanService.Add(user);
                return RedirectToAction(nameof(Index));
            }

            return View(user);
        }

        // GET: ShoppingCarts/Edit/5
        public IActionResult Edit(int id)
        {
            var users = _cetateanService.GetById(id);
            if (users == null)
            {
                return NotFound();
            }

            return View(users);
        }

        // POST: ShoppingCarts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Cetatean users)
        {
            if (id != users.CetateanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _cetateanService.Update(users);
                return RedirectToAction(nameof(Index));
            }

            return View(users);
        }

        // GET: ShoppingCarts/Delete/5
        public IActionResult Delete(int id)
        {
            var users = _cetateanService.GetById(id);
            if (users == null)
            {
                return NotFound();
            }

            return View(users);
        }

        // POST: ShoppingCarts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var users = _cetateanService.GetById(id);
            if (users == null)
            {
                return NotFound();
            }

            _cetateanService.Delete(users);
            return RedirectToAction(nameof(Index));
        }
    }
}

