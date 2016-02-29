using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TypicalBusiness.Models
{
    public class Job
    {
        
        public int JobID { get; set; }
        
        public String Title { get; set; }

        [DataType(DataType.MultilineText)]
        public String Description { get; set; }
    }
}