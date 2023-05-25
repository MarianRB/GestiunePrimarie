using PrimarieWeb.Models;
using PrimarieWeb.Repositories.Interfaces;

namespace PrimarieWeb.Repositories
{
    public class ChatRepository : IChatRepository
    {
        private GestiunePrimarieContext _context;

        public ChatRepository(GestiunePrimarieContext context)
        {
            _context = context;
        }

        public Chat? GetById(int id)
        {
            return _context.Chats.Find(id);
        }

        public void Add(Chat chat)
        {
            _context.Chats.Add(chat);
        }

        public void Update(Chat chat)
        {
            _context.Chats.Update(chat);
        }

        public void Delete(Chat chat)
        {
            _context.Chats.Remove(chat);
        }

        public IQueryable<Chat> GetAll()
        {
            return _context.Chats.AsQueryable();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

