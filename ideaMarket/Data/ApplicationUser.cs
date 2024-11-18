using ideaMarket.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ideaMarket.Data
{
    public class ApplicationUser: IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Address { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePicture { get; set; }

        //one user entity can have more than one investment
        //this investment property contains all the investment entities of user X 
        public ICollection<Investments> Investments { get; set; }
    }
}
