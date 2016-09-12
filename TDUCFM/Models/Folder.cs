using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDUCFM.Models
{
    public class Folder
    {
        [Key, Display(AutoGenerateField = true)]
        public long FolderId { get; set; }
        
        public int FolderCode { get; set; }
    }
}
