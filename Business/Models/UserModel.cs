using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    // Model that inherits from another model.
    public class UserModel : UserModelSafe
    {
        public Guid Id { get; set; }
        //public string Name { get; set; } = "";
        //public string Email { get; set; } = "";
        public string Password { get; set; } = "";

    }
    // A "safe" model that doesnt include id/password.
    public class UserModelSafe
    {
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";

    }
}
