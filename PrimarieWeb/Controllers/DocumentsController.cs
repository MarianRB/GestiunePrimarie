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
    public class DocumentsController : Controller
    {
        private readonly IDocumentService _documentService;

        public DocumentsController(IDocumentService documentService)
        {
            _documentService = documentService;
        }

        // GET: ShoppingCarts
        public IActionResult Index()
        {
            var shoppingCarts = _documentService.GetAll();
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
        public IActionResult Create(Document document)
        {
            if (ModelState.IsValid)
            {
                _documentService.Add(document);
                return RedirectToAction(nameof(Index));
            }

            return View(document);
        }

        // GET: ShoppingCarts/Edit/5
        public IActionResult Edit(int id)
        {
            var document = _documentService.GetById(id);
            if (document == null)
            {
                return NotFound();
            }

            return View(document);
        }

        // POST: ShoppingCarts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Document document)
        {
            if (id != document.DocumentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _documentService.Update(document);
                return RedirectToAction(nameof(Index));
            }

            return View(document);
        }

        // GET: ShoppingCarts/Delete/5
        public IActionResult Delete(int id)
        {
            var document = _documentService.GetById(id);
            if (document == null)
            {
                return NotFound();
            }

            return View(document);
        }

        // POST: ShoppingCarts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var document = _documentService.GetById(id);
            if (document == null)
            {
                return NotFound();
            }

            _documentService.Delete(document);
            return RedirectToAction(nameof(Index));
        }
    }
}