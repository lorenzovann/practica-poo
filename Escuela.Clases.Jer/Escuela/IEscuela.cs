using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela.Clases.Jer.Escuela
{
    public interface IEscuela
    {
        public List<IEscuela> ListaDeClases { get; set;}

        void EliminarClases();
        void AgregarClases();
        void GetClases();
    }
}
