using JWTMinimal.Models;

namespace JWTMinimal.Repositories
{
    public class UserRepository
    {
        //write here databse query
        public static List<User> Users = new List<User>();

        static UserRepository()
        {
            Users = new List<User>()
            {
                new() { Username="pverma", Email="pverma.gmail.com", Givenname="Prajwal", Password="PVerma", Role="Administrator", Surname="verma"},
                new() { Username="Nikki", Email="niki.gmail.com", Givenname="Nikita", Password="NIKKI", Role="Standard", Surname="Negi"}
            };
        }

    }
}
