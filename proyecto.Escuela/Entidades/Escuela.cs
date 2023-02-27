using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        public string UniqueId { get; private set; } = Guid.NewGuid().ToString();
        string nombre;
        public string Nombre
        {
            get { return "Copia:" + nombre; }
            set { nombre = value.ToUpper(); }
        }
        public int AñoDeCreación { get; set; }

        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        public List<Curso> Cursos { get; set; }

        public Escuela(string nombre, int año) => (nombre, AñoDeCreación) = (Nombre, año);

        public Escuela(string nombre, int año, 
                       TiposEscuela tipo, 
                       string pais = "", string ciudad = "") : base()
        {
            (Nombre, AñoDeCreación) = (Nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad:{Ciudad}";
        }
    }
}





/*using System;
using System.Runtime.CompilerServices;
namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        String nombre;
        public string Nombre
        {
            get{ return "copia = "+ nombre ; }

            set{nombre = value.ToUpper() ; }
        }

       /* public string Nombre { get; set; }*/


          // propiedad objeto  o una funcion
       // public int AñoDeCreacion { get; set; }

        //public string  Pais { get; set; }

        //public string Ciudad { get; set; }

        //public TiposEscuela TiposEscuela{ get ; set;}

        //private int myVar;
        // constructor
        /*public Escuela(string nombre , int año)
        {
            this.nombre = nombre ;
            AñoDeCreacion = año;
        }

        */

        // nuevo forma de construir un conbstructoir 
        /*public Escuela(string Nombre , int año) =>(Nombre , AñoDeCreacion) = (Nombre , año);

        public List<Curso> Cursos{get; set;}
            //parametros opcionales  
        public Escuela(string Nombre , int año , 
                     TiposEscuela Tipo,
                    string Pais="",string ciudad ="")
        {
            (Nombre , AñoDeCreacion) = (Nombre , año);
             Pais = Pais;
                Ciudad = ciudad ;

        }


        public override string ToString()
        {
            return $"Nombre:\"{Nombre}\", TipoEscuela: {TiposEscuela} \nPaís: {Pais}, Ciudad: {Ciudad}";
        }
    }

     
} */
