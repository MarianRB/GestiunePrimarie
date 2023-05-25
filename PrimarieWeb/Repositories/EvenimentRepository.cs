using PrimarieWeb.Models;
using PrimarieWeb.Repositories.Interfaces;

namespace PrimarieWeb.Repositories
{
    public class EvenimentRepository : IEvenimentRepository
    {
        private readonly GestiunePrimarieContext _context;

        public EvenimentRepository(GestiunePrimarieContext context)
        {
            _context = context;
        }

        public Eveniment? GetById(int id)
        {
            return _context.Eveniments.Find(id);
        }

        public void Add(Eveniment eveniment)
        {
            _context.Eveniments.Add(eveniment);
        }

        public void Update(Eveniment eveniment)
        {
            _context.Eveniments.Update(eveniment);
        }

        public void Delete(Eveniment eveniment)
        {
            _context.Eveniments.Remove(eveniment);
        }

        public IQueryable<Eveniment> GetAll()
        {
            return _context.Eveniments.AsQueryable();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
