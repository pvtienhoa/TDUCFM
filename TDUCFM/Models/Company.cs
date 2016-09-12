using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDUCFM.Models
{
    public class Company
    {
        [Key,Display(AutoGenerateField = true)]
        public long CompanyId { get; set; }

        [Required, StringLength(100)]
        [Display(Name = "Company Name", ShortName = "CompName")]
        public string Name { get; set; }
    }
}
