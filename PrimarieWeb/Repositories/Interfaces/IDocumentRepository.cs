using PrimarieWeb.Models;

namespace PrimarieWeb.Repositories.Interfaces
{
    public interface IDocumentRepository
    {
        Document? GetById(int id);
        IQueryable<Document> GetAll();
        void Add(Document document);
        void Update(Document document);
        void Delete(Document document);
        void Save();
    }
}
