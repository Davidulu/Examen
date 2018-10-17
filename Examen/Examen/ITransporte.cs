using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    interface ITransporte
    {
        string Marca { get; set; }
        string Nombre { get; set; }
        string Color { get; set; }

        void Mover();
        void Viajar();
        void BajarVelocidad();
    }
}