
using UberSystem.Data;
using UberSystem.Repo.GenericRepo.Contract;

namespace UberSystem.Repo.GenericRepo.Implementaion
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly App_Database_Context _db;
        public GenericRepo(App_Database_Context db)
        {
            _db = db;
        }

        public async Task CreateAsync(T item)
        {
            await _db.Set<T>().AddAsync(item);
        }

        public void Delete(int id)
        {
            var x = _db.Set<T>().Find(id);
            _db.Set<T>().Remove(x);
        }

        public void Edit(T item)
        {
            _db.Set<T>().Update(item);
        }
    }
}
