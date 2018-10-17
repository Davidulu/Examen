using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Transporte: ITransporte
    {
        protected string marca = "", nombre = "", color = "";
        
        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Transporte()
        {

        }

        public Transporte(string marca, string tamaño, string color)
        {
            this.color = color;
            this.nombre = tamaño;
            this.marca = marca;
        }

        public virtual void Mover()
        {
            Console.WriteLine("El "+this.nombre+" se acaba de mover.");
        }

        public virtual void Viajar()
        {
            Console.WriteLine("Con el "+this.nombre+" puedo viajar.");
        }

        public virtual void BajarVelocidad()
        {
            Console.WriteLine("El "+this.nombre+" baja de velocidad.");
        } 
    }
}