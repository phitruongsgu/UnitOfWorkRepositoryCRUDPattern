namespace UnitofWorkRepositoryCRUDPattern.Interfaces
{
    public interface IUnitOfWork
    {
        ICityRepository CityRepository { get; }
        Task<int> SaveChangesAsync();
    }
}
