using PrimarieWeb.Models;
using PrimarieWeb.Repositories.Interfaces;

namespace PrimarieWeb.Repositories
{
    public class WrapperRepository : IWrapperRepository
    {
        private readonly GestiunePrimarieContext _context;
        private IChatRepository? _chat;
      
        private ICetateanRepository? _cetatean;
        private IDocumentRepository? _document;
        private IEvenimentRepository? _eveniment;


        public WrapperRepository(GestiunePrimarieContext context)
        {
            _context = context;
        }

        public IChatRepository Chat
        {
            get
            {
                if (_chat == null)
                {
                    _chat = new ChatRepository(_context);
                }
                return _chat;
            }
        }

        public IDocumentRepository Document
        {
            get
            {
                if (_document == null)
                {
                    _document = new DocumentRepository(_context);
                }
                return _document;
            }
        }

        public IEvenimentRepository Eveniment
        {
            get
            {
                if (_eveniment == null)
                {
                    _eveniment = new EvenimentRepository(_context);
                }
                return _eveniment;
            }
        }

        public ICetateanRepository Cetatean
        {
            get
            {
                if (_cetatean == null)
                {
                    _cetatean = new CetateanRepository(_context);
                }
                return _cetatean;
            }
        }

      


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
    //    public IClientAccountRepository ClientAccounts => ClientAccount;
    //    public IOrderItemRepository OrderItems => OrderItem;
    //    public IProductRepository Products => Product;
    //    public IProductSpecificationRepository ProductSpecifications => ProductSpecification;
    //    public IReviewRepository Reviews => Review;
    //    public IShoppingCartRepository ShoppingCarts => ShoppingCart;
    //    public ISupplierRepository Suppliers => Supplier;

    //    object IRepositoryWrapper.ClientAccount => throw new NotImplementedException();
    //}
