using FirsPracticeBlazor.Data;

namespace FirsPracticeBlazor.Services
{
    public  class UserService
    {
        private static readonly List<User> Users = new List<User>()
        {
            new User("Bulat", "Shaykhutdinov", 18),
            new User("Roman", "Vasil'ev", 17),
            new User("Riyaz", "Zaripov", 18),
            new User("Shamil", "Sharipov", 18)
        };

        public Task<User[]> GetUsers()
        {
            var users = new List<User>();
            for (int i = 0; i < Random.Shared.Next(1, 10); ++i)
            {
                users.Add(Users[Random.Shared.Next(0, Users.Count - 1)]);
            }

            return Task.FromResult(users.ToArray());
        }

    }
}
