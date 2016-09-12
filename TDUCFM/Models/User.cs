using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDUCFM.Models
{
    public class User
    {
        [Key, Display(AutoGenerateField = true)]
        public long UserId { get; set; }

        [Required, StringLength(50)]
        public string UserName { get; set; }

        public int UserRole { get; set; }

        public int DepartmentId { get; set; }
    }
}
