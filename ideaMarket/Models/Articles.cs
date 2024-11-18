using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ideaMarket.Models
{
    public class Articles
    {
        [Required]
        [Key]
        public int ArticleID { get; set; }

        public DateTime DatePosted { get; set; }

        [Required]
        [Display(Name = "Article Heading")]
        public string ArticleHeading { get; set; }

        [Required]
        [Display(Name = "Article Text")]
        public string ArticleText { get; set; }

        [Display(Name = "Article Picture")]
        public string ArticlePicture { get; set; }
    }
}
