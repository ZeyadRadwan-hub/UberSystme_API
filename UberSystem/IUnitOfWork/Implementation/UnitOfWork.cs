using UberSystem.Data;
using UberSystem.IUnitOfWork.Contract;
using UberSystem.Models;
using UberSystem.Repo.GenericRepo.Contract;

namespace UberSystem.IUnitOfWork.Implementation
{
    public class UnitOfWork : IUnitOfWork.Contract.IUnitOfWork
    {
        private readonly App_Database_Context _db;

        public IGenericRepo<Userr> User { get; }

        public IGenericRepo<Vehicle> Vehicle { get; }   
        public IGenericRepo<Payment> Payment {  get; }

        public IGenericRepo<Ride> Ride {  get; }

        public IGenericRepo<Rating> Rating {  get; }

        public async Task<int> Save()
        {
            return await _db.SaveChangesAsync();
        }


        public UnitOfWork(App_Database_Context db, IGenericRepo<Userr> user, IGenericRepo<Vehicle> vehicle, IGenericRepo<Payment> payment, IGenericRepo<Ride> ride, IGenericRepo<Rating> rating)
        {
            _db = db;
            User = user;
            Vehicle = vehicle;
            Payment = payment;
            Ride = ride;
            Rating = rating;
        }
    }
}
