using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela.Clases.Jer.Clase
{
    public interface IClase
    {
        public string Name { get; }

        public List<IClase> Estudiantes { get; set; }

        public List<IClase> Profesores { get; set; }

        public void AgregarEstudiante();
        public void EliminarEstudiante();
        public void AgregarProfesor();
        public void EliminarProfesor();

        public void GetEstudiantes()
        {

        }

        public void GetProfesores()
        {

        }
    }
}
