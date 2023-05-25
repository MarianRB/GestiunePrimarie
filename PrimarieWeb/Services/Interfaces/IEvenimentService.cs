using PrimarieWeb.Models;

namespace PrimarieWeb.Services.Interfaces
{
    public interface IEvenimentService
    {
        Eveniment? GetById(int id);
        void Add(Eveniment eveniment);
        void Update(Eveniment eveniment);
        void Delete(Eveniment eveniment);
        IEnumerable<Eveniment> GetAll();
        // Other specific methods for ProductSpecification, if needed
    }
}