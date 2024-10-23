using JWTMinimal.Models;
using JWTMinimal.Repositories;

namespace JWTMinimal.Services
{
    public class UserService : IIUserServicce
    {
        public User Get(UserLogin user)
        {
            User user1 = UserRepository.Users.FirstOrDefault(o => o.Username.Equals(user.Username, StringComparison.OrdinalIgnoreCase) && o.Password.Equals(user.Password) );
            return user1;
        }
    }
}
