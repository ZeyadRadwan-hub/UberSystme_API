namespace UberSystem.Repo.GenericRepo.Contract
{
    public interface IGenericRepo<T> where T : class
    {
        Task CreateAsync(T item);
        void Delete(int id);
        void Edit(T item);
    }
}
