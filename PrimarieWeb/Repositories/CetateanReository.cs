using PrimarieWeb.Models;
using PrimarieWeb.Repositories.Interfaces;
using System.Linq;

namespace PrimarieWeb.Repositories
{
    public class CetateanRepository : ICetateanRepository
    {
        private readonly GestiunePrimarieContext _context;

        public CetateanRepository(GestiunePrimarieContext context)
        {
            _context = context;
        }

        public Cetatean? GetById(int id)
        {
            return _context.Cetateans.Find(id);
        }

        public void Add(Cetatean user)
        {
            _context.Cetateans.Add(user);
        }

        public void Update(Cetatean user)
        {
            _context.Cetateans.Update(user);
        }

        public void Delete(Cetatean user)
        {
            _context.Cetateans.Remove(user);
        }

        public IQueryable<Cetatean> GetAll()
        {
            return _context.Cetateans.AsQueryable();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
