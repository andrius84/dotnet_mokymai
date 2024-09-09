using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_8_Uzduotis.Entities
{
    public class FileModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public string FullPath { get; set; }

        public int FolderId { get; set; }
        public FolderModel Folder { get; set; }

    }
}
