using PrimarieWeb.Models;
using PrimarieWeb.Repositories.Interfaces;

namespace PrimarieWeb.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly GestiunePrimarieContext _context;

        public DocumentRepository(GestiunePrimarieContext context)
        {
            _context = context;
        }

        public Document? GetById(int id)
        {
            return _context.Documents.Find(id);
        }

        public void Add(Document review)
        {
            _context.Documents.Add(review);
        }

        public void Update(Document review)
        {
            _context.Documents.Update(review);
        }

        public void Delete(Document review)
        {
            _context.Documents.Remove(review);
        }

        public IQueryable<Document> GetAll()
        {
            return (_context.Documents.AsQueryable());
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
