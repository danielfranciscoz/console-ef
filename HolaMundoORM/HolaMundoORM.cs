

using System;
using System.Collections.Generic;
using System.Linq;
using HolaMundoORM.Database;
using HolaMundoORM.Models;

namespace HolaMundoORM{

    public class HolaMundoORM{
        public HolaMundoORM()
        {
            
        }

        public void ObtenerPreguntas(){

            dbContext baseDatos = new dbContext();

            //Select * from 
            List<TbPregunta> preguntas = baseDatos.TbPreguntas.ToList();

           

            //Order

            //Select personalizado

            //Insert

            //Update

            //Delete

            //Ejecucion de SP

            foreach (var item in preguntas)
            {
                Console.Write("Pregunta "+ item.Pregunta);
                Console.Write("Puntaje "+ item.Puntaje);
                Console.WriteLine();
            }
            Console.WriteLine("Hello World!");

            /*
            Investigar
            Consutlas con Where
            Realizar Insert, update
            Con linq 
            */
        }

        public void ObtenerPreguntas(int numero){
             dbContext baseDatos = new dbContext();

              //Where
              List<TbPregunta> preguntas = baseDatos.TbPreguntas.Where(w => w.Numero == numero).ToList();

                foreach (var item in preguntas)
            {
                Console.Write("Pregunta "+ item.Pregunta);
                Console.Write("Puntaje "+ item.Puntaje);
                Console.WriteLine();
            }
            Console.WriteLine("Hello World!");
        }
    }
}