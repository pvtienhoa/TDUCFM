using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDUCFM.Models
{
    public class File
    {
        [Key, Display(AutoGenerateField = true)]
        public long FileId { get; set; }

        [StringLength(13)]
        [Display(Name = "Account Number", ShortName = "AccNo")]
        public string AccountNo { get; set; }

        [Required, StringLength(9)]
        [Display(Name = "Cif Number", ShortName = "CifNo")]
        public string CifNo { get; set; }

        [Required, StringLength(100)]
        [Display(Name = "Customer Name", ShortName = "CustName")]
        public string Name { get; set; }

        public long CompanyId { get; set; }
        public long FolderId { get; set; }
        public long DepartmentId { get; set; }
    }
}
