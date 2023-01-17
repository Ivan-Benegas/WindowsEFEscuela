using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEF.Data;
using WindowsEF.Models;

namespace WindowsEF.Dac
{
    public class AbmAlumno
    {
        private static DBEscuelaEFContext context = new DBEscuelaEFContext();

        public static List<Alumno> SelectAll()
        {
            return context.Alumnos.ToList();
        }

        public static Alumno SelectWhereById(int id)
        {
            return context.Alumnos.Find(id);
        }

        public static int Insert(Alumno alumno)
        {
            context.Alumnos.Add(alumno);

            return context.SaveChanges();
        }

        public static int Update(Alumno alumno)
        {
            Alumno alumnoOrigen = context.Alumnos.Find(alumno.IdAlumno);

            alumnoOrigen.Nombre = alumno.Nombre;
            alumnoOrigen.Apellido = alumno.Apellido;
            alumnoOrigen.FechaNacimiento = alumno.FechaNacimiento;

            return context.SaveChanges();
        }

        public static int Delete(Alumno alumno)
        {
            Alumno alumnoOrigen = context.Alumnos.Find(alumno.IdAlumno);

            if (alumnoOrigen != null)
            {
                context.Alumnos.Remove(alumnoOrigen);

                return context.SaveChanges();
            }

            return 0;
        }



    }
}
