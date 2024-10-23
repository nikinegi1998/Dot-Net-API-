using JWTMinimal.Models;

namespace JWTMinimal.Repositories
{
    public class MovieRepository
    {
        public static List<Movie> Movies = new List<Movie>()
        {
            new() { Id = 1, Title = "Eternals", Description = "In the Marvel Universe, the Eternals are an offshoot of humanity known as Homo immortalis which were created one million years ago by the enigmatic alien Celestials to defend Earth with their superhuman powers and abilities.", Rating = 6.7 },
            new() { Id = 2, Title = "Dune", Description = "A dune is a mound, ridge, or hill made of sand that forms when wind or water moves sand into a sheltered area.", Rating = 8.2 },
            new() { Id = 3, Title = "The harder they fall", Description = "Gunning for revenge, outlaw Nat Love saddles up with his gang to take down enemy Rufus Buck, a ruthless crime boss who just got sprung from prison.", Rating = 6.6 },
            new() { Id = 4, Title = "Red Notice", Description = "Red Notice is a 2021 Netflix movie about an Interpol agent, the FBI's top profiler, and the world's most wanted art thief", Rating = 6.4 },
            new() { Id = 5, Title = "No time to die", Description = "No Time to Die is a 2021 spy film and the 25th installment in the James Bond series", Rating = 7.4 }
        };
    }
}
