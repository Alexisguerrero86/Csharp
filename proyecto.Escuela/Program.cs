using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {


            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
            Printer.Beep(10000, cantidad: 10);
            ImprimirCursosEscuela(engine.Escuela);




            /*var escuela = new Escuela("idat",1996,TiposEscuela.Primaria,
                    ciudad:"Bogota"  
                         );

            escuela.Cursos = new List<cursos>(){
                    new cursos(){ Nombre = "101", Jornada = TiposJornada.Mañana },
                    new cursos() {Nombre = "201", Jornada = TiposJornada.Mañana},
                    new cursos{Nombre = "301", Jornada = TiposJornada.Mañana}
            };

            escuela.Cursos.Add(new cursos(){Nombre="222",Jornada=TiposJornada.Tarde});
            escuela.Cursos.Add(new cursos(){Nombre="252",Jornada=TiposJornada.Tarde});


            var  otraColeccion = new List<cursos>(){
                            new cursos(){ Nombre = "701", Jornada = TiposJornada.Mañana },
                    new cursos() {Nombre = "401", Jornada = TiposJornada.Mañana},
                    new cursos{Nombre = "601", Jornada = TiposJornada.Mañana}
            };

           // cursos tmp = new cursos{Nombre = "1011--vacacional",Jornada=TiposJornada.Tarde};


            escuela.Cursos.AddRange(otraColeccion); 
            //escuela.Cursos.Add(tmp);
            //otraColeccion.Clear(); elimanos  un coleccion
            // elimar un elemento  

            ImprimirCursosEscuela(escuela);

           // WriteLine("cursos.Hash"+tmp.GetHashCode());

            WriteLine("==========");

            ImprimirCursosEscuela(escuela);


           //  Predicate<cursos> miAlgoritmo = Predicado;

           // exprecion  lambda
            escuela.Cursos.RemoveAll((cursos cur) => cur.Nombre == "201" && cur.Jornada == TiposJornada.Mañana);


            // delegado
            escuela.Cursos.RemoveAll(delegate(cursos cur)
            {
                    return cur.Nombre =="701";
            });


            WriteLine("========");

            ImprimirCursosEscuela(escuela);
             */





            /* var arregloCursos = new cursos[3] {

             new cursos(){Nombre = "302"},
             new cursos(){Nombre = "201"},
             new cursos{Nombre ="301"}

             };*/

            //escuela.cursos = arregloCursos;

            /*Console.WriteLine(escuela);
            Console.WriteLine("===============");
            Console.WriteLine(arregloCursos[0].Nombre +","+arregloCursos[0].UniqueId);

            Console.WriteLine(arregloCursos[1].Nombre +","+arregloCursos[1].UniqueId);
            Console.WriteLine(arregloCursos[2].Nombre +","+arregloCursos[2].UniqueId);/


            System.Console.WriteLine("======while=========");
           
            ImprimirCursosWhile(arregloCursos);

            System.Console.WriteLine("=======dowhile====");
            ImprimirCursosDoWhile(arregloCursos);

            System.Console.WriteLine("======== for=======");
            ImprimirCursosFor(arregloCursos);*/
        }

        /*  private static bool Predicado(cursos curobj)
        // predicado me estraga  un  true  si se encuentra  dicha exprecion en la coleccion 
        //"301 "
        {
            return curobj.Nombre == "601";
        } */

        private static void ImprimirCursosEscuela(Escuela escuela)
        {

            Printer.WriteTitle("Cursos de la Escuela");


            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, Id  {curso.UniqueId}");
                }
            }
        }

        /*
    private static void ImprimirCursosWhile(cursos[] arregloCursos)
    {
        int contador= 0;
        while (contador < arregloCursos.Length)
        {




            WriteLine(arregloCursos[contador].Nombre+" "+ arregloCursos[contador].UniqueId);
            contador++;
        }


    }

    private static void ImprimirCursosDoWhile(cursos[] arregloCursos)
    {
        int contador= 0;
        do
        {



            WriteLine(arregloCursos[contador].Nombre+" "+ arregloCursos[contador].UniqueId);
            contador++;

        }while (contador < arregloCursos.Length);


    }

    private static void ImprimirCursosFor(cursos[] arregloCursos)
    {

        for ( int contador =0; contador < arregloCursos.Length; contador++)
        {



            WriteLine(arregloCursos[contador].Nombre+" "+ arregloCursos[contador].UniqueId);

        }



    }

     private static void ImprimirCursosFore(cursos[] arregloCursos)
    {

       foreach (var cursos in arregloCursos)
       {

         WriteLine(cursos.Nombre+" "+ cursos.UniqueId);

       }



    }*/


    }

}


