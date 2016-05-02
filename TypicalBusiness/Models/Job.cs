using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TypicalBusiness.Models
{
    public class Job
    {

        public Job()
        {
            this.DateCreated = DateTime.Now;
        }
        
        [Display(Name = "JobID")]
        public int JobID { get; set; }

        [Display(Name = "JobTitle")]
        public String Title { get; set; }

        [Display(Name = "Date Posted")]
        [DisplayFormat(DataFormatString="{0:dd/MM/yyyy}")]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public String Description { get; set; }

    }
}