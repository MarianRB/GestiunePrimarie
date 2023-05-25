using PrimarieWeb.Models;

namespace PrimarieWeb.Services.Interfaces
{
    public interface IDocumentService
    {
        Document? GetById(int id);
        void Add(Document document);
        void Update(Document document);
        void Delete(Document document);
        IEnumerable<Document> GetAll();
        // Other specific methods for ProductSpecification, if needed
    }
}