using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Tren : Transporte
    {
        public override void Mover()
        {
            base.Mover();
            Console.WriteLine("El llamado " + this.nombre + " se acaba de mover");
        }
    }
}