using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ideaMarket.Models
{
    public class News
    {
        [Required]
        [Key]
        public int  NewsID { get; set; }

        public DateTime DatePosted { get; set; }

        [Required]
        [Display(Name = "News Heading")]
        public string NewsHeading { get; set; }

        [Required]
        [Display(Name = "News Text")]
        public string NewsText { get; set; }

        [Display(Name = "News Picture")]
        public string NewsPicture { get; set; }


    }
}
