using PrimarieWeb.Models;

namespace PrimarieWeb.Repositories.Interfaces
{
    public interface ICetateanRepository 
    {
        Cetatean? GetById(int id);
        IQueryable<Cetatean> GetAll();
        void Add(Cetatean cetatean);
        void Update(Cetatean cetatean);
        void Delete(Cetatean cetatean);
        void Save();
    }
}