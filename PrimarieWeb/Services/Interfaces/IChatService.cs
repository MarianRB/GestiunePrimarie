using PrimarieWeb.Models;

namespace PrimarieWeb.Services.Interfaces
{
    public interface IChatService
    {
        Chat? GetById(int id);

        IEnumerable<Chat> GetAll();
        void Add(Chat chat);
        void Update(Chat chat);
        void Delete(Chat chat);

        //IEnumerable<Chat> GetAll();
        
        
    }
}