using PrimarieWeb.Services.Interfaces;
using PrimarieWeb.Models;
using PrimarieWeb.Repositories.Interfaces;


namespace PrimarieWeb.Services
{
    public class CetateanService : ICetateanService
    {
        private readonly ICetateanRepository _userRepository;

        public CetateanService(ICetateanRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Cetatean? GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public IEnumerable<Cetatean> GetAll()
        {
            return _userRepository.GetAll();
        }

        public void Add(Cetatean product)
        {
            _userRepository.Add(product);
            _userRepository.Save();
        }

        public void Update(Cetatean product)
        {
            _userRepository.Update(product);
            _userRepository.Save();
        }

        public void Delete(Cetatean product)
        {
            _userRepository.Delete(product);
            _userRepository.Save();
        }
    }
}