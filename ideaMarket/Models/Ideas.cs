using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ideaMarket.Models
{
    public class Ideas
    {
        //Basic Details
        [Key]
        [Required]
        [Display(Name = "Idea ID")]
        public int IdeaId { get; set; }

        [Required]
        [Display(Name = "Date Lauched")]
        public DateTime DateLaunched { get; set; }

        [Required]
        [Display(Name = "Idea Owner")]
        public string IdeaOwner { get; set; }

        [Required]
        [Display(Name = "Idea Name")]
        public string IdeaName { get; set; }

        [Required]
        [Display(Name = "Team Size")]
        public int TeamSize { get; set; }

        [Required]
        [Display(Name = "Idea Sector")]
        public string IdeaSector { get; set; }

        [Required]
        [Display(Name = "Idea Criteria")]
        public string IdeaCriteria { get; set; }

        [Required]
        [Display(Name = "Idea Summary")]
        public string IdeaSummary { get; set; }


        //Contact Details
        [Required]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }

        [Required]
        [Display(Name = "Company Email")]
        public string CompanyEmail { get; set; }

        [Required]
        [Display(Name = "Company Address")]
        public string CompanyAddress { get; set; }

        
        [Display(Name = "Other Contact Details")]
        public string OtherContactDetails { get; set; }

        //Financial Details
        [Required]
        [Display(Name = "Minimum Capital")]
        public int MinimumCapital { get; set; }

        [Required]
        [Display(Name = "Maximum Capital")]
        public int MaximumCapital { get; set; }

        [Required]
        [Display(Name = "Justify Capital")]
        public string JustifyCapital { get; set; }
        

        //File Uploads       
        [Display(Name = "Idea Plan")]
        public string IdeaPlan { get; set; }

        [Display(Name = "Idea Picture")]
        public string IdeaPicture { get; set; }

        [Required]
        [Display(Name = "Idea Status")]
        public string Status { get; set; }

        
        [Display(Name = "Idea Grade")]
        public string ideaGrade { get; set; }

        //1 idea entity can be seen in more than one investment entities.
        //icollection of investments contains all the investments entitities within a specified student entity
        public  ICollection<Investments> Investments { get; set; }
    }
}
