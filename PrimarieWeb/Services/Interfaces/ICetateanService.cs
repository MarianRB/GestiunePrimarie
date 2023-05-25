using PrimarieWeb.Models;

namespace PrimarieWeb.Services.Interfaces
{
    public interface ICetateanService
    {
        Cetatean? GetById(int id);
        IEnumerable<Cetatean> GetAll(); // Add the GetAll method to retrieve all products
        void Add(Cetatean cetatean);
        void Update(Cetatean cetatean);
        void Delete(Cetatean cetatean);
    }
}