using UberSystem.DTOs.Auth;

namespace UberSystem.Repo.CustomRepo.Contract
{
    public interface IAuthRepo
    {
        Task<string> Login(AuthLoginDTO dto);//implement AuthDTO
    }
}
