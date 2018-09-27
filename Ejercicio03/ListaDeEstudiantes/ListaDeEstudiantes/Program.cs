using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("HOla mundo");
            //Console.ReadLine();

            //Estudiante student = new Estudiante();

            //student.Id = 2675;
            //student.Nombre = "Javier";
            //student.Apellido = "Rosas";

            //Console.WriteLine(student.Nombre +" "+student.Apellido);
            //Console.ReadKey();

            //Console.WriteLine("##### Bienvenidos a la lista de estudiante #####");

            //Console.WriteLine(" Agrega un Estudiante ");

            //Console.WriteLine("Defina su número de estudiante");
            //int studentNumber = Convert.ToInt32(Console.ReadLine());
            //Estudiante[] studentArray = new Estudiante[studentNumber];

            //for (int i = 0; i < studentArray.Length; i++)
            //{
            //    Estudiante student = new Estudiante();
            //    Console.WriteLine("Escriba el nombre del estudiante");
            //    student.Nombre = Console.ReadLine();
            //    Console.WriteLine("Escriba el Apellido");
            //    student.Apellido = Console.ReadLine();
            //    Console.WriteLine("Escriba el Id");
            //    student.Id = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Escriba la Edad");
            //    student.Edad = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Escriba el Semestre");
            //    student.Semestre = Console.ReadLine();
            //    Console.WriteLine("Escriba el Sexo");
            //    student.Sexo = Convert.ToChar(Console.ReadLine());
            //    studentArray[i] = student;

            //}

            //Console.WriteLine("Los estudiantes Ingresados son: \n");
            //Console.WriteLine("Nombre \t Apellido \t Semestre \t Numero Control");
            //for (int i = 0; i < studentArray.Length; i++)
            //{
            //    Console.WriteLine(studentArray[i].Nombre+" \t"+studentArray[i].Apellido+"\t"+
            //        studentArray[i].Semestre+" \t"+studentArray[i].Id);

            //}

            //Console.ReadKey();
            Estudiante student = new Estudiante();
            student.Nombre = "Juan";
            student.Apellido = "Vargas";
            student.Id = 25;

            Estudiante perfil = new Estudiante();
            perfil.VerInformacion(student);
            perfil.VerInformacion(student,"Informacion Presentada");


        }
    }
}
