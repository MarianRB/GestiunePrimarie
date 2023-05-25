using PrimarieWeb.Models;
using PrimarieWeb.Repositories.Interfaces;
using PrimarieWeb.Services.Interfaces;

namespace PrimarieWeb.Services
{
    public class ChatService : IChatService
    {
        private readonly IChatRepository _chatRepository;

        public ChatService(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }
        public Chat? GetById(int id)
        {
            return _chatRepository.GetById(id);
        }

        public IEnumerable<Chat> GetAll()
        {
            return _chatRepository.GetAll();
        }

        public void Add(Chat product)
        {
            _chatRepository.Add(product);
            _chatRepository.Save();
        }

        public void Update(Chat product)
        {
            _chatRepository.Update(product);
            _chatRepository.Save();
        }

        public void Delete(Chat product)
        {
            _chatRepository.Delete(product);
            _chatRepository.Save();
        }
    }
}