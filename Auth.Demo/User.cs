using System.Collections.Generic;

namespace Auth.Demo
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }


        private readonly IList<User> users = new List<User>
        { new User { Username= "test1", Password= "password1", Role= "User"  },
          new User { Username= "test2", Password= "password2", Role="Administrator" }
        };

    }
}