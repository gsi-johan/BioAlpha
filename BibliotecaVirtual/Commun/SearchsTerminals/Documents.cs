using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaVirtual.Commun.SearchsTerminals
{
  public  class Documents : ParentData
    {

        public string Url { get; set; }

        public List<KeyWords> Resolutions { get; set; }
    }
}
