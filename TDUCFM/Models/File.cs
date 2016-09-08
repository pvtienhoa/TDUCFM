using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDUCFM.Models
{
    public class File
    {
        public int FileId { get; set; }
        public string AccountNo { get; set; }
        public string CifNo { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public int FolderId { get; set; }
        public int DepartmentId { get; set; }
    }
}
