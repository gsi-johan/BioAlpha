using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblio.Business.Mapper
{
    public class TesisDto
    {
        public string Titulo { get; set; }

        public int Año { get; set; }

        public string Autores { get; set; }

        public string Contenido { get; set; }

        public string Categoría { get; set; }
    }
}
