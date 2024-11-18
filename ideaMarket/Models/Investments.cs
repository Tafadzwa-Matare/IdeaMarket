using ideaMarket.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ideaMarket.Models
{
    public class Investments
    {
        [Key]
        [Required]
        [Display(Name = "Invesments ID")]
        public int InvestimentID { get; set; }

        [Required]
        [Display(Name = "Investor ID")]
        public string InvestorID { get; set; }

        [Required]
        [Display(Name = "Investor Name")]
        public string InvestorName { get; set; }

        [Required]
        [Display(Name = "Investor Surname")]
        public string InvestorSurname { get; set; }

        [Required]
        [Display(Name = "Investor Email")]
        public string InvestorEmail { get; set; }

        [Required]
        [Display(Name = "Idea ID")]
        public int IdeaID { get; set; }

        [Required]
        [Display(Name = "Invesment Amount")]
        public int InvestmentAmount { get; set; }

        [Required]
        [Display(Name = "Date Invested")]
        public DateTime DateInvested { get; set; }

        [Required]
        [Display(Name = "Due Date")]
        public DateTime DateDue { get; set; }


        [Required]
        [Display(Name = "Committed To Investment")]
        public string CommitedToInvestment { get; set; }

        public Ideas Ideas { get; set; }
   


    }
}
