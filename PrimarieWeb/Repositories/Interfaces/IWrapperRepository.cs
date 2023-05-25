namespace PrimarieWeb.Repositories.Interfaces
{
    public interface IWrapperRepository
    {
        IChatRepository Chat { get; }
     
        ICetateanRepository Cetatean { get; }
        IDocumentRepository Document { get; }
        IEvenimentRepository Eveniment { get; }
       
       // object ClientAccount { get; }

        void Save();
    }
}
