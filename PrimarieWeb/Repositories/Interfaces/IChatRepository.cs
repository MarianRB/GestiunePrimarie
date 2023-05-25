using PrimarieWeb.Models;

namespace PrimarieWeb.Repositories.Interfaces
{
    public interface IChatRepository
    {
        Chat? GetById(int id);
        void Add(Chat clientAccount);
        void Update(Chat clientAccount);
        void Delete(Chat clientAccount);
        void Save();
        public IQueryable<Chat> GetAll();
        // Alte metode specifice ClientAccount, dacă este necesar
    }
}
