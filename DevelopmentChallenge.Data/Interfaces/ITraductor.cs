using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Interfaces
{
    public interface ITraductor
    {
        string TraducirForma(string claveForma, int cantidad);
        string TraducirEtiqueta(string claveEtiqueta);
    }
}
