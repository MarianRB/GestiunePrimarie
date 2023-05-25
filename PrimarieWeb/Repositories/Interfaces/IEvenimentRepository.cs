using PrimarieWeb.Models;

namespace PrimarieWeb.Repositories.Interfaces
{
    public interface IEvenimentRepository
    {
        Eveniment? GetById(int id);
        IQueryable<Eveniment> GetAll();
        void Add(Eveniment review);
        void Update(Eveniment review);
        void Delete(Eveniment review);
        void Save();
    }
}
