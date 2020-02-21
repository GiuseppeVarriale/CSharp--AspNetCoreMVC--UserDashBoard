using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace UserDashBoard.Models
{
    // Add profile data for application users by adding properties to the UserDashBoardUser class
    public class UserDashBoardUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }
    }
}
