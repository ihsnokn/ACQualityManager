using Microsoft.AspNetCore.Identity;
using QM.Entities.Interface;

namespace QM.Entities.Concrete.Users
{
    public class AppUser : IdentityUser<int>, ITable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Picture { get; set; }
        public string DepartmentName { get; set; }

        
    }
}