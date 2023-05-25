using PrimarieWeb.Models;
using PrimarieWeb.Repositories.Interfaces;
using PrimarieWeb.Services.Interfaces;

namespace PrimarieWeb.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IDocumentRepository _documentRepository;

        public DocumentService(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }

        public Document? GetById(int id)
        {
            return _documentRepository.GetById(id);
        }

        public IEnumerable<Document> GetAll()
        {
            return _documentRepository.GetAll();
        }

        public void Add(Document product)
        {
            _documentRepository.Add(product);
            _documentRepository.Save();
        }

        public void Update(Document product)
        {
            _documentRepository.Update(product);
            _documentRepository.Save();
        }

        public void Delete(Document product)
        {
            _documentRepository.Delete(product);
            _documentRepository.Save();
        }
    }
}