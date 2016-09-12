using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDUCFM.Models
{
    public class Department
    {
        [Key, Display(AutoGenerateField = true)]
        public long DeptId { get; set; }

        [Required, StringLength(100)]
        [Display(Name = "Department Name", ShortName = "DeptName")]
        public string Name { get; set; }

        [Display(Name = "Department Code", ShortName = "DeptCode")]
        public int DeptCode { get; set; }
    }
}
