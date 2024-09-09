using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Paskaita_8_Uzduotis.Entities
{
    public class FolderModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<FileModel> Files { get; set; } = new List<FileModel>();
    }
}
