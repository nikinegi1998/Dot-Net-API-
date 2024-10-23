using JWTMinimal.Models;

namespace JWTMinimal.Services
{
    public interface IIUserServicce
    {
        public User Get(UserLogin user);
    }
}
