using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimizeStartup.MapperTest
{
    public class User
    {
        public User(int id, string firstName, string lastName, string emailAddress)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
        }

        public int Id { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public string EmailAddress { get; }
    }
}
