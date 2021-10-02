

using System;
using System.Collections.Generic;
using System.Linq;
using HolaMundoORM.Database;
using HolaMundoORM.Models;
using Models;

namespace HolaMundoORM
{

    public class HolaMundoORM
    {

        private readonly dbContext baseDatos = new dbContext();

        public HolaMundoORM()
        {

        }

        public void ObtenerSelectPersonalizado()
        {
            //Select personalizado

            var datos = baseDatos.TbPreguntas.Select(w => new Preguntas()
            {
                Puntaje = w.Puntaje,
                Pregunta = w.Pregunta
            }).ToList();

            foreach (Preguntas p in datos)
            {

                Console.Write(" Pregunta " + p.Pregunta);
                Console.Write(" Puntaje " + p.Puntaje);
                Console.WriteLine();
            }

        }

        public void ObtenerPreguntas()
        {

            //Select * from 
            // List<TbPregunta> preguntas = baseDatos.TbPreguntas.ToList();

            //Order
            List<TbPregunta> preguntas = baseDatos.TbPreguntas.OrderBy(w => w.IdRubro).ToList();

            foreach (var item in preguntas)
            {
                ImprimirPregunta(item);
            }

            //Insert

            //Update

            //Delete

            //Ejecucion de SP

        }

        public void InsertarPregunta()
        {

            using (var transaccion = baseDatos.Database.BeginTransaction())
            {
                try
                {
                    TbPregunta pregunta = new TbPregunta();

                    pregunta.IdRubro = 22;
                    pregunta.Numero = 58;
                    pregunta.Pregunta = "Todo bien?";
                    pregunta.Puntaje = 40;
                    pregunta.Estado = true;
                    pregunta.UsuarioGrabacion = 123;
                    pregunta.FechaGrabacion = DateTime.Now;
                    pregunta.UsuarioModificacion = 123;
                    pregunta.FechaModificacion = DateTime.Now;

                    baseDatos.TbPreguntas.Add(pregunta);

                    TbProtagonista protagonista = new TbProtagonista()
                    {
                        Nombres = "John",
                        Apellidos = "Doe",
                        FechaNacimiento = DateTime.Parse("01-01-1991"),
                        Sexo = false,
                        Estado = true,
                        IdDepartamento = 12,
                        Correo = "asds@sada.com"

                    };

                    baseDatos.TbProtagonistas.Add(protagonista);


                    baseDatos.SaveChanges();

                    transaccion.Commit();
                    Console.WriteLine("Se ha insertado la informacion");
                }
                catch (Exception e)
                {

                    Console.WriteLine("Ocurrio un error " + e.Message);
                    transaccion.Rollback();
                }


            }

        }

        public void ObtenerPreguntas(int numero)
        {

            //Where
            List<TbPregunta> preguntas = baseDatos.TbPreguntas.Where(w => w.Numero == numero).ToList();

            foreach (var item in preguntas)
            {
                ImprimirPregunta(item);
            }

        }

        public void ObtenerUnRegistro(int puntaje)
        {
            TbPregunta pregunta = baseDatos.TbPreguntas.FirstOrDefault(w => w.Puntaje == puntaje);

            ImprimirPregunta(pregunta);
        }

        private void ImprimirPregunta(TbPregunta pregunta)
        {

            Console.Write("Id " + pregunta.IdPregunta);
            Console.Write(" Rubro " + pregunta.IdRubro);
            Console.Write(" Pregunta " + pregunta.Pregunta);
            Console.Write(" Puntaje " + pregunta.Puntaje);
            Console.WriteLine();
        }

        public void LeerProcedimiento(){

           List<TbPreguntaProcedimientoAlmacenado> p =  baseDatos.ObtenerPreguntasProcedimiento();
            foreach(TbPreguntaProcedimientoAlmacenado pregunta in p ){
            Console.Write("Id " + pregunta.Id_Pregunta);
            Console.Write(" Rubro " + pregunta.Id_Rubro);
            Console.Write(" Pregunta " + pregunta.Pregunta);
            Console.Write(" Puntaje " + pregunta.Puntaje);
            Console.WriteLine();

            }
        }
    }
}