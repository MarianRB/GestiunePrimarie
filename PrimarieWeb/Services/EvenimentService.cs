using PrimarieWeb.Models;
using PrimarieWeb.Repositories.Interfaces;
using PrimarieWeb.Services.Interfaces;

namespace PrimarieWeb.Services
{
    public class EvenimentService : IEvenimentService
    {
        private readonly IEvenimentRepository _evenimentRepository;

        public EvenimentService(IEvenimentRepository evenimentRepository)
        {
            _evenimentRepository = evenimentRepository;
        }

        public Eveniment? GetById(int id)
        {
            return _evenimentRepository.GetById(id);
        }

        public IEnumerable<Eveniment> GetAll()
        {
            return _evenimentRepository.GetAll();
        }

        public void Add(Eveniment eveniment)
        {
            _evenimentRepository.Add(eveniment);
            _evenimentRepository.Save();
        }

        public void Update(Eveniment eveniment)
        {
            _evenimentRepository.Update(eveniment);
            _evenimentRepository.Save();
        }

        public void Delete(Eveniment eveniment)
        {
            _evenimentRepository.Delete(eveniment);
            _evenimentRepository.Save();
        }
    }
}