using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaVirtual.Commun.SearchsTerminals
{
    public class Folder : ParentData
    {
        
        public List<Folder> Folders { get; set; }

        public List<Documents> Documents { get; set; }

        public string FolderUrl { get; set; }
    }
}
