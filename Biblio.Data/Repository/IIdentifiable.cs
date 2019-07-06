using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Biblio.Data.Repository
{
    public interface IIdentifiable
    {
        long id { get; }
    }
}
