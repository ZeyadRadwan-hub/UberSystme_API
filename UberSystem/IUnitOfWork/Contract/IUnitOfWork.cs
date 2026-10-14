using UberSystem.Models;
using UberSystem.Repo.GenericRepo.Contract;

namespace UberSystem.IUnitOfWork.Contract
{
    public interface IUnitOfWork
    {
        IGenericRepo<Userr> User { get; }
        IGenericRepo<Vehicle> Vehicle { get; }
        IGenericRepo<Payment>Payment { get; }
        IGenericRepo<Ride> Ride { get; }
        IGenericRepo<Rating> Rating { get; }

        Task<int> Save();

    }
}
